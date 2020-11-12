namespace fopple_window
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.ID_labal = new System.Windows.Forms.Label();
            this.Password_labal = new System.Windows.Forms.Label();
            this.All_end = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_bkg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_bkg)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(654, 648);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(263, 25);
            this.ID_box.TabIndex = 1;
            this.ID_box.UseWaitCursor = true;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(654, 703);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(263, 25);
            this.Password_box.TabIndex = 4;
            this.Password_box.UseWaitCursor = true;
            this.Password_box.TextChanged += new System.EventHandler(this.Password_box_TextChanged);
            this.Password_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_box_KeyDown);
            // 
            // ID_labal
            // 
            this.ID_labal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ID_labal.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_labal.Location = new System.Drawing.Point(496, 649);
            this.ID_labal.Name = "ID_labal";
            this.ID_labal.Size = new System.Drawing.Size(104, 24);
            this.ID_labal.TabIndex = 5;
            this.ID_labal.Text = "아이디";
            this.ID_labal.UseWaitCursor = true;
            this.ID_labal.Click += new System.EventHandler(this.label2_Click);
            // 
            // Password_labal
            // 
            this.Password_labal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Password_labal.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password_labal.Location = new System.Drawing.Point(485, 702);
            this.Password_labal.Name = "Password_labal";
            this.Password_labal.Size = new System.Drawing.Size(115, 26);
            this.Password_labal.TabIndex = 5;
            this.Password_labal.Text = "비밀번호";
            this.Password_labal.UseWaitCursor = true;
            this.Password_labal.Click += new System.EventHandler(this.label2_Click);
            // 
            // All_end
            // 
            this.All_end.BackColor = System.Drawing.Color.Transparent;
            this.All_end.Image = ((System.Drawing.Image)(resources.GetObject("All_end.Image")));
            this.All_end.Location = new System.Drawing.Point(1492, 12);
            this.All_end.Name = "All_end";
            this.All_end.Size = new System.Drawing.Size(74, 73);
            this.All_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.All_end.TabIndex = 7;
            this.All_end.TabStop = false;
            this.All_end.UseWaitCursor = true;
            this.All_end.Click += new System.EventHandler(this.All_end_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.Image = ((System.Drawing.Image)(resources.GetObject("login_button.Image")));
            this.login_button.Location = new System.Drawing.Point(945, 649);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(169, 83);
            this.login_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_button.TabIndex = 8;
            this.login_button.TabStop = false;
            this.login_button.UseWaitCursor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(972, 665);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(109, 48);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.UseWaitCursor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(555, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(511, 188);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            this.logo.UseWaitCursor = true;
            // 
            // login_bkg
            // 
            this.login_bkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.login_bkg.Location = new System.Drawing.Point(452, 613);
            this.login_bkg.Name = "login_bkg";
            this.login_bkg.Size = new System.Drawing.Size(717, 160);
            this.login_bkg.TabIndex = 11;
            this.login_bkg.TabStop = false;
            this.login_bkg.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.ControlBox = false;
            this.Controls.Add(this.logo);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.All_end);
            this.Controls.Add(this.Password_labal);
            this.Controls.Add(this.ID_labal);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_bkg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fopple";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.All_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_bkg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label ID_labal;
        private System.Windows.Forms.Label Password_labal;
        private System.Windows.Forms.PictureBox All_end;
        private System.Windows.Forms.PictureBox login_button;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox login_bkg;
    }
}

