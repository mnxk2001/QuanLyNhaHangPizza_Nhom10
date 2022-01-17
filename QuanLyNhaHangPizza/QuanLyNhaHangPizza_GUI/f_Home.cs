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
    public partial class f_Home : Form
    {
        public f_Home()
        {
            InitializeComponent();
        }

        private void btnLogIn_Cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_LogInEmp cus = new f_LogInEmp();
            cus.ShowDialog();
        }

        private void btnLogIn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_LogInAdmin ad = new f_LogInAdmin();
            ad.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void f_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
