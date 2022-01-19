using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

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
    }
}
