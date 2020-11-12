namespace fopple_window
{
    partial class Game_over
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_over));
            this.replay_btn = new System.Windows.Forms.PictureBox();
            this.stop_btn = new System.Windows.Forms.PictureBox();
            this.All_end = new System.Windows.Forms.PictureBox();
            this.girl_lose = new System.Windows.Forms.PictureBox();
            this.cat_win = new System.Windows.Forms.PictureBox();
            this.player_Bar = new System.Windows.Forms.PictureBox();
            this.NPC_Bar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.replay_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl_lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // replay_btn
            // 
            this.replay_btn.BackColor = System.Drawing.Color.Transparent;
            this.replay_btn.Image = ((System.Drawing.Image)(resources.GetObject("replay_btn.Image")));
            this.replay_btn.Location = new System.Drawing.Point(690, 470);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(218, 80);
            this.replay_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.replay_btn.TabIndex = 1;
            this.replay_btn.TabStop = false;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.Image = ((System.Drawing.Image)(resources.GetObject("stop_btn.Image")));
            this.stop_btn.Location = new System.Drawing.Point(690, 575);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(218, 80);
            this.stop_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stop_btn.TabIndex = 0;
            this.stop_btn.TabStop = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1492, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 17;
            this.All_end.TabStop = false;
            this.All_end.UseWaitCursor = true;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // girl_lose
            // 
            this.girl_lose.BackColor = System.Drawing.Color.Transparent;
            this.girl_lose.Image = ((System.Drawing.Image)(resources.GetObject("girl_lose.Image")));
            this.girl_lose.Location = new System.Drawing.Point(110, 394);
            this.girl_lose.Name = "girl_lose";
            this.girl_lose.Size = new System.Drawing.Size(292, 359);
            this.girl_lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girl_lose.TabIndex = 18;
            this.girl_lose.TabStop = false;
            // 
            // cat_win
            // 
            this.cat_win.BackColor = System.Drawing.Color.Transparent;
            this.cat_win.Image = ((System.Drawing.Image)(resources.GetObject("cat_win.Image")));
            this.cat_win.Location = new System.Drawing.Point(1257, 394);
            this.cat_win.Name = "cat_win";
            this.cat_win.Size = new System.Drawing.Size(218, 350);
            this.cat_win.TabIndex = 19;
            this.cat_win.TabStop = false;
            // 
            // player_Bar
            // 
            this.player_Bar.Location = new System.Drawing.Point(461, 340);
            this.player_Bar.Name = "player_Bar";
            this.player_Bar.Size = new System.Drawing.Size(65, 390);
            this.player_Bar.TabIndex = 20;
            this.player_Bar.TabStop = false;
            this.player_Bar.Click += new System.EventHandler(this.player_Bar_Click);
            // 
            // NPC_Bar
            // 
            this.NPC_Bar.BackColor = System.Drawing.Color.Red;
            this.NPC_Bar.Location = new System.Drawing.Point(1059, 340);
            this.NPC_Bar.Name = "NPC_Bar";
            this.NPC_Bar.Size = new System.Drawing.Size(65, 390);
            this.NPC_Bar.TabIndex = 21;
            this.NPC_Bar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(461, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 390);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Game_over
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.player_Bar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NPC_Bar);
            this.Controls.Add(this.cat_win);
            this.Controls.Add(this.girl_lose);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.stop_btn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_over";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.Game_over_Load);
            ((System.ComponentModel.ISupportInitialize)(this.replay_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl_lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox stop_btn;
        private System.Windows.Forms.PictureBox replay_btn;
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.PictureBox girl_lose;
        private System.Windows.Forms.PictureBox cat_win;
        private System.Windows.Forms.PictureBox player_Bar;
        private System.Windows.Forms.PictureBox NPC_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}