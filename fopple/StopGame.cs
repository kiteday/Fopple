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
    public partial class StopGame : Form
    {
        Level_1 G1;

        public StopGame()
        {
            InitializeComponent();
        }

        public StopGame(Level_1 L1)
        {
            InitializeComponent();
            G1 = L1;
        }


        private void Stop_game_btn_Click(object sender, EventArgs e)
        {
            Level_1.appleBox_player_width = 0;
            Level_1.appleBox_NPC_width = 0;
            Level_1.first_time = 0;

            this.Hide();    //현재 창 닫기

            Level_1 Lv = new Level_1();
            Lv.Visible = false;     //게임(1단계) 창 닫기

            Game_window Gwindow = new Game_window();
            Gwindow.Show();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            //뒤로가기 (Mainform 화면으로 이동)
            Level_1.appleBox_player_width = 0;
            Level_1.appleBox_NPC_width = 0;
            Level_1.first_time = 0;

            //this.Close();
            //level_1창 없애기
            //G1.Close();
            //Game_window Gwdw = new Game_window();
            //Gwdw.Show();
            
            this.Hide();    //현재 창 닫기

            Level_1 Lv = new Level_1();
            Lv.Visible = false;     //게임(1단계) 창 닫기

            Game_window Gwindow = new Game_window();
            Gwindow.Show();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StopGame_Load(object sender, EventArgs e)
        {

        }
    }
}
