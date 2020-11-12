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
    public partial class End_system : Form
    {
        public End_system()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_message_Click(object sender, EventArgs e)
        {

        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            Application.Exit(); //프로그램 종료
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Close(); //창 종료
        }

        private void End_system_Load(object sender, EventArgs e)
        {

        }

        private void no_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
