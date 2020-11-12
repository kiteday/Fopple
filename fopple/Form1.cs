using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fopple_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
             //로그인 하는 누르는 창
             if (ID_box.Text == "fopple" && Password_box.Text == "fopple")   //로그인 성공 아이디/비밀번호 모두 fopple로 초기 설정 
             {
               this.Hide();
                    Mainform mainform1 = new Mainform();
                    mainform1.Show();
                }
             else if (ID_box.Text != "fopple" || Password_box.Text != "fopple")   //로그인 실패
             {
               MessageBox.Show("아이디나 비밀번호가 틀렸습니다. 다시 입력해주세요");
     
             }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //로그인 하는 누르는 창
            if (ID_box.Text == "fopple" && Password_box.Text == "fopple")   //로그인 성공 아이디/비밀번호 모두 fopple로 초기 설정 
            {
                this.Hide();
                Mainform mainform1 = new Mainform();
                mainform1.Show();
            }
            else if (ID_box.Text != "fopple" || Password_box.Text != "fopple")   //로그인 실패
            {
                MessageBox.Show("아이디나 비밀번호가 틀렸습니다. 다시 입력해주세요");

            }
        }

        private void Password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.login_btn_Click(sender, e); //엔터 누르면 로그인
            }
        }
    }
}
