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
    public partial class Mainform : Form
    {
        private int num = 0;
        public static int[] personal_array;
        public Mainform()
        {
            InitializeComponent();

            //그림 겹치기
            apple_background.Controls.Add(All_end); //배경과 사진 합치기
            All_end.Location = new Point(1496, 12); //사진 위치 지정하기
            apple_background.Controls.Add(Back_btn);
            Back_btn.Location = new Point(12, 12);
            apple_background.Controls.Add(floor);
            floor.Location = new Point(586, 36);
            floor.Controls.Add(girl);
            girl.Location = new Point(38, 70);

            //전체화면
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        internal void Show(string v)
        {
            throw new NotImplementedException();
        }

        private void Game_box_Click(object sender, EventArgs e)
        {
            //게임 플레이 창으로 가는 코드
            this.Hide();
            Game_window Gwindow = new Game_window();
            Gwindow.Show();

        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //뒤로가기 (Form1(로그인) 화면으로 이동)
            //if (MessageBox.Show("로그아웃 하시겠습니까?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    Form1 F1 = new Form1();
            //    F1.Show();
            //}
            
            logout Logout = new logout(this);
            Logout.Show();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            //게임 플레이 창으로 가는 코드
            this.Hide();
            Game_window Gwindow = new Game_window();
            Gwindow.Show();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            //for (num = 0; num < Game_window.Click_num; num++)
            //{
            //    if (personal_array[num] != 0)
            //        personal_array[num] = Level_1.Lose_player_width;

            //}
            //게임 플레이 창으로 가는 코드
            this.Hide();
            Record_form Record = new Record_form();
            Record.Show();
        }
    }
}
