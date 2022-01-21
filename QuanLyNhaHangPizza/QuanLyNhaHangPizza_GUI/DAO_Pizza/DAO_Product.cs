using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    public class DAO_Product
    {
        QLBANHANGPIZZAEntities db;

        public DAO_Product()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public dynamic getProduct_Pizza()
        {
            var ds = db.PRODUCTS.Select(s => new
            {
                s.ID_PRO,
                s.NAMEPRO,
                s.ID_CATE,
                s.QUANTITY,
                s.PICTURE,
                s.UNITPRICEPRO,
                s.STATUS_PRO
            }).Where(s => s.ID_CATE == "PZ").ToList();

            return ds;
        }

        public dynamic getProduct_Dink()
        {
            var ds = db.PRODUCTS.Select(s => new
            {
                s.ID_PRO,
                s.NAMEPRO,
                s.ID_CATE,
                s.QUANTITY,
                s.PICTURE,
                s.UNITPRICEPRO,
                s.STATUS_PRO
            }).Where(s => s.ID_CATE == "Drink").ToList();

            return ds;
        }

        public bool checkProID_Product(PRODUCT p)
        {
            bool result = false;
            int? exists = -1;

            exists = db.sp_CheckIDPro_Product1(p.ID_PRO).FirstOrDefault();
            if (exists == 1)
            {
                result = true;
            }

            return result;
        }

        public void updateQuantity(PRODUCT p)
        {
            db.sp_updateQuantityProduct(p.ID_PRO, p.QUANTITY);
            db.SaveChanges();
        }

        public string getQuantity(string idPro)
        {
            PRODUCT product = db.PRODUCTS.Find(idPro);
            string quantity = product.QUANTITY;
            return quantity;
        }
    }
}
