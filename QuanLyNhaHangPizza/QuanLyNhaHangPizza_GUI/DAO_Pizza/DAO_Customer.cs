using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    public class DAO_Customer
    {
        QLBANHANGPIZZAEntities db;

        public DAO_Customer()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public dynamic getCustomer()
        {
            dynamic ds = db.CUSTOMERs.Select(s => new
            {
                s.ID_CUS,
                s.NAME_CUS
            }).ToList();

            return ds;
        }

        public dynamic getAllCustomer()
        {
            dynamic ds = db.CUSTOMERs.Select(s => new
            {
                s.ID_CUS,
                s.NAME_CUS,
                s.SEX,
                s.DATEOFBIRTH,
                s.PHONE,
                s.ADDRESS_CUS
            }).ToList();

            return ds;
        }

        public void insertCusomer(CUSTOMER cus)
        {
            db.CUSTOMERs.Add(cus);
            db.SaveChanges();
        }
    }
}
