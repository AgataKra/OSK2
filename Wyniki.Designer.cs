
namespace OSK2
{
    partial class Wyniki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Tester parent;
        private int[,] results = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        private int[] results1 = { 0, 0, 0, 0, 0 };
        private int[] results2 = { 0, 0, 0, 0, 0 };
        private int[] results3 = { 0, 0, 0, 0, 0 };
        private int[] mean = { 0, 0, 0 };
        private int[] indexes = { 1, 2, 3, 4, 5 };
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_mean1 = new System.Windows.Forms.Label();
            this.label_mean2 = new System.Windows.Forms.Label();
            this.label_mean3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(50, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Test 1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Test 2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Test 3";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(700, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(807, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Czas średni testu pierwszego:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(807, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Czas średni testu drugiego:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(807, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Czas średni testu trzeciego:";
            // 
            // label_mean1
            // 
            this.label_mean1.AutoSize = true;
            this.label_mean1.Location = new System.Drawing.Point(811, 74);
            this.label_mean1.Name = "label_mean1";
            this.label_mean1.Size = new System.Drawing.Size(46, 17);
            this.label_mean1.TabIndex = 4;
            this.label_mean1.Text = "label4";
            // 
            // label_mean2
            // 
            this.label_mean2.AutoSize = true;
            this.label_mean2.Location = new System.Drawing.Point(811, 224);
            this.label_mean2.Name = "label_mean2";
            this.label_mean2.Size = new System.Drawing.Size(46, 17);
            this.label_mean2.TabIndex = 5;
            this.label_mean2.Text = "label5";
            // 
            // label_mean3
            // 
            this.label_mean3.AutoSize = true;
            this.label_mean3.Location = new System.Drawing.Point(814, 374);
            this.label_mean3.Name = "label_mean3";
            this.label_mean3.Size = new System.Drawing.Size(46, 17);
            this.label_mean3.TabIndex = 6;
            this.label_mean3.Text = "label6";
            // 
            // Wyniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label_mean3);
            this.Controls.Add(this.label_mean2);
            this.Controls.Add(this.label_mean1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Wyniki";
            this.Text = "Wyniki";
            this.Load += new System.EventHandler(this.Wyniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_mean1;
        private System.Windows.Forms.Label label_mean2;
        private System.Windows.Forms.Label label_mean3;
    }
}