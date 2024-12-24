namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    partial class FormMultipleRowsAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textRowCount_YVA = new TextBox();
            buttonOK_YVA = new Button();
            buttonCancel_YVA = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textRowCount_YVA
            // 
            textRowCount_YVA.Location = new Point(30, 32);
            textRowCount_YVA.Name = "textRowCount_YVA";
            textRowCount_YVA.Size = new Size(150, 31);
            textRowCount_YVA.TabIndex = 0;
            // 
            // buttonOK_YVA
            // 
            buttonOK_YVA.Location = new Point(231, 65);
            buttonOK_YVA.Name = "buttonOK_YVA";
            buttonOK_YVA.Size = new Size(98, 34);
            buttonOK_YVA.TabIndex = 1;
            buttonOK_YVA.Text = "Ок";
            buttonOK_YVA.UseVisualStyleBackColor = true;
            buttonOK_YVA.Click += btnOk_Click;
            // 
            // buttonCancel_YVA
            // 
            buttonCancel_YVA.Location = new Point(335, 65);
            buttonCancel_YVA.Name = "buttonCancel_YVA";
            buttonCancel_YVA.Size = new Size(98, 34);
            buttonCancel_YVA.TabIndex = 2;
            buttonCancel_YVA.Text = "Закрыть";
            buttonCancel_YVA.UseVisualStyleBackColor = true;
            buttonCancel_YVA.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 3;
            label1.Text = "Сколько добавить строк?";
            // 
            // FormMultipleRowsAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 98);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(buttonCancel_YVA);
            Controls.Add(buttonOK_YVA);
            Controls.Add(textRowCount_YVA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMultipleRowsAdd";
            ShowIcon = false;
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRowCount_YVA;
        private Button buttonOK_YVA;
        private Button buttonCancel_YVA;
        private Label label1;
    }
}