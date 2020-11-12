namespace fopple_window
{
    partial class Game_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_win));
            this.All_end = new System.Windows.Forms.PictureBox();
            this.player_Bar = new System.Windows.Forms.PictureBox();
            this.Npc_bak = new System.Windows.Forms.PictureBox();
            this.NPC_Bar = new System.Windows.Forms.PictureBox();
            this.apple_background = new System.Windows.Forms.PictureBox();
            this.win_text = new System.Windows.Forms.PictureBox();
            this.girl_win = new System.Windows.Forms.PictureBox();
            this.cat_lose = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.stop_btn = new System.Windows.Forms.PictureBox();
            this.replay_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Npc_bak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl_win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replay_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1496, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 16;
            this.All_end.TabStop = false;
            this.All_end.UseWaitCursor = true;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // player_Bar
            // 
            this.player_Bar.BackColor = System.Drawing.Color.Red;
            this.player_Bar.Location = new System.Drawing.Point(461, 340);
            this.player_Bar.Name = "player_Bar";
            this.player_Bar.Size = new System.Drawing.Size(65, 390);
            this.player_Bar.TabIndex = 17;
            this.player_Bar.TabStop = false;
            // 
            // Npc_bak
            // 
            this.Npc_bak.BackColor = System.Drawing.Color.Red;
            this.Npc_bak.Location = new System.Drawing.Point(1058, 340);
            this.Npc_bak.Name = "Npc_bak";
            this.Npc_bak.Size = new System.Drawing.Size(65, 390);
            this.Npc_bak.TabIndex = 18;
            this.Npc_bak.TabStop = false;
            // 
            // NPC_Bar
            // 
            this.NPC_Bar.BackColor = System.Drawing.Color.White;
            this.NPC_Bar.Location = new System.Drawing.Point(1058, 340);
            this.NPC_Bar.Name = "NPC_Bar";
            this.NPC_Bar.Size = new System.Drawing.Size(65, 390);
            this.NPC_Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NPC_Bar.TabIndex = 19;
            this.NPC_Bar.TabStop = false;
            // 
            // apple_background
            // 
            this.apple_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apple_background.Image = global::fopple_window.Properties.Resources.apple_back;
            this.apple_background.Location = new System.Drawing.Point(0, 0);
            this.apple_background.Name = "apple_background";
            this.apple_background.Size = new System.Drawing.Size(1582, 853);
            this.apple_background.TabIndex = 20;
            this.apple_background.TabStop = false;
            // 
            // win_text
            // 
            this.win_text.BackColor = System.Drawing.Color.Transparent;
            this.win_text.Image = ((System.Drawing.Image)(resources.GetObject("win_text.Image")));
            this.win_text.Location = new System.Drawing.Point(0, 0);
            this.win_text.Name = "win_text";
            this.win_text.Size = new System.Drawing.Size(1582, 853);
            this.win_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.win_text.TabIndex = 21;
            this.win_text.TabStop = false;
            this.win_text.Click += new System.EventHandler(this.win_text_Click);
            // 
            // girl_win
            // 
            this.girl_win.BackColor = System.Drawing.Color.Transparent;
            this.girl_win.Image = ((System.Drawing.Image)(resources.GetObject("girl_win.Image")));
            this.girl_win.Location = new System.Drawing.Point(93, 291);
            this.girl_win.Name = "girl_win";
            this.girl_win.Size = new System.Drawing.Size(292, 436);
            this.girl_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girl_win.TabIndex = 22;
            this.girl_win.TabStop = false;
            // 
            // cat_lose
            // 
            this.cat_lose.BackColor = System.Drawing.Color.Transparent;
            this.cat_lose.Image = ((System.Drawing.Image)(resources.GetObject("cat_lose.Image")));
            this.cat_lose.Location = new System.Drawing.Point(1246, 472);
            this.cat_lose.Name = "cat_lose";
            this.cat_lose.Size = new System.Drawing.Size(218, 296);
            this.cat_lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat_lose.TabIndex = 23;
            this.cat_lose.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.Image = ((System.Drawing.Image)(resources.GetObject("stop_btn.Image")));
            this.stop_btn.Location = new System.Drawing.Point(690, 575);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(218, 80);
            this.stop_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stop_btn.TabIndex = 25;
            this.stop_btn.TabStop = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // replay_btn
            // 
            this.replay_btn.BackColor = System.Drawing.Color.Transparent;
            this.replay_btn.Image = ((System.Drawing.Image)(resources.GetObject("replay_btn.Image")));
            this.replay_btn.Location = new System.Drawing.Point(690, 470);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(218, 80);
            this.replay_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.replay_btn.TabIndex = 26;
            this.replay_btn.TabStop = false;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // Game_win
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::fopple_window.Properties.Resources.win;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.cat_lose);
            this.Controls.Add(this.girl_win);
            this.Controls.Add(this.NPC_Bar);
            this.Controls.Add(this.Npc_bak);
            this.Controls.Add(this.player_Bar);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.win_text);
            this.Controls.Add(this.apple_background);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Game_win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.Game_win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Npc_bak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl_win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replay_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.PictureBox player_Bar;
        private System.Windows.Forms.PictureBox Npc_bak;
        private System.Windows.Forms.PictureBox NPC_Bar;
        private System.Windows.Forms.PictureBox apple_background;
        private System.Windows.Forms.PictureBox win_text;
        private System.Windows.Forms.PictureBox girl_win;
        private System.Windows.Forms.PictureBox cat_lose;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox stop_btn;
        private System.Windows.Forms.PictureBox replay_btn;
    }
}