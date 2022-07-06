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
    public class AppDAL
    {
        DBHelper dbh = new DBHelper();
        StringBuilder sb = new StringBuilder();
        public DataTable table()
        {
            sb.Clear();
            sb.AppendFormat("select AppID,PosName,AppReason,AppTime,AppMoney,APPName from App join Pos on App.AppDepartment=Pos.PosID");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable bd()
        {
            sb.Clear();
            sb.AppendFormat("select distinct YEAR(AppTime) sj from App ");
            return dbh.GetTable(sb.ToString());
        }
        public DataTable bd(int n)
        {
            sb.Clear();
            sb.AppendFormat("select distinct month(AppTime) yf from App where AppTime like '%{0}%'",n);
            return dbh.GetTable(sb.ToString());
        }

        public DataTable mxcx(int id, double money)
        {
            sb.Clear();
            sb.AppendFormat("select AppID,PosName,AppReason,AppTime,AppMoney,APPName from App join Pos on App.AppDepartment=Pos.PosID where Pos.PosID='{0}' or AppMoney='{1}'", id, money);
            return dbh.GetTable(sb.ToString());
        }

        //添加拨款记录
        public int tj(AppMODEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert App values('{0}','{1}','{2}','{3}','{4}')",a.AppDepartment, a.AppReason, a.AppTime, a.AppMoney, a.AppName);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

        //查询拨款记录
        public DataTable mxcx(string blr,string n,string y)
        {
            sb.Clear();
            if (blr == "" && n != "" && y != "")
            {
                sb.AppendFormat("select AppID,PosName,AppReason,AppTime,AppMoney,APPName from App join Pos on App.AppDepartment=Pos.PosID where YEAR(AppTime) like '%{0}%' and MONTH(AppTime) like '%{1}%' ", n,y);
            }
            else if (blr != "" && n != "" && y != "")
            {
                sb.AppendFormat("select AppID,PosName,AppReason,AppTime,AppMoney,APPName from App join Pos on App.AppDepartment=Pos.PosID where APPName='{0}' and YEAR(AppTime) like '%{1}%' and MONTH(AppTime) like '%{2}%'", blr, n,y);
            }
            return dbh.GetTable(sb.ToString());
        }
        public DataTable xs(int id)
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurpID='{0}'", id);
            return dbh.GetTable(sb.ToString());
        }
    }
}
