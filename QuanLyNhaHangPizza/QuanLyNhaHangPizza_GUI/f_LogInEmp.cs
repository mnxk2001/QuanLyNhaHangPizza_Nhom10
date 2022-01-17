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
    public partial class f_LogInEmp : Form
    {
        public f_LogInEmp()
        {
            InitializeComponent();
        }

        private void btnExit_Cus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_Home home = new f_Home();
                home.ShowDialog();
            }
        }

        private void btnLogIn_Cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Menu_Emp menu = new f_Menu_Emp();
            menu.ShowDialog();
        }
    }
}
