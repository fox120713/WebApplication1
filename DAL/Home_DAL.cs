using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
namespace DAL
{
    public class Home_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();

        public DataTable sel()//查询绑定
        {
            sql.Clear();
            sql.AppendLine("select hometype as 房屋类型 ,COUNT(*) as 房屋数量 from Home group by hometype");
            return db.GetTable(sql.ToString());
        }

        public DataTable sel( string type)
        {
            sql.Clear();
            sql.AppendFormat("select hometype as 房屋类型 ,COUNT(*) as 房屋数量 from Home where hometype like '%{0}%' group by hometype ", type);
            return db.GetTable(sql.ToString());
        }

        public DataTable sellx(string type)//查询类型，绑定
        {
            sql.Clear();
            sql.AppendFormat("select * from Home where hometype = '{0}'", type);
            return db.GetTable(sql.ToString());
        }

        public int del(string mp)//空房间删除
        {
            sql.Clear();
            sql.AppendFormat("delete from Home where homenumber='{0}'",mp);
            return db.ExecuteNonQuery(sql.ToString());
        }

    }
}
