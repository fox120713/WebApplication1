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
    public class AppBLL
    {
        AppDAL dal = new AppDAL();
        public DataTable table()
        {
            return dal.table();
        }

        public DataTable bd()
        {
            return dal.bd();
        }
        public DataTable bd(int n)
        {
            return dal.bd(n);
        }

        public DataTable mxcx(int id, double money)
        {
            return dal.mxcx(id, money);
        }

        //添加拨款记录
        public int tj(AppMODEL a)
        {
            return dal.tj(a);
        }

        //查询拨款记录
        public DataTable mxcx(string blr,string n,string y)
        {
            return dal.mxcx(blr,n,y);
        }
        public DataTable xs(int id)
        {
            return dal.xs(id);
        }
    }
}
