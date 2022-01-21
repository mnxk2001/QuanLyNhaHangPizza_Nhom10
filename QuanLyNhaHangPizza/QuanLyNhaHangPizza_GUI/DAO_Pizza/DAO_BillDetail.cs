using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    public class DAO_BillDetail
    {
        QLBANHANGPIZZAEntities db;

        public DAO_BillDetail()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public bool checkProID_BillDetail(BILLDETAIL billD)
        {
            bool result = false;
            int? exists = -1;

            exists = db.sp_CheckIDPro_BillDetail(billD.ID_Bill, billD.ID_Pro).FirstOrDefault();
            if (exists == 0)
            {
                result = true;
            }

            return result;
        }

        public void insertBillDetail(BILLDETAIL billD)
        {
            db.BILLDETAILs.Add(billD);
            db.SaveChanges();
        }

        public void updateTotalMoneyBill(string idBill, string totalMoney)
        {
            db.sp_updateTotalMoney(idBill, totalMoney);
            db.SaveChanges();
        }
    }
        
}
