using QuanLyNhaHangPizza_GUI.BUS_Pizza;
using QuanLyNhaHangPizza_GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using System.Diagnostics;

namespace QuanLyNhaHangPizza_GUI
{
    public partial class f_Payment : Form
    {
        #region MyRegion
        public BUS_Customer bus_cus;
        public BUS_Employee bus_emp;
        public BUS_Product bus_pro;
        public BUS_Bill bus_bill;
        public BUS_BillDetail bus_billD;
        #endregion

        public f_Payment()
        {
            InitializeComponent();
            bus_cus = new BUS_Customer();
            bus_emp = new BUS_Employee();
            bus_pro = new BUS_Product();
            bus_bill = new BUS_Bill();
            bus_billD = new BUS_BillDetail();
        }

        #region Biến toàn cục
        string path;
        DataTable dt;
        #endregion

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

        private void createButton_Product()
        {
            var pizza = bus_pro.ListProduct_Pizza();

            //Tạo button cho pizza
            foreach (var item in pizza)
            {
                string text = item.NAMEPRO.ToString() +  " " + item.UNITPRICEPRO.ToString();
                
                Button btnPro = new Button();
                btnPro.Size = new Size(162, 125);
                btnPro.Text = text;
                //
                //
                //
                btnPro.TabIndex = pizza.IndexOf(item);
                btnPro.TextAlign = ContentAlignment.BottomLeft;
                btnPro.ImageAlign = ContentAlignment.TopCenter;
                btnPro.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnPro.ForeColor = Color.Goldenrod;
                //
                //
                //Image
                string pizzaImage = path + item.PICTURE.ToString();
                if (File.Exists(pizzaImage))
                {
                    btnPro.Image = Image.FromFile(pizzaImage);
                }
                //
                //
                //Event
                btnPro.Click += new System.EventHandler(btnPro_Click);
                //
                //
                //Add
                flpPizza.Controls.Add(btnPro);
            }

            //Tạo button cho Drink
            var drink = bus_pro.ListProduct_Drink();

            foreach (var item in drink)
            {
                string text = item.NAMEPRO.ToString() + " " + item.UNITPRICEPRO.ToString();
                Button btnDrink = new Button();
                btnDrink.Size = new Size(162, 125);
                btnDrink.Text = text;
                //
                //
                //
                btnDrink.TabIndex = drink.IndexOf(item);
                btnDrink.TextAlign = ContentAlignment.BottomLeft;
                btnDrink.ImageAlign = ContentAlignment.TopCenter;
                btnDrink.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDrink.ForeColor = Color.Goldenrod;
                //
                //
                //Image
                string drinkImage = path + item.PICTURE.ToString();
                if (File.Exists(drinkImage))
                {
                    btnDrink.Image = Image.FromFile(drinkImage);
                }
                //
                //
                //Event
                btnDrink.Click += new System.EventHandler(btnDrink_Click);
                //
                //
                //Add
                flpDrink.Controls.Add(btnDrink);
            }
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var pizza = bus_pro.ListProduct_Pizza();
            var item = pizza[btn.TabIndex];
            txtProductName.Text = item.NAMEPRO.ToString();
            txtUnitPrice.Text = item.UNITPRICEPRO.ToString();
            numQuantity.Value = 1;
            int money = int.Parse(txtUnitPrice.Text.Replace(".", ""));
            txtIntoMoney.Text = (money * numQuantity.Value).ToString();
            txtIdProduct.Text = item.ID_PRO.ToString();

            //string text = item.NAMEPRO.ToString();
            //MessageBox.Show("Bạn đang chọn button " + text);

        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var drink = bus_pro.ListProduct_Drink();
            var item = drink[btn.TabIndex];

            txtProductName.Text = item.NAMEPRO.ToString();
            txtUnitPrice.Text = item.UNITPRICEPRO.ToString();
            numQuantity.Value = 1;
            int money = int.Parse(txtUnitPrice.Text.Replace(".", ""));
            txtIntoMoney.Text = (money * numQuantity.Value).ToString();
            txtIdProduct.Text = item.ID_PRO.ToString();
            //string text = item.NAMEPRO.ToString();
            //MessageBox.Show("Bạn đang chọn button " + text);

        }

        private void f_Payment_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            dt.Columns.Add("ID_Pro");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("UnitPricePro");
            dt.Columns.Add("IntoMoney");

            path = Application.StartupPath + @"\ImagesProduct\";
            bus_cus.getCustomer(cbCus_Name);
            bus_emp.getEmployee(cbEmp_Name);

            createButton_Product();
            
            gridProduct.DataSource = dt;
        }

        private void btnF1_T1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (groupF1.ContainsFocus) 
            {
                lbFloor.Text = groupF1.Text;
                lbTable.Text = btn.Text;
            }
            if (groupF2.ContainsFocus)
            {
                lbFloor.Text = groupF2.Text;
                lbTable.Text = btn.Text;
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            int money = int.Parse(txtUnitPrice.Text.Replace(".", ""));
            txtIntoMoney.Text = (money * numQuantity.Value).ToString();

        }

        private int calTotalMoney()
        {
            int totalMoney = 0;
            foreach (DataRow row in dt.Rows)
            {
                int money = int.Parse(row["IntoMoney"].ToString());
                totalMoney = totalMoney + money;
            }

            return totalMoney;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "")
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }

                DataRow row;
                row = dt.NewRow();
                bool flag = true;

                int totalMoney = int.Parse(lbTotalMoney.Text);

                //Nếu có
                foreach (DataRow item in dt.Rows)
                {
                    if (item["ID_Pro"].ToString() == txtIdProduct.Text)
                    {
                        flag = false;
                        item["Quantity"] = (numQuantity.Value + int.Parse(item["Quantity"].ToString())).ToString();
                        item["IntoMoney"] = (int.Parse(txtIntoMoney.Text) + int.Parse(item["IntoMoney"].ToString())).ToString();
                        
                        break;
                    }

                }

                //Nếu chưa có
                if (flag)
                {
                    row["ID_Pro"] = txtIdProduct.Text;
                    row["ProductName"] = txtProductName.Text;
                    row["Quantity"] = numQuantity.Value.ToString();
                    row["UnitPricePro"] = txtUnitPrice.Text;
                    row["IntoMoney"] = txtIntoMoney.Text;
                    dt.Rows.Add(row);
                    
                }

                numQuantity.Value = 1;
                txtIdProduct.Text = "";
                txtIntoMoney.Text = "0";
                txtProductName.Text = "";
                txtUnitPrice.Text = "";

                lbTotalMoney.Text = calTotalMoney().ToString();

                //Tạo Bill mới
                var lastBill = bus_bill.getLastBill();
                string lastIDBill;

                foreach (var item in lastBill)
                {
                    lastIDBill = item.ID_Bill.ToString();

                    int newIDBill = int.Parse(lastIDBill) + 1;
                    txtBillID_New.Text = newIDBill.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(gridProduct.CurrentCell.Value.ToString()))
            {
                txtProductName.Text = gridProduct.CurrentRow.Cells["ProductName"].Value.ToString();
                txtIdProduct.Text = gridProduct.CurrentRow.Cells["ID_Pro"].Value.ToString();
                txtIntoMoney.Text = gridProduct.CurrentRow.Cells["IntoMoney"].Value.ToString();
                txtUnitPrice.Text = gridProduct.CurrentRow.Cells["UnitPricePro"].Value.ToString();
                numQuantity.Value = int.Parse(gridProduct.CurrentRow.Cells["Quantity"].Value.ToString());

            }
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            int totalMoney = int.Parse(lbTotalMoney.Text);
            //Nếu có
            foreach (DataRow item in dt.Rows)
            {
                if (item["ID_Pro"].ToString() == txtIdProduct.Text)
                {
                    item["Quantity"] = numQuantity.Value.ToString();
                    item["IntoMoney"] = txtIntoMoney.Text;
                    
                    break;
                }
            }

            numQuantity.Value = 1;
            txtIdProduct.Text = "";
            txtIntoMoney.Text = "0";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";

            lbTotalMoney.Text = calTotalMoney().ToString();
        }

        private void btnDeletePro_Click_1(object sender, EventArgs e)
        {
            int totalMoney = int.Parse(lbTotalMoney.Text);
            foreach (DataRow item in dt.Rows)
            {
                if (item["ID_Pro"].ToString() == txtIdProduct.Text)
                {
                    dt.Rows.Remove(item);
                    
                    break;
                }
            }

            numQuantity.Value = 1;
            txtIdProduct.Text = "";
            txtIntoMoney.Text = "0";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";

            lbTotalMoney.Text = calTotalMoney().ToString();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
            txtIdProduct.Text = "";
            txtIntoMoney.Text = "0";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";

            dt.Clear();
            lbTotalMoney.Text = "0";

            rbtnChuyenKhoan.Checked = false;
            rbtnMomo.Checked = false;
            rbtnTienMat.Checked = false;
        }
                
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(lbTotalMoney.Text) == 0)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                if (rbtnChuyenKhoan.Checked == false && rbtnMomo.Checked == false && rbtnTienMat.Checked == false) 
                {
                    throw new Exception("Chưa chọn phương thức thanh toán");
                }

                BILL newBill = new BILL();

                newBill.ID_Bill = txtBillID_New.Text;

                newBill.ID_Cus = cbCus_Name.SelectedValue.ToString();
                newBill.ID_Emp = cbEmp_Name.SelectedValue.ToString();
                newBill.DateFounded = dtpDateFounded.Value;
                newBill.TotalMoney = lbTotalMoney.Text;
                newBill.BillNotes = "Đã thanh toán";


                if (bus_bill.addBill(newBill))
                {
                    if (bus_billD.addBillDetail(txtBillID_New.Text, dt, lbTotalMoney.Text))
                    {
                        
                        MessageBox.Show("Thanh toán thành công");
                        numQuantity.Value = 1;
                        txtIdProduct.Text = "";
                        txtIntoMoney.Text = "0";
                        txtProductName.Text = "";
                        txtUnitPrice.Text = "";

                        dt.Clear();
                        lbTotalMoney.Text = "0";

                        rbtnChuyenKhoan.Checked = false;
                        rbtnMomo.Checked = false;
                        rbtnTienMat.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tạo Mã đơn hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            f_Bill bill = new f_Bill();
            bill.Show();
        }

        private void btnEditPay_Click(object sender, EventArgs e)
        {

        }
    }
}
