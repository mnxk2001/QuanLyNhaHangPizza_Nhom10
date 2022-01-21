using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    public class BUS_Bill
    {
        DAO_Bill dao_bill;

        public BUS_Bill()
        {
            dao_bill = new DAO_Bill();
        }

        public dynamic getLastBill()
        {
            return dao_bill.getBill();
        }

        public bool addBill(BILL bill)
        {
            try
            {
                dao_bill.addBill(bill);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void getAllBill(DataGridView dg)
        {
            dg.DataSource = dao_bill.getAllBill();
        }

        public bool updateBillNote(BILL bill)
        {
            if (dao_bill.checkBillID(bill.ID_Bill))
            {
                try
                {
                    dao_bill.updateBillNote(bill);
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
