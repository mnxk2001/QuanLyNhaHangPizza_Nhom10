using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;
using System.Transactions;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    public class BUS_BillDetail
    {
        DAO_BillDetail dao_billD;

        public BUS_BillDetail()
        {
            dao_billD = new DAO_BillDetail();
        }

        public bool addBillDetail(string idBill, DataTable table, string totalMoney)
        {
            bool result = false;
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    foreach (DataRow row in table.Rows)
                    {
                        BILLDETAIL billD = new BILLDETAIL();

                        billD.ID_Bill = idBill;
                        billD.ID_Pro = row[0].ToString();
                        billD.Quantity = row[2].ToString();
                        billD.UnitPrice = row[3].ToString();
                        billD.IntoMoney = row[4].ToString();
                                                
                        if (dao_billD.checkProID_BillDetail(billD))
                        {
                            dao_billD.insertBillDetail(billD);
                            dao_billD.updateTotalMoneyBill(idBill, totalMoney);
                        }
                        else
                        {
                            throw new Exception("Sản phẩm " + row[1].ToString() + " đã tồn tại");
                        }

                    }
                    trans.Complete();
                    result = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);                    
                }
            }
            return result;
        }
    }
}
