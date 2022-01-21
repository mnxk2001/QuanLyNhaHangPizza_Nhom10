using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHangPizza_GUI.DAO_Pizza;

namespace QuanLyNhaHangPizza_GUI.BUS_Pizza
{
    class BUS_Login
    {
        private DAO_Login dao;

        public BUS_Login()
        {
            dao = new DAO_Login();
        }

        public int login(string ID_Users, string PASS)
        {
            return dao.login(ID_Users, PASS);
        }
    }
}
