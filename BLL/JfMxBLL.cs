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
   public class JfMxBLL
    {
       JfMxDAL dal = new JfMxDAL();
       /// <summary>
      /// 根据门牌号查询缴费记录
      /// </summary>
      /// <returns></returns>
       public DataTable selJFMx(string cell) {
           return dal.selJFMx(cell);
       
       }
       public DataTable sum(string cell) {
           return dal.sum(cell);
       
       }
       /// <summary>
      /// 查询缴费明细表月份
      /// </summary>
      /// <returns></returns>
       public DataTable selMoths() {
           return dal.selMoths();
       
       }
      /// <summary>
      /// 查询缴费明细年份
      /// </summary>
      /// <returns></returns>
       public DataTable selYear() {
           return dal.selYear();
       
       
       }
       /// <summary>
      /// 根据门牌号,月份，类型，查询缴费记录
      /// </summary>
      /// <returns></returns>
       public DataTable selJFMx(string cell, string lx, string months)
       {
           return dal.selJFMx(cell, lx, months);
       
       
       
       }
       /// <summary>
      /// 查询每个月的消费总和
      /// </summary>
      /// <returns></returns>
       public DataTable selsum(string cell, string lx, string months)
       {
           return dal.selsum(cell,lx,months);
       }

       public DataTable bd()
       {
           return dal.bd();
       }

       public DataTable bd(string lx)
       {
           return dal.bd(lx);
       }

       public DataTable syyd(string ld, string lx, string yf)
       {
           return dal.syyd(ld, lx, yf);
       }
       public DataTable fwlx(string ld)
       {
           return dal.fwlx(ld);
       }

       public int tj(JfMxMODEL a)
       {
           return dal.tj(a);
       }
       public DataTable table()
       {
           return dal.table();
       }

       public DataTable table(string ld)
       {
           return dal.table(ld);
       }

       public DataTable bdyf()
       {
           return dal.bdyf();
       }

       public DataTable yf(string m, string ld)
       {
           return dal.yf(m, ld);
       }
       public int tj1(JfMxMODEL c)
       {
           return dal.tj1(c);
       }

    }
}
