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
    public class PurpBLL
    {
        PurpDAL dal = new PurpDAL();
        public DataTable table()
        {
            return dal.table();
        }
        public DataTable tb()
        {
            return dal.tb();
        }
        public DataTable table(int id)
        {
            return dal.table(id);
        }

        public DataTable bd1()
        {
            return dal.bd1();
        }
        public DataTable tableDSH()
        {
            return dal.tableDSH();


        }

        public DataTable cx(string name, DateTime sj, string zt)
        {
            return dal.cx(name, sj, zt);
        }

        //查询采购记录
        public DataTable cx(string name, string zt)
        {
            return dal.cx(name, zt);
        }

        public int tj(PurpDOMEL a)
        {
            return dal.tj(a);
        }
        //查询采购记录
        public DataTable cx(string zt)
        {
            return dal.cx(zt);
        }
        public int update(int id) {
            return dal.update(id);
        }
        public int update3(int id)
        {
            return dal.update3(id);
        }

        public int xg(int id)
        {
            return dal.xg(id);
        }
        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable seljl(int id) {
            return dal.seljl(id);
        
        }
                /// <summary>
        /// 修改采购审批状态和原因
        /// </summary>
        /// <param name="yy"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int update3(string yy, int id)
        {
            return dal.update3(yy, id);
        
        }
    }
}
