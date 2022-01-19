using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    public class BUS_Employee
    {
        public DAO_Employee dao_emp;

        public BUS_Employee()
        {
            dao_emp = new DAO_Employee();
        }

        public void getEmployee(ComboBox comboBox)
        {
            comboBox.DataSource = dao_emp.getEmployee();
            comboBox.DisplayMember = "Name_Emp";
            comboBox.ValueMember = "ID_Emp";
        }
    }
}
