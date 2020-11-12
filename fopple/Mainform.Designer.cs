namespace fopple_window
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.Game_box = new System.Windows.Forms.Button();
            this.All_end = new System.Windows.Forms.PictureBox();
            this.Back_btn = new System.Windows.Forms.PictureBox();
            this.Record = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.girl = new System.Windows.Forms.PictureBox();
            this.play_button = new System.Windows.Forms.PictureBox();
            this.apple_background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_box
            // 
            this.Game_box.Location = new System.Drawing.Point(917, 745);
            this.Game_box.Name = "Game_box";
            this.Game_box.Size = new System.Drawing.Size(141, 42);
            this.Game_box.TabIndex = 0;
            this.Game_box.Text = "게임 플레이";
            this.Game_box.UseVisualStyleBackColor = true;
            this.Game_box.Click += new System.EventHandler(this.Game_box_Click);
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1496, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 8;
            this.All_end.TabStop = false;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_btn.Image")));
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(72, 73);
            this.Back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_btn.TabIndex = 11;
            this.Back_btn.TabStop = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Record
            // 
            this.Record.Image = ((System.Drawing.Image)(resources.GetObject("Record.Image")));
            this.Record.Location = new System.Drawing.Point(478, 727);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(226, 73);
            this.Record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Record.TabIndex = 12;
            this.Record.TabStop = false;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Image = global::fopple_window.Properties.Resources.floor_big;
            this.floor.Location = new System.Drawing.Point(586, 36);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(440, 658);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 13;
            this.floor.TabStop = false;
            // 
            // girl
            // 
            this.girl.BackColor = System.Drawing.Color.Transparent;
            this.girl.Image = global::fopple_window.Properties.Resources.girl;
            this.girl.Location = new System.Drawing.Point(624, 99);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(361, 460);
            this.girl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girl.TabIndex = 14;
            this.girl.TabStop = false;
            // 
            // play_button
            // 
            this.play_button.Image = ((System.Drawing.Image)(resources.GetObject("play_button.Image")));
            this.play_button.Location = new System.Drawing.Point(881, 727);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(226, 73);
            this.play_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_button.TabIndex = 16;
            this.play_button.TabStop = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // apple_background
            // 
            this.apple_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apple_background.Image = global::fopple_window.Properties.Resources.apple_back;
            this.apple_background.Location = new System.Drawing.Point(0, 0);
            this.apple_background.Name = "apple_background";
            this.apple_background.Size = new System.Drawing.Size(1582, 853);
            this.apple_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple_background.TabIndex = 17;
            this.apple_background.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::fopple_window.Properties.Resources.main_form;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.girl);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.Game_box);
            this.Controls.Add(this.apple_background);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Game_box;
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.PictureBox Back_btn;
        private System.Windows.Forms.PictureBox Record;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox girl;
        private System.Windows.Forms.PictureBox play_button;
        private System.Windows.Forms.PictureBox apple_background;
    }
}