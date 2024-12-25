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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_YVA = new MenuStrip();
            программаToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem_YVA = new ToolStripMenuItem();
            SaveFileButton_YVA = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuItemExit_YVA = new ToolStripMenuItem();
            строкиToolStripMenuItem = new ToolStripMenuItem();
            EditEnableButton_YVA = new ToolStripMenuItem();
            EditDisableButton_YVA = new ToolStripMenuItem();
            EditRowsButton_YVA = new ToolStripMenuItem();
            buttonAddRow_YVA = new ToolStripMenuItem();
            buttonAddCustomRows_YVA = new ToolStripMenuItem();
            groupBoxValues_YVA = new GroupBox();
            dataGridView_YVA = new DataGridView();
            VehicleType = new DataGridViewTextBoxColumn();
            RouteNumber = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            StartStop = new DataGridViewTextBoxColumn();
            EndStop = new DataGridViewTextBoxColumn();
            TimeSpanRoute = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            buttonAbout_YVA = new Button();
            openFileDialog_YVA = new OpenFileDialog();
            saveFileDialogProject_YVA = new SaveFileDialog();
            contextMenuStripProject_YVA = new ContextMenuStrip(components);
            toolTip_YVA = new ToolTip(components);
            tabControl_YVA = new TabControl();
            tabPageFilter_YVA = new TabPage();
            comboBoxFilter_YVA = new ComboBox();
            tabPageSearch_YVA = new TabPage();
            buttonSearch_YVA = new Button();
            textBoxSearch_YVA = new TextBox();
            menuStrip_YVA.SuspendLayout();
            groupBoxValues_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVA).BeginInit();
            tabControl_YVA.SuspendLayout();
            tabPageFilter_YVA.SuspendLayout();
            tabPageSearch_YVA.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_YVA
            // 
            menuStrip_YVA.Dock = DockStyle.None;
            menuStrip_YVA.ImageScalingSize = new Size(24, 24);
            menuStrip_YVA.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem, строкиToolStripMenuItem });
            menuStrip_YVA.Location = new Point(9, 9);
            menuStrip_YVA.Name = "menuStrip_YVA";
            menuStrip_YVA.Size = new Size(220, 33);
            menuStrip_YVA.TabIndex = 0;
            menuStrip_YVA.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem_YVA, SaveFileButton_YVA, toolStripSeparator1, ToolStripMenuItemExit_YVA });
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
            // SaveFileButton_YVA
            // 
            SaveFileButton_YVA.Enabled = false;
            SaveFileButton_YVA.Name = "SaveFileButton_YVA";
            SaveFileButton_YVA.Size = new Size(245, 34);
            SaveFileButton_YVA.Text = "Сохранить файл";
            SaveFileButton_YVA.Click += buttonSave_YVA_Click;
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
            строкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EditEnableButton_YVA, EditDisableButton_YVA, EditRowsButton_YVA });
            строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            строкиToolStripMenuItem.Size = new Size(87, 29);
            строкиToolStripMenuItem.Text = "Строки";
            // 
            // EditEnableButton_YVA
            // 
            EditEnableButton_YVA.Enabled = false;
            EditEnableButton_YVA.Name = "EditEnableButton_YVA";
            EditEnableButton_YVA.Size = new Size(346, 34);
            EditEnableButton_YVA.Text = "Включить редактирование";
            EditEnableButton_YVA.Click += EditEnableButton_YVA_Click;
            // 
            // EditDisableButton_YVA
            // 
            EditDisableButton_YVA.Enabled = false;
            EditDisableButton_YVA.Name = "EditDisableButton_YVA";
            EditDisableButton_YVA.Size = new Size(346, 34);
            EditDisableButton_YVA.Text = "Выключить редактирование";
            EditDisableButton_YVA.Click += EditDisableButton_YVA_Click;
            // 
            // EditRowsButton_YVA
            // 
            EditRowsButton_YVA.DropDownItems.AddRange(new ToolStripItem[] { buttonAddRow_YVA, buttonAddCustomRows_YVA });
            EditRowsButton_YVA.Enabled = false;
            EditRowsButton_YVA.Name = "EditRowsButton_YVA";
            EditRowsButton_YVA.Size = new Size(346, 34);
            EditRowsButton_YVA.Text = "Добавление строк";
            // 
            // buttonAddRow_YVA
            // 
            buttonAddRow_YVA.Name = "buttonAddRow_YVA";
            buttonAddRow_YVA.Size = new Size(466, 34);
            buttonAddRow_YVA.Text = "Добавить строку";
            buttonAddRow_YVA.Click += buttonAddRow_YVA_Click;
            // 
            // buttonAddCustomRows_YVA
            // 
            buttonAddCustomRows_YVA.Name = "buttonAddCustomRows_YVA";
            buttonAddCustomRows_YVA.Size = new Size(466, 34);
            buttonAddCustomRows_YVA.Text = "Добавить произвольное количество строк";
            buttonAddCustomRows_YVA.Click += buttonAddCustomRows_YVA_Click;
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
            dataGridView_YVA.AllowUserToAddRows = false;
            dataGridView_YVA.AllowUserToDeleteRows = false;
            dataGridView_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_YVA.Columns.AddRange(new DataGridViewColumn[] { VehicleType, RouteNumber, StartDate, StartStop, EndStop, TimeSpanRoute, Notes });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_YVA.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_YVA.Location = new Point(6, 30);
            dataGridView_YVA.Name = "dataGridView_YVA";
            dataGridView_YVA.ReadOnly = true;
            dataGridView_YVA.RowHeadersWidth = 62;
            dataGridView_YVA.Size = new Size(911, 526);
            dataGridView_YVA.TabIndex = 0;
            dataGridView_YVA.CellBeginEdit += dataGridView_YVA_CellBeginEdit;
            dataGridView_YVA.CellEndEdit += dataGridView_YVA_CellEndEdit;
            dataGridView_YVA.CellValidating += dataGridView_YVA_CellValidate;
            dataGridView_YVA.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView_YVA.MouseDown += dataGridView_YVA_MouseDown;
            // 
            // VehicleType
            // 
            VehicleType.HeaderText = "Тип транспорта";
            VehicleType.MinimumWidth = 8;
            VehicleType.Name = "VehicleType";
            VehicleType.ReadOnly = true;
            VehicleType.Width = 150;
            // 
            // RouteNumber
            // 
            RouteNumber.HeaderText = "Номер маршрута";
            RouteNumber.MinimumWidth = 8;
            RouteNumber.Name = "RouteNumber";
            RouteNumber.ReadOnly = true;
            RouteNumber.Width = 150;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Дата введения маршрута";
            StartDate.MinimumWidth = 8;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.Width = 150;
            // 
            // StartStop
            // 
            StartStop.HeaderText = "Начальная остановка";
            StartStop.MinimumWidth = 8;
            StartStop.Name = "StartStop";
            StartStop.ReadOnly = true;
            StartStop.Width = 150;
            // 
            // EndStop
            // 
            EndStop.HeaderText = "Конечная остановка";
            EndStop.MinimumWidth = 8;
            EndStop.Name = "EndStop";
            EndStop.ReadOnly = true;
            EndStop.Width = 150;
            // 
            // TimeSpanRoute
            // 
            TimeSpanRoute.HeaderText = "Время в пути";
            TimeSpanRoute.MinimumWidth = 8;
            TimeSpanRoute.Name = "TimeSpanRoute";
            TimeSpanRoute.ReadOnly = true;
            TimeSpanRoute.Width = 150;
            // 
            // Notes
            // 
            Notes.HeaderText = "Примечание";
            Notes.MinimumWidth = 8;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 150;
            // 
            // buttonAbout_YVA
            // 
            buttonAbout_YVA.BackgroundImage = (Image)resources.GetObject("buttonAbout_YVA.BackgroundImage");
            buttonAbout_YVA.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_YVA.FlatStyle = FlatStyle.Popup;
            buttonAbout_YVA.Location = new Point(1327, 9);
            buttonAbout_YVA.Name = "buttonAbout_YVA";
            buttonAbout_YVA.Size = new Size(39, 39);
            buttonAbout_YVA.TabIndex = 2;
            buttonAbout_YVA.UseVisualStyleBackColor = true;
            buttonAbout_YVA.Click += buttonAbout_YVA_Click;
            // 
            // openFileDialog_YVA
            // 
            openFileDialog_YVA.FileName = "openFileDialog1";
            // 
            // contextMenuStripProject_YVA
            // 
            contextMenuStripProject_YVA.ImageScalingSize = new Size(24, 24);
            contextMenuStripProject_YVA.Name = "contextMenuStripProject_YVA";
            contextMenuStripProject_YVA.Size = new Size(61, 4);
            // 
            // tabControl_YVA
            // 
            tabControl_YVA.Controls.Add(tabPageFilter_YVA);
            tabControl_YVA.Controls.Add(tabPageSearch_YVA);
            tabControl_YVA.Location = new Point(935, 54);
            tabControl_YVA.Name = "tabControl_YVA";
            tabControl_YVA.SelectedIndex = 0;
            tabControl_YVA.Size = new Size(431, 150);
            tabControl_YVA.TabIndex = 3;
            // 
            // tabPageFilter_YVA
            // 
            tabPageFilter_YVA.Controls.Add(comboBoxFilter_YVA);
            tabPageFilter_YVA.Location = new Point(4, 34);
            tabPageFilter_YVA.Name = "tabPageFilter_YVA";
            tabPageFilter_YVA.Padding = new Padding(3);
            tabPageFilter_YVA.Size = new Size(423, 112);
            tabPageFilter_YVA.TabIndex = 1;
            tabPageFilter_YVA.Text = "Фильтр";
            tabPageFilter_YVA.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilter_YVA
            // 
            comboBoxFilter_YVA.FormattingEnabled = true;
            comboBoxFilter_YVA.Location = new Point(3, 23);
            comboBoxFilter_YVA.Name = "comboBoxFilter_YVA";
            comboBoxFilter_YVA.Size = new Size(411, 33);
            comboBoxFilter_YVA.TabIndex = 0;
            // 
            // tabPageSearch_YVA
            // 
            tabPageSearch_YVA.Controls.Add(buttonSearch_YVA);
            tabPageSearch_YVA.Controls.Add(textBoxSearch_YVA);
            tabPageSearch_YVA.Location = new Point(4, 34);
            tabPageSearch_YVA.Name = "tabPageSearch_YVA";
            tabPageSearch_YVA.Padding = new Padding(3);
            tabPageSearch_YVA.Size = new Size(423, 112);
            tabPageSearch_YVA.TabIndex = 0;
            tabPageSearch_YVA.Text = "Поиск";
            tabPageSearch_YVA.UseVisualStyleBackColor = true;
            // 
            // buttonSearch_YVA
            // 
            buttonSearch_YVA.BackgroundImage = (Image)resources.GetObject("buttonSearch_YVA.BackgroundImage");
            buttonSearch_YVA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearch_YVA.Location = new Point(329, 18);
            buttonSearch_YVA.Name = "buttonSearch_YVA";
            buttonSearch_YVA.Size = new Size(78, 78);
            buttonSearch_YVA.TabIndex = 1;
            buttonSearch_YVA.UseVisualStyleBackColor = true;
            buttonSearch_YVA.Click += buttonSearch_YVA_Click;
            // 
            // textBoxSearch_YVA
            // 
            textBoxSearch_YVA.Location = new Point(17, 42);
            textBoxSearch_YVA.Name = "textBoxSearch_YVA";
            textBoxSearch_YVA.Size = new Size(306, 31);
            textBoxSearch_YVA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 619);
            Controls.Add(tabControl_YVA);
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
            tabControl_YVA.ResumeLayout(false);
            tabPageFilter_YVA.ResumeLayout(false);
            tabPageSearch_YVA.ResumeLayout(false);
            tabPageSearch_YVA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_YVA;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem_YVA;
        private ToolStripMenuItem SaveFileButton_YVA;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolStripMenuItemExit_YVA;
        private GroupBox groupBoxValues_YVA;
        private DataGridView dataGridView_YVA;
        private ToolStripMenuItem строкиToolStripMenuItem;
        private ToolStripMenuItem EditEnableButton_YVA;
        private ToolStripMenuItem EditDisableButton_YVA;
        private Button buttonAbout_YVA;
        private ToolStripMenuItem EditRowsButton_YVA;
        private ToolStripMenuItem buttonAddRow_YVA;
        private ToolStripMenuItem buttonAddCustomRows_YVA;
        private OpenFileDialog openFileDialog_YVA;
        private DataGridViewTextBoxColumn VehicleType;
        private DataGridViewTextBoxColumn RouteNumber;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn StartStop;
        private DataGridViewTextBoxColumn EndStop;
        private DataGridViewTextBoxColumn TimeSpanRoute;
        private DataGridViewTextBoxColumn Notes;
        private SaveFileDialog saveFileDialogProject_YVA;
        private ContextMenuStrip contextMenuStripProject_YVA;
        private ToolTip toolTip_YVA;
        private TabControl tabControl_YVA;
        private TabPage tabPageSearch_YVA;
        private Button buttonSearch_YVA;
        private TextBox textBoxSearch_YVA;
        private TabPage tabPageFilter_YVA;
        private ComboBox comboBoxFilter_YVA;
    }
}
