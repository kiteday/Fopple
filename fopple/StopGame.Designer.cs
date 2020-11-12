namespace fopple_window
{
    partial class StopGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopGame));
            this.Ask_stop = new System.Windows.Forms.Label();
            this.Stop_game_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.yes_btn = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).BeginInit();
            this.SuspendLayout();
            // 
            // Ask_stop
            // 
            this.Ask_stop.AutoSize = true;
            this.Ask_stop.BackColor = System.Drawing.Color.Transparent;
            this.Ask_stop.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.Ask_stop.Location = new System.Drawing.Point(55, 80);
            this.Ask_stop.Name = "Ask_stop";
            this.Ask_stop.Size = new System.Drawing.Size(236, 23);
            this.Ask_stop.TabIndex = 0;
            this.Ask_stop.Text = "게임을 그만하시겠습니까?";
            // 
            // Stop_game_btn
            // 
            this.Stop_game_btn.Location = new System.Drawing.Point(59, 166);
            this.Stop_game_btn.Name = "Stop_game_btn";
            this.Stop_game_btn.Size = new System.Drawing.Size(92, 28);
            this.Stop_game_btn.TabIndex = 1;
            this.Stop_game_btn.Text = "Yes";
            this.Stop_game_btn.UseVisualStyleBackColor = true;
            this.Stop_game_btn.Click += new System.EventHandler(this.Stop_game_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(201, 174);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 23);
            this.no_btn.TabIndex = 2;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // yes_btn
            // 
            this.yes_btn.Image = ((System.Drawing.Image)(resources.GetObject("yes_btn.Image")));
            this.yes_btn.Location = new System.Drawing.Point(59, 166);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(96, 38);
            this.yes_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yes_btn.TabIndex = 3;
            this.yes_btn.TabStop = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no
            // 
            this.no.Image = ((System.Drawing.Image)(resources.GetObject("no.Image")));
            this.no.Location = new System.Drawing.Point(190, 166);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(96, 38);
            this.no.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.no.TabIndex = 5;
            this.no.TabStop = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // StopGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.Stop_game_btn);
            this.Controls.Add(this.Ask_stop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StopGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.StopGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_stop;
        private System.Windows.Forms.Button Stop_game_btn;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.PictureBox yes_btn;
        private System.Windows.Forms.PictureBox no;
    }
}