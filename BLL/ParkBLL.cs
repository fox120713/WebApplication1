using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using MODEL;

namespace BLL
{
    public class ParkBLL
    {
        ParkDAL dal = new ParkDAL();
        public DataTable tcfcx()
        {
            return dal.tcfcx();
        }

        public DataTable tcfcx(int id)
        {
            return dal.tcfcx(id);
        }

        public DataTable tcfzt()
        {
            return dal.tcfzt();
        }

        public DataTable tcfcx(string zt, string cph)
        {
            return dal.tcfcx(cph, zt);
        }

        public int tj(int cwh, string cph, DateTime a)
        {
            return dal.tj(cwh,cph,a);
        }


        public DataTable cx(ParkMODEL a)
        {
            return dal.cx(a);
        }

        public int xg(DateTime a, double money,  int id)
        {
            return dal.xg(a, money, id);
        }
    }
}
