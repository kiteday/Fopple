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
    public partial class Game_over : Form
    {
        public static int player_Bar_h;
        public Game_over()
        {
            if (Level_1.Delta_avg / 100000.0 < 6.2)
            {
                //이곳에 흥분 감지시 취할 조치를 취하시오
                Excite_down Huha = new Excite_down();
                Huha.Show();
                //MessageBox.Show("저런! 너무 흥분하셨군요. 잠시 심호흡을 하며 감정을 추스려보세요.");
            }
            InitializeComponent();

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            player_Bar_h = 390 - 39 * Level_1.complete_data;
            player_Bar.Size = new System.Drawing.Size(65, player_Bar_h);
           

        }

        private void replay_btn_Click(object sender, EventArgs e)
        {
            Game_window Gwindow = new Game_window();
            this.Close();
            Gwindow.Show();
            //Level_1 play_window = new Level_1();
            //if (Game_window.easy_level_num == 30)   // easy모드로 리플레이 하기
            //{
            //    this.Close();
            //    play_window.Show();
            //}
            //else if (Game_window.normal_level_num == 50)      // normal모드로 리플레이 하기
            //{
            //    this.Close();
            //    play_window.Show();
            //}
            //else if (Game_window.hard_level_num == 70)        // hard모드로 리플레이 하기
            //{
            //    this.Close();
            //    play_window.Show();
            //}
        }

        private void stop_btn_Click(object sender, EventArgs e)     //게임 끝 -> 메인 창으로 이동
        {
            Mainform main = new Mainform();
            this.Close();
            main.Show();
        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void player_Bar_Click(object sender, EventArgs e)
        {

        }

        private void Game_over_Load(object sender, EventArgs e)
        {
            
        }
    }
}
