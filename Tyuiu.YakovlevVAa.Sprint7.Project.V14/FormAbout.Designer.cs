namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_YVA = new PictureBox();
            labelAbout_YVA = new Label();
            buttonClose_YVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_YVA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_YVA
            // 
            pictureBoxAbout_YVA.BackgroundImage = (Image)resources.GetObject("pictureBoxAbout_YVA.BackgroundImage");
            pictureBoxAbout_YVA.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAbout_YVA.Location = new Point(12, 39);
            pictureBoxAbout_YVA.Name = "pictureBoxAbout_YVA";
            pictureBoxAbout_YVA.Size = new Size(261, 357);
            pictureBoxAbout_YVA.TabIndex = 0;
            pictureBoxAbout_YVA.TabStop = false;
            // 
            // labelAbout_YVA
            // 
            labelAbout_YVA.AutoSize = true;
            labelAbout_YVA.Location = new Point(293, 39);
            labelAbout_YVA.Name = "labelAbout_YVA";
            labelAbout_YVA.Size = new Size(445, 275);
            labelAbout_YVA.TabIndex = 1;
            labelAbout_YVA.Text = resources.GetString("labelAbout_YVA.Text");
            // 
            // buttonClose_YVA
            // 
            buttonClose_YVA.Location = new Point(640, 404);
            buttonClose_YVA.Name = "buttonClose_YVA";
            buttonClose_YVA.Size = new Size(112, 34);
            buttonClose_YVA.TabIndex = 2;
            buttonClose_YVA.Text = "Закрыть";
            buttonClose_YVA.UseVisualStyleBackColor = true;
            buttonClose_YVA.Click += buttonClose_YVA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose_YVA);
            Controls.Add(labelAbout_YVA);
            Controls.Add(pictureBoxAbout_YVA);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_YVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_YVA;
        private Label labelAbout_YVA;
        private Button buttonClose_YVA;
    }
}