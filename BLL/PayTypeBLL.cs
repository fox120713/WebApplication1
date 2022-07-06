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
    public class PayTypeBLL
    {
        PayTypeDAL dal = new PayTypeDAL();
        //绑定DropDownList1
        public DataTable bd()
        {
            return dal.bd();
        }

        public DataTable bd(int id)
        {
            return dal.bd(id);
        }

        public DataTable cx(string lx)
        {
            return dal.cx(lx);
        }

        public DataTable hq()
        {
            return dal.hq();
        }

        public int tj(PayTypeMODEL a)
        {
            return dal.tj(a);
        }

        public int xg(double dj,int id)
        {
            return dal.xg(dj,id);
        }

    }
}
