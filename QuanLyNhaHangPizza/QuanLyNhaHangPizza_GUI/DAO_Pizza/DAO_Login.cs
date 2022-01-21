using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangPizza_GUI.DAO_Pizza
{
    class DAO_Login
    {
        private QLBANHANGPIZZAEntities db;

        public DAO_Login()
        {
            db = new QLBANHANGPIZZAEntities();
        }

        public int login(string ID_Users, string PASS)
        {
            var result = db.ACCOUNTs.FirstOrDefault(e => e.ID_User == ID_Users &&
                                                    e.PASS == PASS && e.ID_Emp != "Admin");
            if (result != null)
            {
                return 1;
            }
            return 0;
        }
    }
}
