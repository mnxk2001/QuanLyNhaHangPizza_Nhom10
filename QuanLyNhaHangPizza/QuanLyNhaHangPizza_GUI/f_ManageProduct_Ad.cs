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
    public partial class f_ManageProduct_Ad : Form
    {

        private BUS_Product bus;
        public int maSP;
        public f_ManageProduct_Ad()
        {
            InitializeComponent();
            bus = new BUS_Product();
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
        private void HienThiSanPham()
        {

            gridProduct.DataSource = null;
            bus.LayDSSP(gridProduct);
            //định dạng các cột
            gridProduct.Columns[0].Width = (int)(gridProduct.Width * 0.05);
            gridProduct.Columns[1].Width = (int)(gridProduct.Width * 0.19);
            gridProduct.Columns[2].Width = (int)(gridProduct.Width * 0.10);
            gridProduct.Columns[3].Width = (int)(gridProduct.Width * 0.10);
            gridProduct.Columns[4].Width = (int)(gridProduct.Width * 0.10);
            gridProduct.Columns[5].Width = (int)(gridProduct.Width * 0.19);
            gridProduct.Columns[6].Width = (int)(gridProduct.Width * 0.10);
            gridProduct.Columns[7].Width = (int)(gridProduct.Width * 0.10);
        }

        private void f_ManageProduct_Ad_Load(object sender, EventArgs e)
        {
            //Hiển thị sản phẩm
            HienThiSanPham();
            bus.PhanLoaiSP(cbCate_ID);
            cbCate_ID.SelectedIndex = 0;

        }

        private void gridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridProduct.Rows.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = gridProduct.Rows[e.RowIndex];
                txtPro_ID.Text = row.Cells[0].Value.ToString();
                txtNAMEPRO.Text = row.Cells[1].Value.ToString();
                cbCate_ID.Text = row.Cells[2].Value.ToString();
                numQuantity_Pro.Text = row.Cells[3].Value.ToString();
                cb_Unit.Text = row.Cells[4].Value.ToString();
                txtUnitPrice.Text = row.Cells[5].Value.ToString();
                txtPic_Name.Text = row.Cells[6].Value.ToString();
                txtStatus_Pro.Text = null;
                //Không cho phép sửa
                txtPro_ID.Enabled = false;

            }
        }
        

        private void txtPro_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNAMEPRO.Text == "" ||
                    txtPic_Name.Text == "" ||
                    txtUnitPrice.Text == "" ||
                    numQuantity_Pro.Value == 0) 
                {
                    throw new Exception("Không để trống thông tin");
                }

                PRODUCT sanPham = new PRODUCT();

                //Tạo mới
                var lastPro = bus.getLastProduct();
                string lastIDPro;

                foreach (var item in lastPro)
                {
                    lastIDPro = item.ID_PRO.ToString();

                    int newIDBill = int.Parse(lastIDPro) + 1;
                    txtPro_ID.Text = newIDBill.ToString();
                }

                sanPham.ID_PRO = txtPro_ID.Text;
                sanPham.NAMEPRO = txtNAMEPRO.Text;
                sanPham.ID_CATE = cbCate_ID.SelectedValue.ToString();
                sanPham.QUANTITY = numQuantity_Pro.Text;
                sanPham.UNIT = cb_Unit.Text;
                sanPham.UNITPRICEPRO = txtUnitPrice.Text;
                sanPham.PICTURE = txtPic_Name.Text;
                sanPham.STATUS_PRO = txtStatus_Pro.Text;
                

                //Gọi sự kiện thêm của BUS
                if (bus.addProduct(sanPham))
                {
                    bus.LayDSSP(gridProduct);
                    MessageBox.Show("Thêm sản phẩm thành công!");

                    txtPro_ID.Text = "";
                    txtPic_Name.Text = "";
                    txtNAMEPRO.Text = "";
                    txtStatus_Pro.Text = "";
                    txtUnitPrice.Text = "";
                    numQuantity_Pro.Value = 0;

                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPro_ID.Text == "") 
                {
                    throw new Exception("Vui lòng chọn sản phẩm cần sửa");
                }

                PRODUCT product = new PRODUCT();
                product.ID_PRO = txtPro_ID.Text;
                product.NAMEPRO = txtNAMEPRO.Text;
                product.ID_CATE = cbCate_ID.SelectedValue.ToString();
                product.QUANTITY = numQuantity_Pro.Text;
                product.UNIT = cb_Unit.Text;
                product.PICTURE = txtPic_Name.Text;
                product.STATUS_PRO = txtStatus_Pro.Text;
                product.UNITPRICEPRO = txtUnitPrice.Text;
                // Gọi sự kiện sửa
                if (bus.EditProduct(product))
                {
                    MessageBox.Show("Sửa thành công!");

                    txtPro_ID.Text = "";
                    txtPic_Name.Text = "";
                    txtNAMEPRO.Text = "";
                    txtStatus_Pro.Text = "";
                    txtUnitPrice.Text = "";
                    numQuantity_Pro.Value = 0;

                    bus.LayDSSP(gridProduct);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPro_ID.Text == "")
                {
                    throw new Exception("Vui lòng chọn sản phẩm cần xóa");
                }

                PRODUCT product = new PRODUCT();
                product.ID_PRO = txtPro_ID.Text;

                bus.updateStatusPro(product);

                txtPro_ID.Text = "";
                txtPic_Name.Text = "";
                txtNAMEPRO.Text = "";
                txtStatus_Pro.Text = "";
                txtUnitPrice.Text = "";
                numQuantity_Pro.Value = 0;

                bus.LayDSSP(gridProduct);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_ProName_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("ID_PRO") ;
            tb.Columns.Add("NAMEPRO");
            tb.Columns.Add("ID_CATE");
            tb.Columns.Add("QUANTITY");
            tb.Columns.Add("UNIT");
            tb.Columns.Add("PICTURE");
            tb.Columns.Add("UNITPRICEPRO");
            tb.Columns.Add("STATUS_PRO");
            tb.Columns.Add("CATEGORy");
            DataRow row;
            row = tb.NewRow();
            var pro = bus.Search(txtSearch_ProName.Text);
            tb.Rows.Add(pro);
            foreach(var item in pro)
            {
                row[0] = item.ID_PRO.ToString;
                row[1] = item.NAMEPRO.ToString;
                row[2] = item.ID_CATE.ToString;
                row[3] = item.QUANTITY.ToString;
                row[4] = item.UNIT.ToString;
                row[5] = item.PICTURE.ToString;
                row[6] = item.UNITPRICEPRO.ToString;
                row[7] = item.STATUS_PRO.ToString;
                row[8] = item.CATEGORy.ToString;
            }
            gridProduct.DataSource = tb;
            
        }

        
    }

    
}
