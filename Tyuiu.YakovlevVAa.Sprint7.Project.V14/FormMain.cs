using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib;
using static Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib.DataService;
namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();



        public FormMain()
        {
            InitializeComponent();
            openFileDialog_YVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogProject_YVA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";




        }



        private void buttonAbout_YVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonExit_YVA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonLoad_YVA_Click(Object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog_YVA.ShowDialog();
                string filePath = openFileDialog_YVA.FileName;
                DataService ds = new DataService();

                List<string[]> csvData = ds.LoadDataFromFile(filePath);
                this.dataGridView_YVA.Rows.Clear();


                for (int i = 1; i < csvData.Count; i++)
                {

                    dataGridView_YVA.Rows.Add(csvData[i]);

                }


            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.SaveFileButton_YVA.Enabled = true;
            this.EditEnableButton_YVA.Enabled = true;
            this.EditDisableButton_YVA.Enabled = true;
            this.EditRowsButton_YVA.Enabled = true;



        }
        public void buttonAddRow_YVA_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView_YVA.Rows.Add(0, 0, DateTime.Today, 0, 0, 0, "Новый маршрут");
            }
            catch
            {
                MessageBox.Show("Вы не можете добавить новую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EditEnableButton_YVA_Click(Object sender, EventArgs e)
        {
            dataGridView_YVA.ReadOnly = false;
            EditEnableButton_YVA.Checked = true;
            EditDisableButton_YVA.Checked = false;
        }
        public void EditDisableButton_YVA_Click(Object sender, EventArgs e)
        {
            dataGridView_YVA.ReadOnly = true;
            EditEnableButton_YVA.Checked = false;
            EditDisableButton_YVA.Checked = true;
        }
        public void dataGridView_YVA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (DateTime.TryParse(e.FormattedValue.ToString(), out DateTime dateValue))
                {
                }



            }
        }
        public void buttonSave_YVA_Click(object sender, EventArgs e)
        {
            this.saveFileDialogProject_YVA.FileName = "OutPutRoutes.csv";
            this.saveFileDialogProject_YVA.InitialDirectory = Directory.GetCurrentDirectory();
            string path = "c:\\DataSprint7\\OutPutRoutes.csv";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            int row = this.dataGridView_YVA.RowCount;
            int column = this.dataGridView_YVA.ColumnCount;
            string str = "";
            if (this.saveFileDialogProject_YVA.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (j == column - 1)
                        {
                            str += this.dataGridView_YVA.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            str += this.dataGridView_YVA.Rows[i].Cells[j].Value.ToString() + ",";
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }
        public void dataGridView_YVA_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridView_YVA.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    dataGridView_YVA.ClearSelection();
                    dataGridView_YVA.Rows[hitTest.RowIndex].Selected = true;
                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить строку");
                    deleteItem.Click += (s, ev) => DeleteRow(hitTest.RowIndex);
                    contextMenu.Items.Add(deleteItem);
                    contextMenu.Show(dataGridView_YVA, e.Location);
                }
            }

        }
        private void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView_YVA.Rows.Count)
            {
                dataGridView_YVA.Rows.RemoveAt(rowIndex);
            }
        }
    }
}



