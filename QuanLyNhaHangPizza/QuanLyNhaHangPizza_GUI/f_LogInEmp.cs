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
    public partial class f_LogInEmp : Form
    {
        BUS_Login bus_login;
        public f_LogInEmp()
        {
            InitializeComponent();
            bus_login = new BUS_Login();
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
            //this.Hide();
            //f_Menu_Emp menu = new f_Menu_Emp();
            // menu.ShowDialog();
            try
            {
                string ID_Cus = txtID_Emp.Text;
                string PASS = txtPass_Emp.Text;
                //int result = BUS_Pizza.BUS_Login(ID_Cus, PASS);
                int result = bus_login.login(ID_Cus, PASS);
                if (result == 1)
                {
                    this.Hide();
                    // formHome.Show();
                    f_Menu_Emp menu = new f_Menu_Emp();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_Cus_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID_Emp.Text))
            {
               
                errorProvider1.SetError(txtID_Emp, "bạn phải nhập ID ");
           
                btnLogIn_Cus.Enabled = false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtPass_Emp.Text))
                {
                  
                    errorProvider2.SetError(txtPass_Emp, "bạn phải nhập password");
                   
                    btnLogIn_Cus.Enabled = false;
                }
                else
                {
                    //errorProvider1ID_Cus.Clear();
                    errorProvider2.Clear();
                  
                    btnLogIn_Cus.Enabled =true;
                }
            }

        }

        private void txtPass_Cus_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPass_Emp.Text))
            {

                //errorProviderPassword.SetError(txtPass_Cus, "Password should not be empty");
                errorProvider2.SetError(txtPass_Emp, "bạn phải nhập password");
                // btnLogin.Enabled = false;
                btnLogIn_Cus.Enabled = false;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtID_Emp.Text))
                {
                    errorProvider1.SetError(txtID_Emp, "Username should not be empty");
                    btnLogIn_Cus.Enabled = false;
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    btnLogIn_Cus.Enabled = true;
                }
            }

        }

        private void f_LogInEmp_Load(object sender, EventArgs e)
        {

        }

        private void checkPass_Cus_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
