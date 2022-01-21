using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.BUS_Pizza;

namespace QuanLyNhaHangPizza_GUI
{
    public partial class f_LogInAdmin : Form
    {
        BUS_LoginAd bus_login;
        public f_LogInAdmin()
        {
            InitializeComponent();
            bus_login = new BUS_LoginAd();
        }

        private void btnExit_Ad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_Home home = new f_Home();
                home.ShowDialog();
            }
        }

        private void btnLogIn_Ad_Click(object sender, EventArgs e)
        {
            ///this.Hide();
            //f_Menu_Ad menu = new f_Menu_Ad();
            //menu.ShowDialog();
            try
            {
                string ID_Cus = txtID_Ad.Text;
                string PASS = txtPass_Ad.Text;
                int result = bus_login.login(ID_Cus, PASS);
                if (result == 1)
                {
                    this.Hide();
                    // formHome.Show();

                    f_Menu_Ad menu = new f_Menu_Ad();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void txtID_Ad_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID_Ad.Text))
            {

                errorProvider1.SetError(txtID_Ad, "Bạn phải nhập ID ");

                btnLogIn_Ad.Enabled = false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtPass_Ad.Text))
                {

                    //errorProvider2.SetError(txtPass_Ad, "bạn phải nhập password");

                    btnLogIn_Ad.Enabled = false;
                }
                else
                {
                    //errorProvider1ID_Cus.Clear();
                    // errorProvider2.Clear();
                    MessageBox.Show("Bạn phải nhập password");

                    btnLogIn_Ad.Enabled = true;
                }
            }

        }

        private void txtPass_Ad_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPass_Ad.Text))
            {

              
                errorProvider2.SetError(txtPass_Ad, "bạn phải nhập password");
                // btnLogin.Enabled = false;
                btnLogIn_Ad.Enabled = false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtID_Ad.Text))
                {
                    errorProvider1.SetError(txtID_Ad, "Username should not be empty");
                    btnLogIn_Ad.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    btnLogIn_Ad.Enabled = true;
                }
            }
        }

        private void f_LogInAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
