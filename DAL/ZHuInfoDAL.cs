using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;

namespace DAL
{
    public class ZHuInfoDAL
    {
        DBHelper dbh = new DBHelper();
       
        StringBuilder sb = new StringBuilder();

        public int jia(string name)
        {
            sb.Clear();
            sb.AppendFormat("update ZHuInfo set ZHMoney=ZHMoney+2000 where ZHName='{0}'", name);
            return dbh.ExecuteNonQuery(sb.ToString());
        }


        public DataTable sel(string id)
        {
            sb.Clear();
            sb.AppendFormat("select * from ZHuInfo where ZHId='{0}'", id);
            return dbh.GetTable(sb.ToString());

        }
        public DataTable selzh(int yzid) {
            sb.Clear();
            sb.AppendFormat("select * from zhuinfo where Yzid='{0}'",yzid);
            return dbh.GetTable(sb.ToString());
        
        }

        //显示数据
        public DataTable table()
        {
            sb.Clear();
            sb.AppendFormat("select * from ZHuInfo");
            return dbh.GetTable(sb.ToString());
        }

        //显示要充值的人的信息
        public DataTable table(string id)
        {
            sb.Clear();
            sb.AppendFormat("select * from ZHuInfo where ZHId="+id);
            return dbh.GetTable(sb.ToString());
        }

        //充值
        public int xg(double money,string id)
        {
            sb.Clear();
            sb.AppendFormat("update ZHuInfo set ZHMoney=ZHMoney+'{0}' where ZHId='{1}'",money,id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 根据水电费缴费金额扣除账户钱
        /// </summary>
        /// <returns></returns>
        public int jian(double money, string name)
        {
            sb.Clear();
            sb.AppendFormat("update ZHuInfo set ZHMoney=ZHMoney-'{0}' where ZHName='{1}'", money, name);
            return dbh.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 根据账户名查金额
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable cxMoney(string name)
        {
            sb.Clear();
            sb.AppendFormat("select ZHMoney from ZHuInfo where ZHName='{0}'", name);
            return dbh.GetTable(sb.ToString());
        }
       /// <summary>
       /// 根据账户id查询金额
       /// </summary>
       /// <param name="money"></param>
       /// <param name="name"></param>
       /// <returns></returns>
        public DataTable cxMoney1(string zhid) {
            sb.Clear();
            sb.AppendFormat("select * from ZHuInfo where ZHId='{0}'",zhid);
            return dbh.GetTable(sb.ToString());
        
        
        
        
        
        }

        public int x(double money, string name)
        {
            sb.Clear();
            sb.AppendFormat("update ZHuInfo set ZHMoney=ZHMoney-'{0}' where ZHName='{1}'", money, name);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

        public int insert(ZHMODEL zh) {
            sb.Clear();
            sb.AppendFormat(@"INSERT INTO [PRO].[dbo].[ZHuInfo] ([ZHId] ,[ZHName] ,[ZHType] ,[ZHMoney] ,[ZHDate] ,[Yzid]  VALUES('{0}','{1}',现金账户',0,getdate(),'{2}')",zh.Zhid,zh.Zhname,zh.Zhtype,zh.Zhmoney,zh.Zhdate,zh.Yzid);
            return dbh.ExecuteNonQuery(sb.ToString());
        
        }

    }
}
