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
    public partial class Game_win : Form
    {
        public static int NPC_Bar_h;
        public Game_win()
        {
            InitializeComponent();

            //그림 겹치기
            apple_background.Controls.Add(win_text); //배경과 사진 합치기
            win_text.Location = new Point(0, 0); //사진 위치 지정하기
            win_text.Controls.Add(All_end); 
            All_end.Location = new Point(1496, 12); 
            win_text.Controls.Add(girl_win);
            girl_win.Location = new Point(93, 291);
            win_text.Controls.Add(cat_lose);
            cat_lose.Location = new Point(1246, 472);
            win_text.Controls.Add(replay_btn);
            replay_btn.Location = new Point(690, 470);
            win_text.Controls.Add(stop_btn);
            stop_btn.Location = new Point(690, 575);

            NPC_Bar_h = 390 - 39 * Level_1.complete_data;
            NPC_Bar.Size = new System.Drawing.Size(65, NPC_Bar_h);

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void Game_win_Load(object sender, EventArgs e)
        {

        }

        private void win_text_Click(object sender, EventArgs e)
        {

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            //그만하기
            Mainform main = new Mainform();
            this.Close();
            main.Show();
        }

        private void replay_btn_Click(object sender, EventArgs e)
        {
            //다시하기
            //난이도 선택 화면으로 넘어감
            Game_window Gwindow = new Game_window();
            this.Close();
            Gwindow.Show();
        }
        //Level_1 play_window = new Level_1();
        //if (Game_window.easy_level_num == 30)   // easy모드로 리플레이 하기
        //{
        //    this.Close();
        //    play_window.Show();
        //}
        //else if(Game_window.normal_level_num == 50)      // normal모드로 리플레이 하기
        //{
        //    this.Close();
        //    play_window.Show();
        //}
        //else if(Game_window.hard_level_num == 70)        // hard모드로 리플레이 하기
        //{
        //    this.Close();
        //    play_window.Show();
        //}
        //뇌파를 Game_window에서 받아오는 거라서 그 창을 거치지 않으면 게임이 진행되지 않으므로 각 창으로 이동해서 해당모드로 리플레이가 안됨


    }
}
