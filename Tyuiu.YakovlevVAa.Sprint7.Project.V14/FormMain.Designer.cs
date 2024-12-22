namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_YVA = new MenuStrip();
            программаToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьФайлToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuItemExit_YVA = new ToolStripMenuItem();
            строкиToolStripMenuItem = new ToolStripMenuItem();
            включитьРедактированиеToolStripMenuItem = new ToolStripMenuItem();
            включитьДобавлениеудалениеToolStripMenuItem = new ToolStripMenuItem();
            groupBoxValues_YVA = new GroupBox();
            dataGridView1 = new DataGridView();
            buttonAbout_YVA = new Button();
            menuStrip_YVA.SuspendLayout();
            groupBoxValues_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_YVA
            // 
            menuStrip_YVA.Dock = DockStyle.None;
            menuStrip_YVA.ImageScalingSize = new Size(24, 24);
            menuStrip_YVA.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem, строкиToolStripMenuItem });
            menuStrip_YVA.Location = new Point(9, 9);
            menuStrip_YVA.Name = "menuStrip_YVA";
            menuStrip_YVA.Size = new Size(400, 33);
            menuStrip_YVA.TabIndex = 0;
            menuStrip_YVA.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, сохранитьФайлToolStripMenuItem, toolStripSeparator1, ToolStripMenuItemExit_YVA });
            программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            программаToolStripMenuItem.Size = new Size(125, 29);
            программаToolStripMenuItem.Text = "Программа";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(270, 34);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            сохранитьФайлToolStripMenuItem.Enabled = false;
            сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            сохранитьФайлToolStripMenuItem.Size = new Size(270, 34);
            сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // ToolStripMenuItemExit_YVA
            // 
            ToolStripMenuItemExit_YVA.Name = "ToolStripMenuItemExit_YVA";
            ToolStripMenuItemExit_YVA.Size = new Size(270, 34);
            ToolStripMenuItemExit_YVA.Text = "Выйти";
            ToolStripMenuItemExit_YVA.Click += buttonExit_YVA_Click;
            // 
            // строкиToolStripMenuItem
            // 
            строкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { включитьРедактированиеToolStripMenuItem, включитьДобавлениеудалениеToolStripMenuItem });
            строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            строкиToolStripMenuItem.Size = new Size(87, 29);
            строкиToolStripMenuItem.Text = "Строки";
            // 
            // включитьРедактированиеToolStripMenuItem
            // 
            включитьРедактированиеToolStripMenuItem.Enabled = false;
            включитьРедактированиеToolStripMenuItem.Name = "включитьРедактированиеToolStripMenuItem";
            включитьРедактированиеToolStripMenuItem.Size = new Size(377, 34);
            включитьРедактированиеToolStripMenuItem.Text = "Включить редактирование";
            // 
            // включитьДобавлениеудалениеToolStripMenuItem
            // 
            включитьДобавлениеудалениеToolStripMenuItem.Enabled = false;
            включитьДобавлениеудалениеToolStripMenuItem.Name = "включитьДобавлениеудалениеToolStripMenuItem";
            включитьДобавлениеудалениеToolStripMenuItem.Size = new Size(377, 34);
            включитьДобавлениеудалениеToolStripMenuItem.Text = "Включить добавление/удаление";
            // 
            // groupBoxValues_YVA
            // 
            groupBoxValues_YVA.Controls.Add(dataGridView1);
            groupBoxValues_YVA.Location = new Point(12, 45);
            groupBoxValues_YVA.Name = "groupBoxValues_YVA";
            groupBoxValues_YVA.Size = new Size(923, 562);
            groupBoxValues_YVA.TabIndex = 1;
            groupBoxValues_YVA.TabStop = false;
            groupBoxValues_YVA.Text = "Данные";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(911, 526);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAbout_YVA
            // 
            buttonAbout_YVA.FlatStyle = FlatStyle.Popup;
            buttonAbout_YVA.Location = new Point(1327, 9);
            buttonAbout_YVA.Name = "buttonAbout_YVA";
            buttonAbout_YVA.Size = new Size(39, 34);
            buttonAbout_YVA.TabIndex = 2;
            buttonAbout_YVA.UseVisualStyleBackColor = true;
            buttonAbout_YVA.Click += buttonAbout_YVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 619);
            Controls.Add(buttonAbout_YVA);
            Controls.Add(groupBoxValues_YVA);
            Controls.Add(menuStrip_YVA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_YVA;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Городской транспорт";
            menuStrip_YVA.ResumeLayout(false);
            menuStrip_YVA.PerformLayout();
            groupBoxValues_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_YVA;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripMenuItemExit_YVA;
        private GroupBox groupBoxValues_YVA;
        private DataGridView dataGridView1;
        private ToolStripMenuItem строкиToolStripMenuItem;
        private ToolStripMenuItem включитьРедактированиеToolStripMenuItem;
        private ToolStripMenuItem включитьДобавлениеудалениеToolStripMenuItem;
        private Button buttonAbout_YVA;
    }
}
