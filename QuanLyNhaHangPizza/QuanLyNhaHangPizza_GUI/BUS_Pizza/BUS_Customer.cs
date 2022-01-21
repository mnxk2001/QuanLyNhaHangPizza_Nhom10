using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    public class BUS_Customer
    {
        public DAO_Customer dao_cus;

        public BUS_Customer()
        {
            dao_cus = new DAO_Customer();
        }

        public void getCustomer(ComboBox comboBox)
        {
            comboBox.DataSource = dao_cus.getCustomer();
            comboBox.DisplayMember = "NAME_CUS";
            comboBox.ValueMember = "ID_CUS";
        }

        public void getCustomer4Create(DataGridView dg)
        {
            dg.DataSource = dao_cus.getAllCustomer();
        }

        public bool addCusomer(CUSTOMER cus)
        {
            try
            {
                dao_cus.insertCusomer(cus);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
