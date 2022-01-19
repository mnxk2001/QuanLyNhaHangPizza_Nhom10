using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    public class DAO_Employee
    {
        QLBANHANGPIZZAEntities db;

        public DAO_Employee()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public dynamic getEmployee()
        {
            dynamic ds = db.EMPLOYEEs.Select(s => new
            {
                s.ID_Emp,
                s.Name_Emp
            }).ToList();

            return ds;
        }
    }
}
