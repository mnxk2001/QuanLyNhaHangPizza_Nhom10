using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    public class DAO_Bill
    {
        QLBANHANGPIZZAEntities db;

        public DAO_Bill()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public dynamic getBill()
        {
            var ds = db.sp_getLastBill().ToList();

            return ds;
        }

        public void addBill(BILL bill)
        {
            db.BILLs.Add(bill);
            db.SaveChanges();
        }

        public dynamic getAllBill()
        {
            var ds = db.BILLs.Select(s => new
            {
                s.ID_Bill,
                s.ID_Cus,
                s.ID_Emp,
                s.DateFounded,
                s.TotalMoney,
                s.BillNotes
            }).ToList();

            return ds;
        }

        public void updateBillNote(BILL bill)
        {
            BILL b = db.BILLs.Find(bill.ID_Bill);

            b.BillNotes = "Hủy thanh toán";
            db.SaveChanges();
        }

        public bool checkBillID(string idBIll)
        {
            BILL b = db.BILLs.Find(idBIll);
            if (b != null)
                return true;
            return false;
        }
    }
}
