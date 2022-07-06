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
    public class DopantBLL
    {
        DopantDAL dal = new DopantDAL();
        public DataTable table()
        {
            return dal.table();
        }
        public DataTable DopantALL(string name)
        {
            return dal.DopantALL(name);


        }
        public DataTable cxxm(string name)
        {
            return dal.cxxm(name);
        }


        public int DopantInsert(string name, string Usercell, int payid, int money)
        {
            return dal.DopantInsert(name, Usercell, payid, money);


        }
        public DataTable cxld(string name)
        {
            return dal.cxld(name);
        }


        //添加收费
        public int tj(DopantMODEL a)
        {
            return dal.tj(a);
        }


        public DataTable bd2()
        {
            return dal.bd2();
        }

        public DataTable jfcx(string ld, int lx, string jf)
        {
            return dal.jfcx(ld, lx, jf);
        }

        public DataTable DopantALL()
        {
            return dal.DopantALL();
        }

        //修改收费
        public int xg(string name, int id)
        {
            return dal.xg(name, id);
        }
        /// <summary>
        /// 根据业主名称，状态，缴费类型，查询缴费
        /// </summary>
        /// <returns></returns>
        public DataTable DopantALL(string name, string zt, string typename)
        {
            return dal.DopantALL(name,zt,typename);
        }

        public DataTable xs(int id)
        {
            return dal.xs(id);
        }

        public int xg(int id)
        {
            return dal.xg(id);
        }

    }
}
