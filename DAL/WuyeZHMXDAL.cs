using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;
namespace DAL
{
   public class WuyeZHMXDAL
    {
       DBHelper db = new DBHelper();
       StringBuilder sql = new StringBuilder();
       StringBuilder sb = new StringBuilder();
       public int insYaJin(string mph)
       {
           sql.Clear();
           sql.AppendFormat("insert into WuyeZHMX(Zdly,PayName,dates,Zdmoney,months) values('{0}','押金',GETDATE(),'2000', MONTH(GETDATE()))", mph);
           return db.ExecuteNonQuery(sql.ToString());
       }
       /// <summary>
       /// 查询拨款记录
       /// </summary>
       /// <returns></returns>
       public DataTable WuyeSel() {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where payName='拨款'");
           return db.GetTable(sb.ToString());
       }
       /// <summary>
       /// 根据办理人查询记录
       /// </summary>
       /// <returns></returns>
       public DataTable WuyeSel(string blr)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where payName='拨款' and blr='{0}'",blr);
           return db.GetTable(sb.ToString());
       }

       public DataTable months()
       {
           sql.Clear();
           sql.AppendLine("select distinct(months)as yue,CASE WHEN months = 1 THEN '一月'  WHEN months = 2 THEN '二月'  WHEN months = 3 THEN '三月'   WHEN months = 4 THEN '四月' end as xs from WuyeZHMX ");
           return db.GetTable(sql.ToString());
       }

       public DataTable selall()
       {
           sql.Clear();
           sql.AppendLine("select * from WuyeZHMX ");
           return db.GetTable(sql.ToString());       
       }


       public DataTable summoney()
       {
           sql.Clear();
           sql.AppendLine("select SUM(Zdmoney) from WuyeZHMX where PayName in('缴费','停车费','买车位','押金') and BeiZhu is null");
           return db.GetTable(sql.ToString());
       }

       public DataTable outmoney()
       {
           sql.Clear();
           sql.AppendLine("select SUM(Zdmoney) from WuyeZHMX where PayName in('拨款','押金') and BeiZhu is not null");
           return db.GetTable(sql.ToString());
       }

       public DataTable selyue(int yue)
       {
           sql.Clear();
           if (yue == 0)
           {
               sql.AppendLine("select * from WuyeZHMX where PayName in('缴费','停车费','买车位','押金') and BeiZhu is null");
           }
           sql.AppendLine("select * from WuyeZHMX where PayName in('缴费','停车费','买车位','押金') and BeiZhu is null and months=" + yue);
           return db.GetTable(sql.ToString());
       }

       public DataTable seloutyue(int yue)
       {
           sql.Clear();
           if (yue==0)
           {
           sql.AppendLine("select * from WuyeZHMX where PayName in('拨款','押金') and BeiZhu is not null");
               
           }
           sql.AppendLine("select * from WuyeZHMX where PayName in('拨款','押金') and BeiZhu is not null and months=" + yue);
           return db.GetTable(sql.ToString());
       }
       public int insercar(WuyeZHMX wuye)
       {
           sql.Clear();
           sql.AppendFormat("insert into WuyeZHMX(Zdly,PayName,dates,Zdmoney,months) values('{0}','{1}','{2}','{3}','{4}')", wuye.Zdly1, wuye.PayName1, wuye.Dates, wuye.Zdmoney1, wuye.Months);
           return db.ExecuteNonQuery(sql.ToString());
       }
       public int insertbk(WuyeZHMX bokuan)
       {
           sql.Clear();
           sql.AppendFormat("insert into WuyeZHMX (Zdly,PayName,dates,Zdmoney,BeiZhu,months,Blr)values('{0}','拨款',GETDATE(),'{1}','{2}',MONTH(GETDATE()),'{3}')", bokuan.Zdly1, bokuan.Zdmoney1, bokuan.BeiZhu1, bokuan.Blr);
           return db.ExecuteNonQuery(sql.ToString());
       }

       public DataTable table()
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where BeiZhu is null");
           return db.GetTable(sb.ToString());
       }

       public DataTable table(int a)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where BeiZhu is null and months='{0}'", a);
           return db.GetTable(sb.ToString());
       }

       public DataTable ayf(int a)
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where months="+a);
           return db.GetTable(sb.ToString());
       }

       public DataTable ayf1(int a)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where months='{0}'",a);
           return db.GetTable(sb.ToString());
       }

       public DataTable srq()
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where BeiZhu is null");
           return db.GetTable(sb.ToString());
       }

       public DataTable srbq(int a)
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where BeiZhu is null and months='{0}'", a);
           return db.GetTable(sb.ToString());
       }

       public DataTable qxck(string name)
       {
           sb.Clear();
           sb.AppendFormat("select mxid,UserName,months,PayName,Syd,Byd,YDdj,dateMoney from JfMx join UserInfo on UserInfo.UserCell=JfMx.UserCell where UserInfo.UserCell='{0}'", name);
           return db.GetTable(sb.ToString());
       }

       public DataTable zcsrcx()
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where BeiZhu is not null");
           return db.GetTable(sb.ToString());
       }

      

       public DataTable zcsrcx(int a)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where BeiZhu is not null and months='{0}'", a);
           return db.GetTable(sb.ToString());
       }

       public DataTable zcq()
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where BeiZhu is not null");
           return db.GetTable(sb.ToString());
       }

       public DataTable zcbq(int a)
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where BeiZhu is not null and months='{0}'", a);
           return db.GetTable(sb.ToString());
       }

       public DataTable qb()
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX ");
           return db.GetTable(sb.ToString());
       }

       public DataTable qb(string mp)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where Zdly='{0}'", mp);
           return db.GetTable(sb.ToString());
       }

       public DataTable bd()
       {
           sb.Clear();
           sb.AppendFormat("select distinct(months) +'月' yf from WuyeZHMX ");
           return db.GetTable(sb.ToString());
       }

       public DataTable yf(int a, string mp)
       {
           sb.Clear();
           sb.AppendFormat("select * from WuyeZHMX where months='{0}' and Zdly='{1}'", a, mp);
           return db.GetTable(sb.ToString());
       }

       public DataTable zje()
       {
           sb.Clear();
           sb.AppendFormat(" select SUM(Zdmoney) from WuyeZHMX");
           return db.GetTable(sb.ToString());
       }

       public DataTable yje(int a)
       {
           sb.Clear();
           sb.AppendFormat("select SUM(Zdmoney) from WuyeZHMX where months='{0}'", a);
           return db.GetTable(sb.ToString());
       }
       /// <summary>
       /// 添加退款备注
       /// </summary>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int insYaJinBZ(string mph)
       {
           sql.Clear();
           sql.AppendFormat("insert into WuyeZHMX(Zdly,PayName,dates,Zdmoney,months,BeiZhu) values('{0}','押金',GETDATE(),2000,MONTH(GETDATE()),'退款')", mph);
           return db.ExecuteNonQuery(sql.ToString());
       }


    }
}
