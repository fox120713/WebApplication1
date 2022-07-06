using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;
namespace DAL
{
  public class JfMxDAL
    {
      DBHelper db = new DBHelper();
      StringBuilder sb = new StringBuilder();
      /// <summary>
      /// 根据门牌号查询缴费记录
      /// </summary>
      /// <returns></returns>
      public DataTable selJFMx(string cell) {
          sb.Clear();
          sb.AppendFormat("select * from JfMx where UserCell='{0}'",cell);
          return db.GetTable(sb.ToString());
      
      }
      /// <summary>
      /// 查询缴费明细表月份
      /// </summary>
      /// <returns></returns>
      public DataTable selMoths() {
          sb.Clear();
          sb.AppendFormat("select distinct months from JfMx");
          return db.GetTable(sb.ToString());
      
      }
      /// <summary>
      /// 查询缴费明细年份
      /// </summary>
      /// <returns></returns>
      public DataTable selYear() {
          sb.Clear();
          sb.AppendFormat("select distinct SUBSTRING(months,1,4)as year from JfMx order by year asc");
          return db.GetTable(sb.ToString());
      
      
      }
      /// <summary>
      /// 根据门牌号,月份，类型，查询缴费记录
      /// </summary>
      /// <returns></returns>
      public DataTable selJFMx(string cell,string lx,string months)
      {

          sb.Clear();
          if (lx=="全部"&&months=="全部-全部")
          {
              sb.AppendFormat("select * from JfMx where UserCell='{0}'", cell);
          }
          else if (lx != "全部" && months == "全部-全部")
          {
             
              sb.AppendFormat("select * from JfMx where UserCell='{0}' and PayName='{1}'", cell,lx);
          }
          else if (lx == "全部" && months != "全部-全部")
          {
              sb.AppendFormat("select * from JfMx where UserCell='{0}' and months='{1}'",cell,months);
          }
          else if (lx != "全部" && months != "全部-全部")
          {
              sb.AppendFormat("select * from JfMx where UserCell='{0}' and PayName='{1}' and months='{2}'",cell,lx,months);
          }
          return db.GetTable(sb.ToString());

      }
      /// <summary>
      /// 查询每个月的消费总和
      /// </summary>
      /// <returns></returns>
      public DataTable selsum(string cell, string lx, string months)
      {
          sb.Clear();
          if (lx == "全部" && months == "全部-全部")
          {
              sb.AppendFormat("select SUM(dateMoney)as hj from JfMx where UserCell='{0}'", cell);
          }
          else if (lx != "全部" && months == "全部-全部")
          {

              sb.AppendFormat("select SUM(dateMoney)as hj from JfMx where UserCell='{0}' and PayName='{1}'", cell, lx);
          }
          else if (lx == "全部" && months != "全部-全部")
          {
              sb.AppendFormat("select SUM(dateMoney)as hj from JfMx where UserCell='{0}' and months='{1}'", cell, months);
          }
          else if (lx != "全部" && months != "全部-全部")
          {
              sb.AppendFormat("select SUM(dateMoney)as hj from JfMx where UserCell='{0}' and PayName='{1}' and months='{2}'", cell, lx, months);
          }
          return db.GetTable(sb.ToString());
      }
      public DataTable sum(string cell) {
          sb.Clear();
          sb.AppendFormat("select SUM(dateMoney)as hj from JfMx where UserCell='{0}'", cell);
          return db.GetTable(sb.ToString());
      
      
      
      }
      public DataTable bd()
      {
          sb.Clear();
          sb.AppendFormat("select * from PayType");
          return db.GetTable(sb.ToString());
      }

      public DataTable bd(string lx)
      {
          sb.Clear();
          sb.AppendFormat("select dj from PayType where PayName='{0}'", lx);
          return db.GetTable(sb.ToString());
      }

      public DataTable syyd(string ld, string lx, string yf)
      {
          sb.Clear();
          sb.AppendFormat("select * from JfMx where UserCell='{0}' and PayName='{1}' and months='{2}'", ld, lx, yf);
          return db.GetTable(sb.ToString());
      }

      public DataTable fwlx(string ld)
      {
          sb.Clear();
          sb.AppendFormat("select * from JfMx where UserCell='{0}'", ld);
          return db.GetTable(sb.ToString());
      }

      public int tj(JfMxMODEL a)
      {
          sb.Clear();
          sb.AppendFormat("insert JfMx values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", a.UserCell1, a.Months, a.PayName1, a.Syd1, a.Byd, a.Yddj1, a.DateMoney, a.Home, a.Fwmj);
          return db.ExecuteNonQuery(sb.ToString());
      }

      public DataTable table()
      {
          sb.Clear();
          sb.AppendFormat("select * from JfMx");
          return db.GetTable(sb.ToString());
      }

      public DataTable table(string ld)
      {
          sb.Clear();
          sb.AppendFormat("select * from JfMx where UserCell='{0}'", ld);
          return db.GetTable(sb.ToString());
      }

      public DataTable bdyf()
      {
          sb.Clear();
          sb.AppendFormat("select distinct months from JfMx ");
          return db.GetTable(sb.ToString());
      }

      public DataTable yf(string m, string ld)
      {
          sb.Clear();
          sb.AppendFormat("select * from JfMx where months='{0}' and UserCell='{1}' ", m, ld);
          return db.GetTable(sb.ToString());
      }
      public int tj1(JfMxMODEL c)
      {
          sb.Clear();
          sb.AppendFormat("insert JfMx(UserCell,months,PayName,Yddj,dateMoney,home,fwmj) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", c.UserCell1, c.Months, c.PayName1, c.Yddj1, c.DateMoney, c.Home, c.Fwmj);
          return db.ExecuteNonQuery(sb.ToString());
      }

    }
}
