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
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip_YVA.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_YVA
            // 
            menuStrip_YVA.Dock = DockStyle.None;
            menuStrip_YVA.ImageScalingSize = new Size(24, 24);
            menuStrip_YVA.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem });
            menuStrip_YVA.Location = new Point(9, 9);
            menuStrip_YVA.Name = "menuStrip_YVA";
            menuStrip_YVA.Size = new Size(313, 33);
            menuStrip_YVA.TabIndex = 0;
            menuStrip_YVA.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, сохранитьФайлToolStripMenuItem, toolStripSeparator1, выйтиToolStripMenuItem });
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
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(270, 34);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 619);
            Controls.Add(menuStrip_YVA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_YVA;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Городской транспорт";
            menuStrip_YVA.ResumeLayout(false);
            menuStrip_YVA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_YVA;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выйтиToolStripMenuItem;
    }
}
