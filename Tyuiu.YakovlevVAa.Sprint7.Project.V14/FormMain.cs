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
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string path = dlg.FileName;
            dataGridView_YVA.DataSource = ds.ReadRoutesFromCsv(path);
            dataGridView_YVA.Columns[0].HeaderText = "��� ����������";
            dataGridView_YVA.Columns[1].HeaderText = "����� ��������";
            dataGridView_YVA.Columns[2].HeaderText = "���� �������� ��������";
            dataGridView_YVA.Columns[3].HeaderText = "��������� ���������";
            dataGridView_YVA.Columns[4].HeaderText = "�������� ���������";
            dataGridView_YVA.Columns[5].HeaderText = "����� � ����";
            dataGridView_YVA.Columns[6].HeaderText = "����������";
            this.����������������������ToolStripMenuItem_YVA.Enabled = true;
            this.��������������������������ToolStripMenuItem.Enabled = true;
            this.���������������ToolStripMenuItem.Enabled = true;

        }
        

        
    }
}
