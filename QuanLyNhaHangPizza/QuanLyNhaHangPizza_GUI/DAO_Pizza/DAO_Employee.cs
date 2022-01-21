using System.Linq;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    class DAO_Employee
    {
        QLBANHANGPIZZAEntities db;
        public DAO_Employee()
        {
            db = new QLBANHANGPIZZAEntities();

        }
        public dynamic LayDSNV()
        {
            var ds = db.EMPLOYEEs.Select(s => new
            {
                s.ID_Emp,
                s.Name_Emp,
                s.Phone,
                s.Address_Emp,
                s.Sex,
                s.DateOfBirth,
                s.Position,
                s.STATUS_EMP
            }).ToList();
            return ds;
        }
        public void TaoNhanVien(EMPLOYEE employee)
        {
            db.EMPLOYEEs.Add(employee);
            db.SaveChanges();
        }

        public int soLuongNhanVien()
        {
            var qtt = db.EMPLOYEEs.Count(s => s.ID_Emp != "Admin");
            return qtt;
        }

        public void SuaNhanVien(EMPLOYEE emp)
        {
            EMPLOYEE e = db.EMPLOYEEs.Find(emp.ID_Emp);

            db.SP_UPDATEEMPLOYEE(emp.ID_Emp, emp.Name_Emp, emp.Phone, emp.Address_Emp, emp.Position);
            db.SaveChanges();

        }

        public bool KiemTraNV(EMPLOYEE d)//
        {
            EMPLOYEE e = db.EMPLOYEEs.Find(d.ID_Emp);
            if (e != null)
            {
                return true;
            }
            else
                return false;
        }

        public void updateStatusEmp(EMPLOYEE emp)
        {
            EMPLOYEE e = db.EMPLOYEEs.Find(emp.ID_Emp);

            e.STATUS_EMP = "Nghỉ việc";
            db.SaveChanges();
        }
    }
   
}
