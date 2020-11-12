namespace fopple_window
{
    partial class logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logout));
            this.yes_btn = new System.Windows.Forms.PictureBox();
            this.no_btn = new System.Windows.Forms.PictureBox();
            this.Ask_stop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // yes_btn
            // 
            this.yes_btn.Image = ((System.Drawing.Image)(resources.GetObject("yes_btn.Image")));
            this.yes_btn.Location = new System.Drawing.Point(59, 166);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(96, 38);
            this.yes_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yes_btn.TabIndex = 4;
            this.yes_btn.TabStop = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Image = ((System.Drawing.Image)(resources.GetObject("no_btn.Image")));
            this.no_btn.Location = new System.Drawing.Point(190, 166);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(96, 38);
            this.no_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.no_btn.TabIndex = 6;
            this.no_btn.TabStop = false;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // Ask_stop
            // 
            this.Ask_stop.AutoSize = true;
            this.Ask_stop.BackColor = System.Drawing.Color.Transparent;
            this.Ask_stop.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.Ask_stop.Location = new System.Drawing.Point(64, 80);
            this.Ask_stop.Name = "Ask_stop";
            this.Ask_stop.Size = new System.Drawing.Size(217, 23);
            this.Ask_stop.TabIndex = 7;
            this.Ask_stop.Text = "로그아웃 하시겠습니까?";
            // 
            // logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.ControlBox = false;
            this.Controls.Add(this.Ask_stop);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.logout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yes_btn;
        private System.Windows.Forms.PictureBox no_btn;
        private System.Windows.Forms.Label Ask_stop;
    }
}