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
    public class YgBLL
    {
        YgKqDAL dal = new YgKqDAL();
        public DataTable YgKqALL()
        {
            return dal.YgKqALL();
        }

        public DataTable YgKqALL(int id)
        {
            return dal.YgKqALL(id);

        }

        /// <summary>
        /// 员工考勤汇总
        /// </summary>
        /// <returns></returns>
        public DataTable YGKqSum()
        {
            return dal.YGKqSum();
        }

        public DataTable YGKqSum(string name, string zt, int bm)
        {
            return dal.YGKqSum(name, zt, bm);

        }
        /// <summary>
        /// 查询考勤表里的年份
        /// </summary>
        /// <returns></returns>
        public DataTable kqYear() {
            return dal.kqYear();
        
        
        
        }
        public int tj(YgKqMODEL a)
        {
            return dal.tj(a);
        }
        public DataTable cx(string name, string zt,string sj)
        {
            return dal.cx(name, zt,sj);
        }
        public DataTable bd()
        {
            return dal.bd();
        }
        public DataTable cx(string name)
        {
            return dal.cx(name);
        }

        public DataTable xz(string name, int y, int m, int d)
        {
            return dal.xz(name, y,m,d);
        }


       /// <summary>
        /// 根据打卡时间查询信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sj"></param>
        /// <returns></returns>
        public DataTable kqcx(int id, string sj) {
            return dal.kqcx(id, sj);
        
        
        }

    }
}
