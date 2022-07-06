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
   public class jfhzBLL
    {
       jfhzDAL dal = new jfhzDAL();
        public DataTable table(string ld)
        {
            return dal.table(ld);
        }

        public DataTable table(string ld, string yf)
        {
            return dal.table(ld, yf);
        }

        public DataTable bd()
        {
            return dal.bd();
        }

        public DataTable ss(string ld, string yf)
        {
            return dal.ss(ld, yf);
        }

        public DataTable syjy(string ld, string yf)
        {
            return dal.syjy(ld, yf);
        }

        public int tj(jfhzMODEL a)
        {
            return dal.tj(a);
        }
    }
}
