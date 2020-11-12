namespace fopple_window
{
    partial class Record_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record_form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.apple_background = new System.Windows.Forms.PictureBox();
            this.Back_btn = new System.Windows.Forms.PictureBox();
            this.All_end = new System.Windows.Forms.PictureBox();
            this.user_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // apple_background
            // 
            this.apple_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apple_background.Image = global::fopple_window.Properties.Resources.apple_back;
            this.apple_background.Location = new System.Drawing.Point(0, 0);
            this.apple_background.Name = "apple_background";
            this.apple_background.Size = new System.Drawing.Size(1582, 853);
            this.apple_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple_background.TabIndex = 0;
            this.apple_background.TabStop = false;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_btn.Image")));
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 75);
            this.Back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_btn.TabIndex = 1;
            this.Back_btn.TabStop = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1496, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 2;
            this.All_end.TabStop = false;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // user_chart
            // 
            this.user_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.user_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.user_chart.Legends.Add(legend2);
            this.user_chart.Location = new System.Drawing.Point(336, 175);
            this.user_chart.Name = "user_chart";
            this.user_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.user_chart.Series.Add(series2);
            this.user_chart.Size = new System.Drawing.Size(955, 589);
            this.user_chart.TabIndex = 3;
            this.user_chart.Text = "user_chart";
            this.user_chart.Click += new System.EventHandler(this.user_chart_Click);
            // 
            // Record_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.user_chart);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.apple_background);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.Record_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox apple_background;
        private System.Windows.Forms.PictureBox Back_btn;
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.DataVisualization.Charting.Chart user_chart;
    }
}