using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    
    class DAO_Product
    {
        QLBANHANGPIZZAEntities db;
        public DAO_Product()
        {
            db = new QLBANHANGPIZZAEntities();

        }
        public dynamic LayDSSP()
        {
            dynamic ds = db.PRODUCTS.Select(s => new
            {
                s.ID_PRO,
                s.NAMEPRO,
                s.CATEGORy.NAME_CATE,
                s.QUANTITY,
                s.UNIT,
                s.UNITPRICEPRO,
                s.PICTURE,                
                s.STATUS_PRO
            }).ToList();
            return ds;
        }
        //Lấy thông tin sp
        //public PRODUCT LayThongTinSP(int maSP)
        //{
        //    PRODUCT p = db.PRODUCTS.Where(s => s.ID_PRO == maSP).FirstOrDefault();
        //    return p;

        //}
        //Lấy cb Phân loại
        public dynamic PhanLoaiSP()
        {
            dynamic ds = db.CATEGORIES.Select(s => new
            {
                s.ID_CATE,
                s.NAME_CATE
            }).ToList();
            return ds;
        }
        //Tạo sản phẩm
        public void TaoSanPham(PRODUCT product)
        {
            db.PRODUCTS.Add(product);
            db.SaveChanges();
        }
        public void addProduct(PRODUCT product)
        {
            db.PRODUCTS.Add(product);
            db.SaveChanges();
        }
        //Kiểm tra sản phẩm
        public bool TestProduct(PRODUCT d)
        {
            PRODUCT product = db.PRODUCTS.Find(d.ID_PRO);
            if (product != null)
            {
                return true;
            }
            else
                return false;
        }
        //Sửa sản phẩm
        public void EditProduct(PRODUCT s)
        {
            db.sp_EditEMP(s.ID_PRO,s.NAMEPRO,s.ID_CATE,s.QUANTITY,s.UNIT,s.PICTURE,s.UNITPRICEPRO,s.STATUS_PRO);
            db.SaveChanges();
        }

        public dynamic getLastPro()
        {
            var ds = db.sp_getLastProduct().ToList();

            return ds;
        }

        public void updateStatusPro(PRODUCT product)
        {
            PRODUCT p = db.PRODUCTS.Find(product.ID_PRO);

            p.STATUS_PRO = "Không sử dụng";
            db.SaveChanges();
        }

        public bool checkProID(string idPro)
        {
            PRODUCT p = db.PRODUCTS.Find(idPro);
            if (p != null)
                return true;
            return false;
        }

        public bool checkNamePro_Product(PRODUCT p)
        {
            bool result = false;
            int? exists = -1;

            exists = db.sp_CheckNamePro_Product(p.NAMEPRO).FirstOrDefault();
            if (exists == 0)
            {
                result = true;
            }

            return result;
        }
        //Tìm kiếm
        public dynamic checkFind(string chuoi )
        {
            var ds = db.sp_TimKiem(chuoi).ToList();
            return ds;
        
        }
    }
}
