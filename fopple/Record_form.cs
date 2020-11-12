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
    public partial class Record_form : Form
    {
        private static int Personal_data = Level_1.Lose_player_width;
        //public static String[] data = Mainform.personal_array;
        //StringBuilder sb = new StringBuilder();
        //private int i = 0;

        int[] scores = { Level_1.Lose_player_width };
        public Record_form()
        {
            InitializeComponent();

            //그림 겹치기
            apple_background.Controls.Add(All_end); //배경과 사진 합치기
            All_end.Location = new Point(1496, 12); //사진 위치 지정하기
            apple_background.Controls.Add(Back_btn);
            Back_btn.Location = new Point(12, 12);
            apple_background.Controls.Add(user_chart);
            user_chart.Location = new Point(336, 175);

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Record_form_Load(object sender, EventArgs e)
        {

        }

        private void All_end_Click(object sender, EventArgs e)
        {
            //게임 전체 종료
            End_system Esystem = new End_system();
            Esystem.Show();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //메인폼 창으로 가는 코드
            this.Hide();
            Mainform Main = new Mainform();
            Main.Show();
        }

        private void user_chart_Click(object sender, EventArgs e)
        {
            //차트
            user_chart.Series[0].Points.DataBindY(scores);
        }

        //DataTable mdata = new DataTable();
        //mdata.Rows.Add("0", "Personal_data", Personal_data);
        //user_chart.Series[0].Points.DataBindXY(num.ToString(), Personal_data.ToString());

        //user_chart.Series[0].Points.DataBindY(scores);        // 이렇게 쓰면 됨 

        //for(i=0; i< Game_window.Click_num; i++)
        // {
        //     //sb.Append(data[num]);

        //     scores[i] = Personal_data;

        // }
        //user_chart.Series[0].Points.DataBindY(scores);
        //user_chart.Series[1].Points.DataBindY(scores);

    }
}
