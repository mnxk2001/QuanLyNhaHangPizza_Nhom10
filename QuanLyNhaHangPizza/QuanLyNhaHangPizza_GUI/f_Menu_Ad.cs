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
    public partial class f_Menu_Ad : Form
    {
        public f_Menu_Ad()
        {
            InitializeComponent();
        }

        private void btnStatis_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ManageStatis_Ad statis = new f_ManageStatis_Ad();
            statis.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ManageProduct_Ad product = new f_ManageProduct_Ad();
            product.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_ManageEmp_Ad emp = new f_ManageEmp_Ad();
            emp.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_LogInAdmin logAd = new f_LogInAdmin();
                logAd.ShowDialog();
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
