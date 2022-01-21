using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    class BUS_LoginAd
    {
        private DAO_LoginAd dao;

        public BUS_LoginAd()
        {
            dao = new DAO_LoginAd();
        }

        public int login(string ID_Users, string PASS)
        {
            return dao.login(ID_Users, PASS);
        }
    }
}
