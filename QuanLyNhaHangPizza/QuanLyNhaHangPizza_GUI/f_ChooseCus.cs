using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangPizza_GUI
{
    public partial class f_ChooseCus : Form
    {
        public f_ChooseCus()
        {
            InitializeComponent();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Payment pay = new f_Payment();
            pay.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            f_AddCus addCus = new f_AddCus();
            addCus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
