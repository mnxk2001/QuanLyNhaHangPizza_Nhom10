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
        #endregion

        public f_Payment()
        {
            InitializeComponent();
            bus_cus = new BUS_Customer();
            bus_emp = new BUS_Employee();
            bus_pro = new BUS_Product();
                        
        }

        #region Biến toàn cục
        string path;
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
            int count = 0;
            foreach (var item in pizza)
            {
                string text = item.NAMEPRO.ToString() +  " " + item.UNITPRICEPRO.ToString();
                
                Button btnPro = new Button();
                btnPro.Size = new Size(162, 125);
                btnPro.Text = text;
                //
                //
                //
                btnPro.TabIndex = count + 1;
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
                btnDrink.TabIndex = count + 1;
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
                btnDrink.Click += new System.EventHandler(btnPro_Click);
                //
                //
                //Add
                flpDrink.Controls.Add(btnDrink);
            }
        }

        private void btnPro_Click(object sender, EventArgs e)
        {

        }

        private void f_Payment_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\ImagesProduct\";
            bus_cus.getCustomer(cbCus_Name);
            bus_emp.getEmployee(cbEmp_Name);
            createButton_Product();
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
    }
}
