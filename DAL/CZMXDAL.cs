using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;
namespace DAL
{
   public class CZMXDAL
    {
       DBHelper db = new DBHelper();
       StringBuilder sb = new StringBuilder();
       /// <summary>
       /// 添加一条充值记录
       /// </summary>
       /// <returns></returns>
       public int czinsert(CZMXModel czmodel) {
           sb.Clear();
           sb.AppendFormat("insert into CZMX values('{0}',MONTH(GETDATE()),{1},GETDATE(),'{2}','充值')",czmodel.Yzid,czmodel.Czje,czmodel.Mph);
          return  db.ExecuteNonQuery(sb.ToString());
       }
       /// <summary>
       ///根据业主id查询缴费充值记录
       /// </summary>
       /// <returns></returns>
       public DataTable czsel(int id) {
           sb.Clear();
           sb.AppendFormat("select *from CZMX where Yzid='{0}'",id);
           return db.GetTable(sb.ToString());
       
       
       }
       /// <summary>
       /// 缴费充值记录月份
       /// </summary>
       /// <returns></returns>
       public DataTable months() {
           sb.Clear();
           sb.AppendFormat("select distinct Months  from CZMX ");
           return db.GetTable(sb.ToString());
       
       }
       /// <summary>
       ///根据业主id和月份查询缴费充值记录
       /// </summary>
       /// <returns></returns>
       public DataTable czsel(int id,string mo)
       {
           sb.Clear();
           sb.AppendFormat("select *from CZMX where Yzid='{0}' and Months='{1}'",id,mo);
           return db.GetTable(sb.ToString());


       }
       /// <summary>
       /// 退款到账记录
       /// </summary>
       /// <param name="userid"></param>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int tuikuancz(string userid, string mph)
       {
           sb.Clear();
           sb.AppendFormat("insert into CZMX values('{0}',MONTH(GETDATE()),'2000',GETDATE(),'{1}','押金退款')", userid, mph);
           return db.ExecuteNonQuery(sb.ToString());
       }
    }
}
