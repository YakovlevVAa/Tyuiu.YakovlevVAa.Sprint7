namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    partial class FormUserManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManual));
            label1 = new Label();
            buttonClose_YVA = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(761, 525);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonClose_YVA
            // 
            buttonClose_YVA.Location = new Point(619, 592);
            buttonClose_YVA.Name = "buttonClose_YVA";
            buttonClose_YVA.Size = new Size(112, 34);
            buttonClose_YVA.TabIndex = 1;
            buttonClose_YVA.Text = "Закрыть";
            buttonClose_YVA.UseVisualStyleBackColor = true;
            buttonClose_YVA.Click += buttonCLose_YVA_Click;
            // 
            // FormUserManual
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 647);
            Controls.Add(buttonClose_YVA);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormUserManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonClose_YVA;
    }
}