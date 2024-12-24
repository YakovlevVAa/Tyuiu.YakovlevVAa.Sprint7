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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_YVA = new MenuStrip();
            программаToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem_YVA = new ToolStripMenuItem();
            сохранитьФайлToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuItemExit_YVA = new ToolStripMenuItem();
            строкиToolStripMenuItem = new ToolStripMenuItem();
            включитьРедактированиеToolStripMenuItem_YVA = new ToolStripMenuItem();
            включитьДобавлениеудалениеToolStripMenuItem = new ToolStripMenuItem();
            добавлениеСтрокToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            добавитьПроизвольноеКоличествоСтрокToolStripMenuItem = new ToolStripMenuItem();
            groupBoxValues_YVA = new GroupBox();
            dataGridView_YVA = new DataGridView();
            buttonAbout_YVA = new Button();
            openFileDialog_YVA = new OpenFileDialog();
            menuStrip_YVA.SuspendLayout();
            groupBoxValues_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVA).BeginInit();
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
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem_YVA, сохранитьФайлToolStripMenuItem, toolStripSeparator1, ToolStripMenuItemExit_YVA });
            программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            программаToolStripMenuItem.Size = new Size(125, 29);
            программаToolStripMenuItem.Text = "Программа";
            // 
            // открытьФайлToolStripMenuItem_YVA
            // 
            открытьФайлToolStripMenuItem_YVA.Name = "открытьФайлToolStripMenuItem_YVA";
            открытьФайлToolStripMenuItem_YVA.Size = new Size(245, 34);
            открытьФайлToolStripMenuItem_YVA.Text = "Открыть файл";
            открытьФайлToolStripMenuItem_YVA.Click += buttonLoad_YVA_Click;
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            сохранитьФайлToolStripMenuItem.Enabled = false;
            сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            сохранитьФайлToolStripMenuItem.Size = new Size(245, 34);
            сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(242, 6);
            // 
            // ToolStripMenuItemExit_YVA
            // 
            ToolStripMenuItemExit_YVA.Name = "ToolStripMenuItemExit_YVA";
            ToolStripMenuItemExit_YVA.Size = new Size(245, 34);
            ToolStripMenuItemExit_YVA.Text = "Выйти";
            ToolStripMenuItemExit_YVA.Click += buttonExit_YVA_Click;
            // 
            // строкиToolStripMenuItem
            // 
            строкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { включитьРедактированиеToolStripMenuItem_YVA, включитьДобавлениеудалениеToolStripMenuItem, добавлениеСтрокToolStripMenuItem });
            строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            строкиToolStripMenuItem.Size = new Size(87, 29);
            строкиToolStripMenuItem.Text = "Строки";
            // 
            // включитьРедактированиеToolStripMenuItem_YVA
            // 
            включитьРедактированиеToolStripMenuItem_YVA.Enabled = false;
            включитьРедактированиеToolStripMenuItem_YVA.Name = "включитьРедактированиеToolStripMenuItem_YVA";
            включитьРедактированиеToolStripMenuItem_YVA.Size = new Size(377, 34);
            включитьРедактированиеToolStripMenuItem_YVA.Text = "Включить редактирование";
            // 
            // включитьДобавлениеудалениеToolStripMenuItem
            // 
            включитьДобавлениеудалениеToolStripMenuItem.Enabled = false;
            включитьДобавлениеудалениеToolStripMenuItem.Name = "включитьДобавлениеудалениеToolStripMenuItem";
            включитьДобавлениеудалениеToolStripMenuItem.Size = new Size(377, 34);
            включитьДобавлениеудалениеToolStripMenuItem.Text = "Включить добавление/удаление";
            // 
            // добавлениеСтрокToolStripMenuItem
            // 
            добавлениеСтрокToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтрокуToolStripMenuItem, добавитьПроизвольноеКоличествоСтрокToolStripMenuItem });
            добавлениеСтрокToolStripMenuItem.Enabled = false;
            добавлениеСтрокToolStripMenuItem.Name = "добавлениеСтрокToolStripMenuItem";
            добавлениеСтрокToolStripMenuItem.Size = new Size(377, 34);
            добавлениеСтрокToolStripMenuItem.Text = "Добавление строк";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            добавитьСтрокуToolStripMenuItem.Size = new Size(466, 34);
            добавитьСтрокуToolStripMenuItem.Text = "Добавить строку";
            // 
            // добавитьПроизвольноеКоличествоСтрокToolStripMenuItem
            // 
            добавитьПроизвольноеКоличествоСтрокToolStripMenuItem.Name = "добавитьПроизвольноеКоличествоСтрокToolStripMenuItem";
            добавитьПроизвольноеКоличествоСтрокToolStripMenuItem.Size = new Size(466, 34);
            добавитьПроизвольноеКоличествоСтрокToolStripMenuItem.Text = "Добавить произвольное количество строк";
            // 
            // groupBoxValues_YVA
            // 
            groupBoxValues_YVA.Controls.Add(dataGridView_YVA);
            groupBoxValues_YVA.Location = new Point(12, 45);
            groupBoxValues_YVA.Name = "groupBoxValues_YVA";
            groupBoxValues_YVA.Size = new Size(923, 562);
            groupBoxValues_YVA.TabIndex = 1;
            groupBoxValues_YVA.TabStop = false;
            groupBoxValues_YVA.Text = "Данные";
            // 
            // dataGridView_YVA
            // 
            dataGridView_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_YVA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_YVA.Location = new Point(6, 30);
            dataGridView_YVA.Name = "dataGridView_YVA";
            dataGridView_YVA.RowHeadersWidth = 62;
            dataGridView_YVA.Size = new Size(911, 526);
            dataGridView_YVA.TabIndex = 0;
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
            // openFileDialog_YVA
            // 
            openFileDialog_YVA.FileName = "openFileDialog1";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_YVA;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem_YVA;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripMenuItemExit_YVA;
        private GroupBox groupBoxValues_YVA;
        private DataGridView dataGridView_YVA;
        private ToolStripMenuItem строкиToolStripMenuItem;
        private ToolStripMenuItem включитьРедактированиеToolStripMenuItem_YVA;
        private ToolStripMenuItem включитьДобавлениеудалениеToolStripMenuItem;
        private Button buttonAbout_YVA;
        private ToolStripMenuItem добавлениеСтрокToolStripMenuItem;
        private ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private ToolStripMenuItem добавитьПроизвольноеКоличествоСтрокToolStripMenuItem;
        private OpenFileDialog openFileDialog_YVA;
    }
}
