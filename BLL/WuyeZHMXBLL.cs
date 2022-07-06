using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using MODEL;
namespace BLL
{
   public class WuyeZHMXBLL
    {
       WuyeZHMXDAL dal = new WuyeZHMXDAL();
       /// <summary>
       /// 押金入账
       /// </summary>
       /// <param name="mph">门牌号</param>
       /// <returns></returns>
       public int insYaJin(string mph)
       {
           return dal.insYaJin(mph);
       }
       /// <summary>
       /// 查询拨款记录
       /// </summary>
       /// <returns></returns>
       public DataTable WuyeSel() {
           return dal.WuyeSel();
       }
        /// <summary>
       /// 根据办理人查询记录
       /// </summary>
       /// <returns></returns>
       public DataTable WuyeSel(string blr)
       {
           return dal.WuyeSel(blr);
       
       
       }
       public DataTable months()
       {
           return dal.months();
       }

       public DataTable selall()
       {
           return dal.selall();
       }

       public DataTable summoney()
       {
           return dal.summoney();
       }

       public DataTable outmoney()
       {
           return dal.outmoney();
       }

       public DataTable selyue(int yue)
       {
           return dal.selyue(yue);
       }
       public DataTable seloutyue(int yue)
       {
           return dal.seloutyue(yue);

       }
       public int insercar(WuyeZHMX wuye)
       {
           return dal.insercar(wuye);
       }
       public int insertbk(WuyeZHMX bokuan)
       {
           return dal.insertbk(bokuan);
       }

       public DataTable table()
       {
           return dal.table();
       }

       public DataTable table(int a)
       {
           return dal.table(a);
       }

       public DataTable srq()
       {
           return dal.srq();
       }

       public DataTable srbq(int a)
       {
           return dal.srbq(a);
       }

       public DataTable qxck(string name)
       {
           return dal.qxck(name);
       }

       public DataTable zcsrcx(int a)
       {
           return dal.zcsrcx(a);
       }

       public DataTable zcsrcx()
       {
           return dal.zcsrcx();
       }

       public DataTable zcq()
       {
           return dal.zcq();
       }

       public DataTable zcbq(int a)
       {
           return dal.zcbq(a);
       }

       public DataTable qb()
       {
           return dal.qb();
       }

       public DataTable qb(string mp)
       {
           return dal.qb(mp);
       }

       public DataTable bd()
       {
           return dal.bd();
       }

       public DataTable yf(int a, string mp)
       {
           return dal.yf(a, mp);
       }

       public DataTable zje()
       {
           return dal.zje();
       }

       public DataTable yje(int a)
       {
           return dal.yje(a);
       }
       /// <summary>
       /// 添加退款备注
       /// </summary>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int insYaJinBZ(string mph)
       {
           return dal.insYaJinBZ(mph);
       }

       public DataTable ayf(int a)
       {
           return dal.ayf(a);
       }

       public DataTable ayf1(int a)
       {
           return dal.ayf1(a);
       }

    }
}
