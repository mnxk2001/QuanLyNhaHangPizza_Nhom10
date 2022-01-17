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
    public partial class f_Menu_Emp : Form
    {
        public f_Menu_Emp()
        {
            InitializeComponent();
        }

        private void btnSchel_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_SchelWork_Emp schel = new f_SchelWork_Emp();
            schel.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_LogInEmp logEmp = new f_LogInEmp();
                logEmp.ShowDialog();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ChooseCus fChoose = new f_ChooseCus();
            fChoose.ShowDialog();
        }
    }
}
