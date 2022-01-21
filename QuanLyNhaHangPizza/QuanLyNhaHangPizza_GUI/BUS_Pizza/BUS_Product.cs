using QuanLyNhaHangPizza_GUI.DAO_Pizza;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    class BUS_Product
    {
        DAO_Product dao;

        public BUS_Product()
        {
            dao = new DAO_Product();
        }
        public void LayDSSP(DataGridView gv)
        {
            gv.DataSource = dao.LayDSSP();
        }
        //public void LayDSSP(ComboBox cb)
        //{
        //    cb.DataSource = dao.LayDSSP();
        //    cb.DisplayMember = "NAMEPRO";//hiển thị
        //    cb.ValueMember = "ID_PRO";//lưu trữ
        //}
        public void PhanLoaiSP(ComboBox cb)
        {

            cb.DataSource = dao.PhanLoaiSP();
            cb.DisplayMember = "NAME_CATE";//hiển thị
            cb.ValueMember = "ID_CATE";//lưu trữ
        }
        public bool EditProduct(PRODUCT product)
        {
            if (dao.TestProduct(product)) 
            {
                try
                {
                    //Sửa thành công
                    dao.EditProduct(product);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại");
                return false;

            }
        }
        public bool addProduct(PRODUCT product)
        {
            if (dao.checkProID(product.ID_PRO) == false)
            {
                try
                {
                    dao.addProduct(product);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(" Sản phẩm đã tồn tại");
                return false;
            }
                
                
        }
        //public PRODUCT LayThongTinSP(int maSP)
        //{
        //    //Kiểm tra mSP, CÓ THÌ MỚI LẤY
        //    return dao.LayThongTinSP(maSP);

        //}

        //internal PRODUCT LayDSSP(int maSP)
        //{
        //    throw new NotImplementedException();
        //}
        //public bool ThemSanPham(PRODUCT product)
        //{
        //    try
        //    {
        //        dao.add(product);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}

        public dynamic getLastProduct()
        {
            return dao.getLastPro();
        }

        public bool updateStatusPro(PRODUCT product)
        {
            if (dao.checkProID(product.ID_PRO))
            {
                try
                {
                    dao.updateStatusPro(product);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(" Sản phẩm không tồn tại");
                return false;
            }
        }
        public dynamic Search(string chuoi)
        {
            return dao.checkFind(chuoi);
        }

        
    }
}
