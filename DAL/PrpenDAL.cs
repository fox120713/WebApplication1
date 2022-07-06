using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;

namespace DAL
{
    public class PrpenDAL
    {
        DBHelper db = new DBHelper();
        public DataTable PrepnShow()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Prepn where PrIstate='待审核' order by PrsDate desc");
            return db.GetTable(sb.ToString());
        }


        public int Prepn_Add(PrepnModel prepn)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("insert into Prepn(Prsite,PrCon,Primg,PrsDate,Prphone,PrIstate,PrState,Prsqr) values('{0}','{1}','{2}','{3}','{4}','待审核','未完成','{5}')", prepn.Prsite, prepn.PrCon, prepn.Primg, prepn.Prsdate1, prepn.Prphone, prepn.Prsqr);
            return db.ExecuteNonQuery(sb.ToString());
        }


        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cz"></param>
        /// <param name="wxr"></param>
        /// <returns></returns>
        public int shenhe(string id, string cz, string wxr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("  update [dbo].[Prepn] set PrIstate ='{0}',PrWxr ='{1}'where PrID='{2}'", cz, wxr, id);
            return db.ExecuteNonQuery(sb.ToString());
        }

        /// <summary>
        /// 设置维修结束时间
        /// </summary>
        /// <param name="date"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Prpen_date_end(string date, string img, string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update [dbo].[Prepn] set PrjDate = '{0}',PrState='已完成',PrPic = '{1}' where PrID = '{2}'", date, img, id);
            return db.ExecuteNonQuery(sb.ToString());
        }


        /// <summary>
        /// 查询维修完成状态
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public DataTable Prpen_PrState(string phone)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select *  from [dbo].[Prepn]  a join [dbo].[StfInfo] b on a.PrWxr = b.YgName where a.PrState = '未完成' and b.YgName ='{0}'", phone);
            return db.GetTable(sb.ToString());
        }

        public DataTable PrepnSelShow(string priste, string PrIstate, string PrState)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from [dbo].[Prepn] where Prsite = '{0}' and PrIstate ='{1}' and PrState = '{2}'", priste, PrIstate, PrState);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 通过id查审核情况
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable ggshShow(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from [dbo].[Prepn] where PrID = '{0}'", id);
            return db.GetTable(sb.ToString());
        }


        /// <summary>
        /// 设置维修开始时间
        /// </summary>
        /// <returns></returns>
        public int Prpen_date_start(string date, string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update [dbo].[Prepn] set PrkDate = '{0}'where PrID = '{1}'", date, id);
            return db.ExecuteNonQuery(sb.ToString());
        }

        public DataTable Prepn_wxr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select YgName from StfInfo where YgPos=2 and YgName not in(select PrWxr from Prepn where PrState ='未完成' and PrIstate='已通过') ");
            return db.GetTable(sb.ToString());
        }

    }
}
