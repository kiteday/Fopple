namespace fopple_window
{
    partial class Game_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_window));
            this.Hello_state = new System.Windows.Forms.Button();
            this.Hard_btn = new System.Windows.Forms.PictureBox();
            this.Normal_btn = new System.Windows.Forms.PictureBox();
            this.Easy_btn = new System.Windows.Forms.PictureBox();
            this.Back_btn = new System.Windows.Forms.PictureBox();
            this.All_end = new System.Windows.Forms.PictureBox();
            this.apple_background = new System.Windows.Forms.PictureBox();
            this.Connect_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hard_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Hello_state
            // 
            this.Hello_state.Location = new System.Drawing.Point(224, 173);
            this.Hello_state.Name = "Hello_state";
            this.Hello_state.Size = new System.Drawing.Size(147, 64);
            this.Hello_state.TabIndex = 11;
            this.Hello_state.Text = "Hello_state";
            this.Hello_state.UseVisualStyleBackColor = true;
            this.Hello_state.Click += new System.EventHandler(this.Hello_state_Click);
            // 
            // Hard_btn
            // 
            this.Hard_btn.BackColor = System.Drawing.Color.Transparent;
            this.Hard_btn.Image = ((System.Drawing.Image)(resources.GetObject("Hard_btn.Image")));
            this.Hard_btn.Location = new System.Drawing.Point(1056, 328);
            this.Hard_btn.Name = "Hard_btn";
            this.Hard_btn.Size = new System.Drawing.Size(345, 216);
            this.Hard_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hard_btn.TabIndex = 14;
            this.Hard_btn.TabStop = false;
            this.Hard_btn.Click += new System.EventHandler(this.Hard_btn_Click);
            // 
            // Normal_btn
            // 
            this.Normal_btn.BackColor = System.Drawing.Color.Transparent;
            this.Normal_btn.Image = ((System.Drawing.Image)(resources.GetObject("Normal_btn.Image")));
            this.Normal_btn.Location = new System.Drawing.Point(616, 328);
            this.Normal_btn.Name = "Normal_btn";
            this.Normal_btn.Size = new System.Drawing.Size(345, 216);
            this.Normal_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Normal_btn.TabIndex = 13;
            this.Normal_btn.TabStop = false;
            this.Normal_btn.Click += new System.EventHandler(this.Normal_btn_Click);
            // 
            // Easy_btn
            // 
            this.Easy_btn.BackColor = System.Drawing.Color.Transparent;
            this.Easy_btn.Image = ((System.Drawing.Image)(resources.GetObject("Easy_btn.Image")));
            this.Easy_btn.Location = new System.Drawing.Point(166, 328);
            this.Easy_btn.Name = "Easy_btn";
            this.Easy_btn.Size = new System.Drawing.Size(345, 216);
            this.Easy_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Easy_btn.TabIndex = 12;
            this.Easy_btn.TabStop = false;
            this.Easy_btn.Click += new System.EventHandler(this.Easy_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_btn.Image")));
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(72, 73);
            this.Back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_btn.TabIndex = 10;
            this.Back_btn.TabStop = false;
            this.Back_btn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1496, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 15;
            this.All_end.TabStop = false;
            this.All_end.UseWaitCursor = true;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // apple_background
            // 
            this.apple_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apple_background.Image = global::fopple_window.Properties.Resources.apple_back;
            this.apple_background.Location = new System.Drawing.Point(0, 0);
            this.apple_background.Name = "apple_background";
            this.apple_background.Size = new System.Drawing.Size(1582, 853);
            this.apple_background.TabIndex = 16;
            this.apple_background.TabStop = false;
            // 
            // Connect_btn
            // 
            this.Connect_btn.BackColor = System.Drawing.Color.Transparent;
            this.Connect_btn.Image = ((System.Drawing.Image)(resources.GetObject("Connect_btn.Image")));
            this.Connect_btn.Location = new System.Drawing.Point(192, 202);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(158, 77);
            this.Connect_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Connect_btn.TabIndex = 17;
            this.Connect_btn.TabStop = false;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Game_window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::fopple_window.Properties.Resources.main_form;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.Hard_btn);
            this.Controls.Add(this.Normal_btn);
            this.Controls.Add(this.Easy_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.apple_background);
            this.Controls.Add(this.Hello_state);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.Game_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hard_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Normal_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Connect_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Back_btn;
        private System.Windows.Forms.Button Hello_state;
        private System.Windows.Forms.PictureBox Easy_btn;
        private System.Windows.Forms.PictureBox Normal_btn;
        private System.Windows.Forms.PictureBox Hard_btn;
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.PictureBox apple_background;
        private System.Windows.Forms.PictureBox Connect_btn;
    }
}