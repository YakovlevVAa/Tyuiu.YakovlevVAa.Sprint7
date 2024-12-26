namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            labelLeastCommonStartStop_YVA = new Label();
            labelMostCommonStartStop_YVA = new Label();
            labelLeastCommonEndStop_YVA = new Label();
            labelMostCommonEndStop_YVA = new Label();
            labelLeastCommonRoute_YVA = new Label();
            labelMostCommonRoute_YVA = new Label();
            labelMiniBusCount_YVA = new Label();
            labelBusCount_YVA = new Label();
            labelTotalRoutes_YVA = new Label();
            chartTime_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTime_YVA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLeastCommonStartStop_YVA);
            groupBox1.Controls.Add(labelMostCommonStartStop_YVA);
            groupBox1.Controls.Add(labelLeastCommonEndStop_YVA);
            groupBox1.Controls.Add(labelMostCommonEndStop_YVA);
            groupBox1.Controls.Add(labelLeastCommonRoute_YVA);
            groupBox1.Controls.Add(labelMostCommonRoute_YVA);
            groupBox1.Controls.Add(labelMiniBusCount_YVA);
            groupBox1.Controls.Add(labelBusCount_YVA);
            groupBox1.Controls.Add(labelTotalRoutes_YVA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 535);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статистика по маршрутам";
            // 
            // labelLeastCommonStartStop_YVA
            // 
            labelLeastCommonStartStop_YVA.AutoSize = true;
            labelLeastCommonStartStop_YVA.Location = new Point(17, 371);
            labelLeastCommonStartStop_YVA.Name = "labelLeastCommonStartStop_YVA";
            labelLeastCommonStartStop_YVA.Size = new Size(59, 25);
            labelLeastCommonStartStop_YVA.TabIndex = 8;
            labelLeastCommonStartStop_YVA.Text = "label2";
            // 
            // labelMostCommonStartStop_YVA
            // 
            labelMostCommonStartStop_YVA.AutoSize = true;
            labelMostCommonStartStop_YVA.Location = new Point(17, 324);
            labelMostCommonStartStop_YVA.Name = "labelMostCommonStartStop_YVA";
            labelMostCommonStartStop_YVA.Size = new Size(59, 25);
            labelMostCommonStartStop_YVA.TabIndex = 7;
            labelMostCommonStartStop_YVA.Text = "label1";
            // 
            // labelLeastCommonEndStop_YVA
            // 
            labelLeastCommonEndStop_YVA.AutoSize = true;
            labelLeastCommonEndStop_YVA.Location = new Point(17, 284);
            labelLeastCommonEndStop_YVA.Name = "labelLeastCommonEndStop_YVA";
            labelLeastCommonEndStop_YVA.Size = new Size(59, 25);
            labelLeastCommonEndStop_YVA.TabIndex = 6;
            labelLeastCommonEndStop_YVA.Text = "label1";
            // 
            // labelMostCommonEndStop_YVA
            // 
            labelMostCommonEndStop_YVA.AutoSize = true;
            labelMostCommonEndStop_YVA.Location = new Point(17, 246);
            labelMostCommonEndStop_YVA.Name = "labelMostCommonEndStop_YVA";
            labelMostCommonEndStop_YVA.Size = new Size(59, 25);
            labelMostCommonEndStop_YVA.TabIndex = 5;
            labelMostCommonEndStop_YVA.Text = "label1";
            // 
            // labelLeastCommonRoute_YVA
            // 
            labelLeastCommonRoute_YVA.AutoSize = true;
            labelLeastCommonRoute_YVA.Location = new Point(17, 205);
            labelLeastCommonRoute_YVA.Name = "labelLeastCommonRoute_YVA";
            labelLeastCommonRoute_YVA.Size = new Size(59, 25);
            labelLeastCommonRoute_YVA.TabIndex = 4;
            labelLeastCommonRoute_YVA.Text = "label1";
            // 
            // labelMostCommonRoute_YVA
            // 
            labelMostCommonRoute_YVA.AutoSize = true;
            labelMostCommonRoute_YVA.Location = new Point(17, 163);
            labelMostCommonRoute_YVA.Name = "labelMostCommonRoute_YVA";
            labelMostCommonRoute_YVA.Size = new Size(59, 25);
            labelMostCommonRoute_YVA.TabIndex = 3;
            labelMostCommonRoute_YVA.Text = "label1";
            // 
            // labelMiniBusCount_YVA
            // 
            labelMiniBusCount_YVA.AutoSize = true;
            labelMiniBusCount_YVA.Location = new Point(17, 119);
            labelMiniBusCount_YVA.Name = "labelMiniBusCount_YVA";
            labelMiniBusCount_YVA.Size = new Size(59, 25);
            labelMiniBusCount_YVA.TabIndex = 2;
            labelMiniBusCount_YVA.Text = "label1";
            // 
            // labelBusCount_YVA
            // 
            labelBusCount_YVA.AutoSize = true;
            labelBusCount_YVA.Location = new Point(17, 78);
            labelBusCount_YVA.Name = "labelBusCount_YVA";
            labelBusCount_YVA.Size = new Size(59, 25);
            labelBusCount_YVA.TabIndex = 1;
            labelBusCount_YVA.Text = "label1";
            // 
            // labelTotalRoutes_YVA
            // 
            labelTotalRoutes_YVA.AutoSize = true;
            labelTotalRoutes_YVA.Location = new Point(17, 40);
            labelTotalRoutes_YVA.Name = "labelTotalRoutes_YVA";
            labelTotalRoutes_YVA.Size = new Size(59, 25);
            labelTotalRoutes_YVA.TabIndex = 0;
            labelTotalRoutes_YVA.Text = "label1";
            // 
            // chartTime_YVA
            // 
            chartArea1.Name = "ChartArea1";
            chartTime_YVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTime_YVA.Legends.Add(legend1);
            chartTime_YVA.Location = new Point(666, 12);
            chartTime_YVA.Name = "chartTime_YVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTime_YVA.Series.Add(series1);
            chartTime_YVA.Size = new Size(607, 535);
            chartTime_YVA.TabIndex = 1;
            chartTime_YVA.Text = "chart1";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 559);
            Controls.Add(chartTime_YVA);
            Controls.Add(groupBox1);
            Name = "FormStatistics";
            Text = "Статистика";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTime_YVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelLeastCommonEndStop_YVA;
        private Label labelMostCommonEndStop_YVA;
        private Label labelLeastCommonRoute_YVA;
        private Label labelMostCommonRoute_YVA;
        private Label labelMiniBusCount_YVA;
        private Label labelBusCount_YVA;
        private Label labelTotalRoutes_YVA;
        private Label labelLeastCommonStartStop_YVA;
        private Label labelMostCommonStartStop_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime_YVA;
    }
}