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
    public class ParkDAL
    {
        DBHelper dbh = new DBHelper();
        StringBuilder sb = new StringBuilder();
        public DataTable tcfcx()
        {
            sb.Clear();
            sb.AppendLine("select * from Park");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable tcfcx(int id)
        {
            sb.Clear();
            sb.AppendLine("select * from Park where ParkID="+id);
            return dbh.GetTable(sb.ToString());
        }

        public DataTable tcfzt()
        {
            sb.Clear();
            sb.AppendLine("select distinct Parkbool from Park");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable tcfcx(string zt, string cph)
        {
            sb.Clear();
            sb.AppendFormat("select * from Park where ParkNum ='{0}' or Parkbool='{1}'", cph, zt);
            return dbh.GetTable(sb.ToString());
        }

        public int tj(int cwh,string cph,DateTime a)
        {
            sb.Clear();
            sb.AppendFormat("insert Park(L_CarID,ParkNum,IntoTime) values('{0}','{1}','{2}')", cwh,cph,a);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

        public DataTable cx(ParkMODEL a)
        {
            sb.Clear();
            sb.AppendLine("select * from Park");
            if (a.ParkNum != "" && a.Parkbool != "全部")
            {
                sb.AppendFormat(" where ParkNum ='{0}' and Parkbool='{1}'", a.ParkNum, a.Parkbool);
            }
            else if (a.ParkNum != "")
            {
                sb.AppendFormat(" where ParkNum ='{0}'", a.ParkNum);
            }
            else if (a.Parkbool != "全部")
            {
                sb.AppendFormat(" where Parkbool='{0}'", a.Parkbool);
            }
            return dbh.GetTable(sb.ToString());
        }

        public int xg(DateTime a,double money, int id)
        {
            sb.Clear();
            sb.AppendFormat("update Park set OutTime='{0}',ParkMoney='{1}',Parkbool='已缴费' where ParkID='{2}'", a, money, id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

    }
}
