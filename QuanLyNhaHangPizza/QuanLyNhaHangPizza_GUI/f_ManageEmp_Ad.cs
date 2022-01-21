using QuanLyNhaHangPizza_GUI.BUS_Pizza;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaHangPizza_GUI
{
    public partial class f_ManageEmp_Ad : Form
    {

        private BUS_Employee bus;
        public f_ManageEmp_Ad()
        {
            InitializeComponent();
            bus = new BUS_Employee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                f_Menu_Ad menu = new f_Menu_Ad();
                menu.ShowDialog();
            }
        }
        private void HienThiNhanVien()
        {
            gridEmployee.DataSource = null;
            bus.LayDSNV(gridEmployee);
            gridEmployee.Columns[0].Width = (int)(gridEmployee.Width * 0.08);
            gridEmployee.Columns[1].Width = (int)(gridEmployee.Width * 0.2);
            gridEmployee.Columns[2].Width = (int)(gridEmployee.Width * 0.1);
            gridEmployee.Columns[3].Width = (int)(gridEmployee.Width * 0.2);
            gridEmployee.Columns[4].Width = (int)(gridEmployee.Width * 0.05);
            gridEmployee.Columns[5].Width = (int)(gridEmployee.Width * 0.1);
            gridEmployee.Columns[6].Width = (int)(gridEmployee.Width * 0.1);
            gridEmployee.Columns[7].Width = (int)(gridEmployee.Width * 0.1);
        }

        private void f_ManageEmp_Ad_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            txtID_Emp.Enabled = false;
            txtPhone_Emp .MaxLength = 10;
            
        }

        private void gridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridEmployee.Rows.Count)
            {
                txtID_Emp.Text = gridEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtID_Emp.Enabled = false;
                txtName_Emp.Text = gridEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone_Emp.Text = gridEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress_Emp.Text = gridEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpBirthday_Emp.Text = Text = gridEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (gridEmployee.Rows[e.RowIndex].Cells[7].Value != null)
                {
                    txtStatus_Emp.Text = Text = gridEmployee.Rows[e.RowIndex].Cells[7].Value.ToString();
                }                

                if (gridEmployee.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtName_Emp.Text == ""
                    && txtPhone_Emp.Text == ""
                    && dtpBirthday_Emp.Text == ""
                    && txtAddress_Emp.Text == "")
                {
                    throw new Exception("Không để trống thông tin");
                }

                if (rbtnFemale.Checked == false && rbtnMale.Checked == false) 
                {
                    throw new Exception("Chưa chọn giới tính");
                }

                int tuoi = DateTime.Today.Year - dtpBirthday_Emp.Value.Year;

                if (tuoi < 18)
                {
                    throw new Exception("Chỉ chấp nhận nhân viên đủ 18 tuổi");
                }

                int soLuongNV = bus.soLuongNhanVien() + 1;
                EMPLOYEE employee = new EMPLOYEE();
                
                employee.ID_Emp = "NV" +soLuongNV.ToString();

                employee.Name_Emp = txtName_Emp.Text;
                employee.Address_Emp = txtAddress_Emp.Text;
                employee.Phone = txtPhone_Emp.Text;
                if (rbtnMale.Checked == true)
                {
                    employee.Sex = rbtnMale.Text;
                }
                else
                if (rbtnFemale.Checked == true)
                {
                    employee.Sex = rbtnFemale.Text;
                }
                employee.DateOfBirth = dtpBirthday_Emp.Value;
                employee.Position = "Nhân viên";
                if (txtStatus_Emp.Text != "")
                {
                    employee.STATUS_EMP = txtStatus_Emp.Text;
                }
                else
                {
                    employee.STATUS_EMP = "";
                }

                //gọi sự kiện bus
                if (bus.TaoNhanVien(employee))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    HienThiNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
                
            }
            catch(SqlException ex1)
            {
                MessageBox.Show(ex1.Message);
            } 
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public void clearText()
        {
            txtID_Emp .Text = "";
            txtName_Emp.Text= dtpBirthday_Emp.Text = "";
            txtPhone_Emp.Text = "";
            txtAddress_Emp .Text = "";
            rbtnMale.Checked =rbtnFemale.Checked = false;
            txtStatus_Emp.Text = "";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtID_Emp.Text!="")
                {
                    EMPLOYEE emp = new EMPLOYEE();
                    emp.ID_Emp = txtID_Emp.Text;
                    emp.Name_Emp = txtName_Emp.Text;
                    emp.Phone = txtPhone_Emp.Text;
                    emp.Address_Emp = txtAddress_Emp.Text;
                    emp.Position = "Nhân viên";
                    emp.STATUS_EMP = txtStatus_Emp.Text;
                    if (bus.SuaNhanVien(emp))
                    {
                        MessageBox.Show("Sửa nhân viên thành công");

                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại");
                    }
                  
                    HienThiNhanVien();

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên muốn sửa!!!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            clearText();
        }

        private void txtPhone_Emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Emp.Text == "")
                {
                    throw new Exception("Vui lòng chọn nhân viên cần xóa");

                }
                EMPLOYEE emp = new EMPLOYEE();
                emp.ID_Emp = txtID_Emp.Text;

                if (bus.updateStatusEmp(emp))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
               

                clearText();
                HienThiNhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
