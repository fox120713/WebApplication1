using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MODEL;

namespace DAL
{
   public class jfhzDAL
    {
        DBHelper db = new DBHelper();
        StringBuilder sb = new StringBuilder();
        public DataTable table(string ld)
        {
            sb.Clear();
            sb.AppendFormat("select * from JfHz where HzLD='{0}'",ld);
            return db.GetTable(sb.ToString());
        }

        public DataTable table(string ld,string yf)
        {
            sb.Clear();
            sb.AppendFormat("select * from JfHz where HzLD='{0}' and Months='{1}'", ld,yf);
            return db.GetTable(sb.ToString());
        }

        public DataTable bd()
        {
            sb.Clear();
            sb.AppendFormat("select distinct (Months)+'月' yf from JfHz");
            return db.GetTable(sb.ToString());
        }

        public DataTable ss(string ld,string yf)
        {
            sb.Clear();
            sb.AppendFormat("select SUM(dateMoney) from JfMx where UserCell='{0}' and months='{1}'",ld,yf);
            return db.GetTable(sb.ToString());
        }

        public DataTable syjy(string ld, string yf)
        {
            sb.Clear();
            sb.AppendFormat("select * from JfHz where HzLD='{0}' and months='{1}'", ld, yf);
            return db.GetTable(sb.ToString());
        }

        public int tj(jfhzMODEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert JfHz values('{0}','{1}','{2}','{3}','{4}')",a.HzLD1,a.Months1,a.Summoney,a.SJyu1,a.Byyu1);
            return db.ExecuteNonQuery(sb.ToString());
        }
    }
}
