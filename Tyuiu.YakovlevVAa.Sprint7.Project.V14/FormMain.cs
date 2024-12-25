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
        AutoCompleteStringCollection driverNumComplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection RouteNumComplete = new AutoCompleteStringCollection();


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
                for (int i = 0; i < dataGridView_YVA.RowCount; i++)
                {

                    RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[1].Value.ToString());
                    RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[3].Value.ToString());
                    RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[4].Value.ToString());
                    

                }
                this.textBoxSearch_YVA.AutoCompleteCustomSource = RouteNumComplete;
                this.textBoxSearch_YVA.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearch_YVA.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        public void buttonAddCustomRows_YVA_Click(object sender, EventArgs e)
        {
            using (var inputForm = new FormMultipleRowsAdd())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int rowCount = inputForm.RowCount;

                    // Добавление строк в DataGridView
                    for (int i = 0; i < rowCount; i++)
                    {
                        dataGridView_YVA.Rows.Add("Неизвестно", "Неизвестно", DateTime.Today.ToShortDateString(), "Неизвестно", "Неизвестно", "00:00:00", "Новый маршрут"); // Добавление строки с примерными данными
                        RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[1].Value.ToString());
                        RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[3].Value.ToString());
                        RouteNumComplete.Add(this.dataGridView_YVA.Rows[i].Cells[4].Value.ToString());
                        textBoxSearch_YVA.AutoCompleteCustomSource.Add(this.dataGridView_YVA.Rows[i].Cells[1].Value.ToString());
                        textBoxSearch_YVA.AutoCompleteCustomSource.Add(this.dataGridView_YVA.Rows[i].Cells[3].Value.ToString());
                        textBoxSearch_YVA.AutoCompleteCustomSource.Add(this.dataGridView_YVA.Rows[i].Cells[4].Value.ToString());

                        
                    }
                }
            }
        }
        public void buttonAddRow_YVA_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView_YVA.Rows.Add("Неизвестно", "Неизвестно", DateTime.Today.ToShortDateString(), "Неизвестно", "Неизвестно", "00:00:00", "Новый маршрут");
                RouteNumComplete.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[1].Value.ToString());
                RouteNumComplete.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[3].Value.ToString());
                RouteNumComplete.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[4].Value.ToString());
                textBoxSearch_YVA.AutoCompleteCustomSource.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[1].Value.ToString());
                textBoxSearch_YVA.AutoCompleteCustomSource.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[3].Value.ToString());
                textBoxSearch_YVA.AutoCompleteCustomSource.Add(dataGridView_YVA.Rows[dataGridView_YVA.Rows.Count - 1].Cells[4].Value.ToString());
                //comboBoxFilter_YVA.Items.Clear();
                //InitializeComboBox();
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

        public void buttonSave_YVA_Click(object sender, EventArgs e)
        {
            this.saveFileDialogProject_YVA.FileName = "OutPutRoutes.csv";
            
            string path = "c:\\DataSprint7\\OutPutRoutes.csv";
            
            int row = this.dataGridView_YVA.RowCount;
            int column = this.dataGridView_YVA.ColumnCount;
            string str = "";
            if (saveFileDialogProject_YVA.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();
                foreach (DataGridViewRow rows in dataGridView_YVA.Rows)
                {
                    List<string> values = new List<string>();
                    foreach (DataGridViewCell cell in rows.Cells)
                    {
                        values.Add(cell.Value?.ToString()??"");
                    }
                    string line = string.Join(",", values);
                    lines.Add(line);
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialogProject_YVA.FileName))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
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
                    deleteRow.Click += (s, ev) =>
                    {


                        int rowIndex = hitTest.RowIndex;
                        if (rowIndex >= 0 && rowIndex < dataGridView_YVA.Rows.Count)
                        {
                            string valueToRemove1 = dataGridView_YVA.Rows[rowIndex].Cells[1].Value.ToString();
                            string valueToRemove4 = dataGridView_YVA.Rows[rowIndex].Cells[3].Value.ToString();
                            string valueToRemove5 = dataGridView_YVA.Rows[rowIndex].Cells[4].Value.ToString();
                            RouteNumComplete.Remove(valueToRemove1);
                            RouteNumComplete.Remove(valueToRemove4);
                            RouteNumComplete.Remove(valueToRemove5);
                            textBoxSearch_YVA.AutoCompleteCustomSource.Remove(valueToRemove1);
                            textBoxSearch_YVA.AutoCompleteCustomSource.Remove(valueToRemove4);
                            textBoxSearch_YVA.AutoCompleteCustomSource.Remove(valueToRemove5);
                            DeleteRow(rowIndex);

                        }
                    };
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

                //comboBoxFilter_YVA.Items.Clear();
                //InitializeComboBox();

            }
        }
        private void dataGridView_YVA_CellValidate(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DateTime dateValue;
                if (!DateTime.TryParseExact(e.FormattedValue.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                {
                    MessageBox.Show("Введите дату в формате дд.мм.гггг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 5)
            {
                string input = e.FormattedValue.ToString();
                string[] timeParts = input.Split(':');

                if (timeParts.Length == 3)
                {
                    // Проверяем, что часы - это положительное целое число
                    if (int.TryParse(timeParts[0], out int hours) && hours >= 0 &&
                        int.TryParse(timeParts[1], out int minutes) && minutes >= 0 && minutes < 60 &&
                        int.TryParse(timeParts[2], out int seconds) && seconds >= 0 && seconds < 60)
                    {
                        // Если все значения корректны, присваиваем значение ячейке
                        dataGridView_YVA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

                    }
                    else
                    {
                        // Если минуты или секунды вне диапазона, выводим сообщение об ошибке
                        MessageBox.Show("Часы могут быть любым положительным целым числом, а минуты и секунды должны быть в диапазоне от 00 до 59.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Введите время в формате чч:мм:сс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

        }
        private void buttonSearch_YVA_Click(object sender, EventArgs e)
        {
            this.textBoxSearch_YVA.AutoCompleteMode = AutoCompleteMode.Suggest;
            string searchValue = textBoxSearch_YVA.Text.ToLower();
            bool found = false;
            foreach (DataGridViewRow row in dataGridView_YVA.Rows)
            {
                bool isMatch = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) || row.Cells[1].Value.ToString().ToLower().Contains(searchValue) || row.Cells[3].Value.ToString().ToLower().Contains(searchValue) || row.Cells[4].Value.ToString().ToLower().Contains(searchValue) || row.Cells[6].Value.ToString().ToLower().Contains(searchValue);
                row.Visible = isMatch;
                if (isMatch)
                {
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Совпадений не найдено.");
            }
        }
        private void dataGridView_YVA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedValue = dataGridView_YVA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            
            if (!string.IsNullOrEmpty(editedValue) && !RouteNumComplete.Contains(editedValue) && (e.ColumnIndex == 1) && (e.ColumnIndex == 3)&& (e.ColumnIndex == 4))
            {
                // Добавляем значение в коллекцию автозаполнения
                RouteNumComplete.Add(editedValue);
                // Добавляем значение в AutoCompleteCustomSource для textBoxSearch
                textBoxSearch_YVA.AutoCompleteCustomSource.Add(editedValue);
               
            }
        }
        private void dataGridView_YVA_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView_YVA.CurrentCell != null)
            {
                int columnIndex = dataGridView_YVA.CurrentCell.ColumnIndex;

                // Проверяем, что редактируется 2-й, 5-й или 6-й столбец
                if (columnIndex == 1 || columnIndex == 3 || columnIndex == 4)
                {
                    // Сохраняем старое значение, чтобы его можно было удалить позже
                    string oldValue = dataGridView_YVA.Rows[e.RowIndex].Cells[columnIndex].Value?.ToString();
                    dataGridView_YVA.Tag = oldValue; // Сохраняем старое значение во временной переменной
                }
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_YVA.CurrentCell != null)
            {
                int columnIndex = dataGridView_YVA.CurrentCell.ColumnIndex;

                // Проверяем, что изменяется 2-й, 4-й или 5-й столбец
                if (columnIndex == 1 || columnIndex == 3 || columnIndex == 4)
                {
                    // Получаем старое значение из Tag, которое мы сохранили во время начала редактирования
                    string oldValue = dataGridView_YVA.Tag as string;

                    // Удаляем старое значение из RouteNumComplete, если оно не пустое
                    if (!string.IsNullOrEmpty(oldValue))
                    {
                        RouteNumComplete.Remove(oldValue);
                        textBoxSearch_YVA.AutoCompleteCustomSource.Remove(oldValue);
                    }

                    // Получаем новое значение из ячейки
                    string newValue = dataGridView_YVA.CurrentCell.Value?.ToString();

                    // Добавляем новое значение в RouteNumComplete, если оно не пустое и отсутствует в коллекции
                    if (!string.IsNullOrEmpty(newValue) && !RouteNumComplete.Contains(newValue) && !textBoxSearch_YVA.AutoCompleteCustomSource.Contains(newValue))
                    {
                        RouteNumComplete.Add(newValue);
                        textBoxSearch_YVA.AutoCompleteCustomSource.Add(newValue);
                    }
                }
            }
        }
    }
}

