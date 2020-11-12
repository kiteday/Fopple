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
    public partial class logout : Form
    {
        Mainform Mf;
        public logout()
        {
            InitializeComponent();
        }

        public logout(Mainform mainform1)
        {
            InitializeComponent();
            Mf = mainform1;
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {


            this.Hide();
            Mf.Close();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_Load(object sender, EventArgs e)
        {

        }
    }
}
