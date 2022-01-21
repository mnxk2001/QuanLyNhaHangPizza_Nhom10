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
    public partial class f_AddCus : Form
    {
        BUS_Customer bus_cus;

        public f_AddCus()
        {
            InitializeComponent();
            bus_cus = new BUS_Customer();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Cus.Text == "" || 
                    txtAddress.Text == "" || 
                    txtName_Cus.Text == "" || 
                    txtPhone.Text == "") 
                {
                    throw new Exception("Không để trống thông tin");
                }

                if (rbFemale.Checked == false && rbMale.Checked == false) 
                {
                    throw new Exception("Vui lòng chọn giới tính");
                }

                int age = DateTime.Today.Year - dtpBirth.Value.Year;

                if (age < 18)
                {
                    throw new Exception("Chỉ tạo khách hàng mới khi đủ 18 tuổi");
                }

                //int money = int.Parse(txtUnitPrice.Text.Replace(".", ""));
                //txtIntoMoney.Text = (money * numQuantity.Value).ToString();
                int count = gridCus.RowCount;

                int idCus = int.Parse(gridCus.Rows[count - 1].Cells[0].Value.ToString().Replace("A","")) + 1;
                
                CUSTOMER cus = new CUSTOMER();
                cus.ID_CUS = "A" + idCus.ToString();
                cus.NAME_CUS = txtName_Cus.Text;
                cus.PHONE = txtPhone.Text;
                cus.ADDRESS_CUS = txtAddress.Text;

                if (rbMale.Checked == true) 
                {
                    cus.SEX = "Nam";
                }
                else
                {
                    cus.SEX = "Nữ";
                }

                cus.DATEOFBIRTH = dtpBirth.Value;

                if (bus_cus.addCusomer(cus))
                {
                    MessageBox.Show("Thêm khách hàng thành công");

                    bus_cus.getCustomer4Create(gridCus);

                    int count1 = gridCus.RowCount;
                    int idCus1 = int.Parse(gridCus.Rows[count1 - 1].Cells[0].Value.ToString().Replace("A", "")) + 1;
                    txtID_Cus.Text = "A" + idCus1.ToString();

                    txtAddress.Text = "";
                    txtName_Cus.Text = "";
                    txtPhone.Text = "";
                    dtpBirth.Value = DateTime.Today;
                    rbFemale.Checked = rbMale.Checked = false;
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void f_AddCus_Load(object sender, EventArgs e)
        {
            bus_cus.getCustomer4Create(gridCus);

            int count = gridCus.RowCount;
            int idCus = int.Parse(gridCus.Rows[count - 1].Cells[0].Value.ToString().Replace("A", "")) + 1;
            txtID_Cus.Text = "A" + idCus.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Payment pay = new f_Payment();
            pay.Show();
        }
    }
}
