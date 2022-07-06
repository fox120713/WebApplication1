using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class PayTypeDAL
    {
        DBHelper dbh = new DBHelper();
        StringBuilder sb = new StringBuilder();
        //绑定DropDownList1
        public DataTable bd()
        {
            sb.Clear();
            sb.AppendFormat("select * from PayType");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable bd(int id)
        {
            sb.Clear();
            sb.AppendFormat("select * from PayType where PayID=" + id);
            return dbh.GetTable(sb.ToString());
        }

        public DataTable cx(string lx)
        {
            sb.Clear();
            sb.AppendFormat("select * from PayType where PayName='{0}'" ,lx);
            return dbh.GetTable(sb.ToString());
        }

        public DataTable hq()
        {
            sb.Clear();
            sb.AppendFormat("select COUNT(*) from PayType");
            return dbh.GetTable(sb.ToString());
        }

        public int tj(PayTypeMODEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert PayType values('{0}','{1}')",a.PayName,a.Dj);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

        public int xg(double dj,int id)
        {
            sb.Clear();
            sb.AppendFormat("update PayType set dj='{0}' where PayID='{1}'", dj,id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

    }
}
