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
    public class PurpDAL
    {
        DBHelper dbh = new DBHelper();
        StringBuilder sb = new StringBuilder();

        public DataTable table()
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable tb()
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurIstate != '未通过'");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable table(int id)
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurpID='{0}'", id);
            return dbh.GetTable(sb.ToString());
        }
        public DataTable tableDSH()
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurIstate='待审核'");
            return dbh.GetTable(sb.ToString());
        }
        public DataTable bd1()
        {
            sb.Clear();
            sb.AppendFormat("select distinct PurIstate from Purp");
            return dbh.GetTable(sb.ToString());
        }

        public DataTable cx(string name, DateTime sj, string zt)
        {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurpName='{0}' or PurpDate='{1}' or PurIstate='{2}' ");
            return dbh.GetTable(sb.ToString());
        }

        //查询采购记录
        public DataTable cx(string name, string zt)
        {
            sb.Clear();
            if (name == "" && zt == "全部")
            {
                sb.AppendLine("select * from Purp");
            }
            else if (name != "" && zt != "全部")
            {
                sb.AppendFormat("select * from Purp where PurpName='{0}'  and PurIstate='{1}'", name, zt);
            }
            else if (name != "")
            {
                sb.AppendFormat("select * from Purp where PurpName='{0}'", name);
            }
            else
            {
                sb.AppendFormat("select * from Purp where PurIstate='{0}'", zt);
            }
            return dbh.GetTable(sb.ToString());
        }


        //添加采购记录
        public int tj(PurpDOMEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert Purp(PurpName,PurpImg,PurpNumber,PurPrice,PurpSum,PurpAccount,PurSqr) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", a.PurpName, a.PurpImg, a.PurpNumber, a.PurPrice, a.PurpSum, a.PurpAccount, a.PurSqr);
            return dbh.ExecuteNonQuery(sb.ToString());
        }
        //查询采购记录
        public DataTable cx(string zt)
        {
            sb.Clear();
            if ( zt == "全部")
            {
                sb.AppendLine("select * from Purp");
            }
            else
            {
                sb.AppendFormat("select * from Purp where PurIstate='{0}'", zt);
            }
            return dbh.GetTable(sb.ToString());
        }
        public int update(int id)
        {
            sb.Clear();
            sb.AppendFormat(" update Purp set PurIstate='已通过',PurpDate=getdate() where PurpID={0}", id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }
        public int update3(int id)
        {
            sb.Clear();
            sb.AppendFormat(" update Purp set PurIstate='未通过',PurpDate=getdate() where PurpID={0}", id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

        public int xg(int id)
        {
            sb.Clear();
            sb.AppendFormat(" update Purp set bkzt='已拨款' where PurpID={0}", id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }
        public DataTable seljl(int id) {
            sb.Clear();
            sb.AppendFormat("select * from Purp where PurpID='{0}'",id);
            return dbh.GetTable(sb.ToString());
        
        
        }
        /// <summary>
        /// 修改采购审批状态和原因
        /// </summary>
        /// <param name="yy"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int update3(string yy, int id)
        {
            sb.Clear();
            sb.AppendFormat(" update Purp set PurIstate='未通过',PurpDate=getdate(),PurpYY='{0}' where PurpID='{1}'",yy, id);
            return dbh.ExecuteNonQuery(sb.ToString());
        }

    }
}
