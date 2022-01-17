using QuanLyNhaHangPizza_GUI.BUS_Pizza;
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
    public partial class f_Payment : Form
    {
        public BUS_Customer bus_cus;

        public f_Payment()
        {
            InitializeComponent();
            bus_cus = new BUS_Customer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_ChooseCus menu = new f_ChooseCus();
                menu.ShowDialog();
            }
        }

        private void f_Payment_Load(object sender, EventArgs e)
        {
            bus_cus.getCustomer(cbCus_Name);
        }
    }
}
