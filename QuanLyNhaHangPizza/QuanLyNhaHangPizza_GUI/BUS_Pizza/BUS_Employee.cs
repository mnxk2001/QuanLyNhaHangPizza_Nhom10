using QuanLyNhaHangPizza_GUI.DAO_Pizza;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    class BUS_Employee
    {
        DAO_Employee dao;

        public BUS_Employee()
            {
              dao = new DAO_Employee();
            }
        public void LayDSNV(DataGridView gv)
        {
            gv.DataSource = dao.LayDSNV();
        }
        public bool TaoNhanVien(EMPLOYEE employee)
        {
            try
            {
                dao.TaoNhanVien(employee);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public int soLuongNhanVien()
        {
            return dao.soLuongNhanVien();
        }

        public bool SuaNhanVien(EMPLOYEE employee)
        {
            if (dao.KiemTraNV(employee)) //CAN SUA Viet Procedure
            {
                try
                {
                    dao.SuaNhanVien(employee);
                    return true;
                }
                catch (DbUPdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool updateStatusEmp(EMPLOYEE emp)
        {
            if (dao.KiemTraNV(emp))
            {
                try
                {
                    dao.updateStatusEmp(emp);
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
                MessageBox.Show(" Employee không tồn tại");
                return false;
            }
        }

    }
   
}
