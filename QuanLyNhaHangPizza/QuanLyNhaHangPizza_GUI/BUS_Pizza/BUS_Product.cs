using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;
using System.Transactions;
using System.Windows.Forms;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    public class BUS_Product
    {
        public DAO_Product dao_pro;

        public BUS_Product()
        {
            dao_pro = new DAO_Product();
        }

        public dynamic ListProduct_Pizza()
        {
            return dao_pro.getProduct_Pizza(); 
        }

        public dynamic ListProduct_Drink()
        {
            return dao_pro.getProduct_Dink();
        }

        public bool updateQuantityPro(string idPro, DataTable table)
        {
            bool result = false;
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    foreach (DataRow row in table.Rows)
                    {
                        PRODUCT product = new PRODUCT();

                        product.ID_PRO = idPro;
                        int quantity = int.Parse(dao_pro.getQuantity(idPro)) - int.Parse(row[2].ToString());
                        product.QUANTITY = quantity.ToString();


                        if (dao_pro.checkProID_Product(product))
                        {
                            dao_pro.updateQuantity(product);
                        }
                        else
                        {
                            throw new Exception("Sản phẩm " + row[1].ToString() + " không tồn tại");
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
