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
        private void LoadDataIntoDataGridView(List<object[]> processedData)
        {
            // Очистка предыдущих данных
            dataGridView_YVA.Rows.Clear();

            foreach (var row in processedData)
            {
                dataGridView_YVA.Rows.Add(row);
            }
        }
        private void buttonLoad_YVA_Click(Object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog_YVA.ShowDialog();
                DataService ds = new DataService();
                string filePath = openFileDialog_YVA.FileName;
                
                var rawData = ds.LoadCsvData(filePath);
                var processedData = ds.ProcessData(rawData);
                LoadDataIntoDataGridView(processedData);
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.SaveFileButton_YVA.Enabled = true;
            this.EditEnableButton_YVA.Enabled = true;
            this.EditDisableButton_YVA.Enabled = true;
            this.EditRowsButton_YVA.Enabled = true;



        }
        public void buttonAddCustomRows_YVA_Click( object sender, EventArgs e )
        {
            using (var inputForm = new FormMultipleRowsAdd())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int rowCount = inputForm.RowCount;

                    // Добавление строк в DataGridView
                    for (int i = 0; i < rowCount; i++)
                    {
                        dataGridView_YVA.Rows.Add(0,0,DateTime.Today.ToShortDateString(),0,0,0,"Новый маршрут"); // Добавление строки с примерными данными
                    }
                }
            }
        }
        public void buttonAddRow_YVA_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView_YVA.Rows.Add(0, 0, DateTime.Today.ToShortDateString(), 0, 0, 0, "Новый маршрут");
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
                    ToolStripMenuItem deleteRow = new ToolStripMenuItem("Удалить строку");
                    ToolStripMenuItem markRow = new ToolStripMenuItem("Выделить строку");
                    ToolStripMenuItem unmarkRow = new ToolStripMenuItem("Убрать выделение");
                    deleteRow.Click += (s, ev) => DeleteRow(hitTest.RowIndex);
                    markRow.Click += (s, ev) => dataGridView_YVA.Rows[hitTest.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                    unmarkRow.Click += (s, ev) => dataGridView_YVA.Rows[hitTest.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    contextMenu.Items.Add(deleteRow);
                    contextMenu.Items.Add(markRow);
                    contextMenu.Items.Add(unmarkRow);
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
        private void dataGridView_YVA_CellValidate(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                DateTime dateValue;
                if(!DateTime.TryParseExact(e.FormattedValue.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                    {
                    MessageBox.Show("Введите дату в формате дд.мм.гггг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                 
                
            }
            if(e.ColumnIndex == 5)
            {
                TimeSpan timeValue;
                
                if (!TimeSpan.TryParseExact(e.FormattedValue.ToString(), @"hh\:mm\:ss", CultureInfo.InvariantCulture,TimeSpanStyles.None, out timeValue))
                    {
                    MessageBox.Show("Введите время в формате чч:мм:сс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    dataGridView_YVA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = timeValue.ToString(@"hh\:mm\:ss");
                }
            }
        }
        
        
    }
}



