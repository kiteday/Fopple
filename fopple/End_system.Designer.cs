namespace fopple_window
{
    partial class End_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End_system));
            this.End_yesbox = new System.Windows.Forms.Button();
            this.Exit_message = new System.Windows.Forms.Label();
            this.yes_btn = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // End_yesbox
            // 
            this.End_yesbox.Location = new System.Drawing.Point(59, 166);
            this.End_yesbox.Name = "End_yesbox";
            this.End_yesbox.Size = new System.Drawing.Size(91, 30);
            this.End_yesbox.TabIndex = 0;
            this.End_yesbox.Text = "Yes";
            this.End_yesbox.UseVisualStyleBackColor = true;
            this.End_yesbox.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_message
            // 
            this.Exit_message.AutoSize = true;
            this.Exit_message.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_message.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exit_message.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit_message.Location = new System.Drawing.Point(40, 68);
            this.Exit_message.Name = "Exit_message";
            this.Exit_message.Size = new System.Drawing.Size(179, 46);
            this.Exit_message.TabIndex = 1;
            this.Exit_message.Text = "정말로 프로그램을\r\n그만 두시겠습니까?";
            this.Exit_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_message.Click += new System.EventHandler(this.Exit_message_Click);
            // 
            // yes_btn
            // 
            this.yes_btn.Image = ((System.Drawing.Image)(resources.GetObject("yes_btn.Image")));
            this.yes_btn.Location = new System.Drawing.Point(59, 166);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(96, 38);
            this.yes_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yes_btn.TabIndex = 2;
            this.yes_btn.TabStop = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(215, 166);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(62, 27);
            this.no.TabIndex = 3;
            this.no.Text = "no";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // no_btn
            // 
            this.no_btn.Image = ((System.Drawing.Image)(resources.GetObject("no_btn.Image")));
            this.no_btn.Location = new System.Drawing.Point(190, 166);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(96, 38);
            this.no_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.no_btn.TabIndex = 4;
            this.no_btn.TabStop = false;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // End_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.Exit_message);
            this.Controls.Add(this.End_yesbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 450);
            this.Name = "End_system";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.Load += new System.EventHandler(this.End_system_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yes_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button End_yesbox;
        private System.Windows.Forms.Label Exit_message;
        private System.Windows.Forms.PictureBox yes_btn;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.PictureBox no_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}