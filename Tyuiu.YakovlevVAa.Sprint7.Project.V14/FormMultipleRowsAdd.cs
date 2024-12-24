using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    public partial class FormMultipleRowsAdd : Form
    {
        public int RowCount { get; private set; }
        public FormMultipleRowsAdd()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textRowCount_YVA.Text, out int count) && count > 0)
            {
                RowCount = count;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите положительное целое число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
