using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class Repn_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();

        StringBuilder sb = new StringBuilder();

        public int repninsert(RepnMODEL repn)
        {
            sb.Clear();
            sb.AppendFormat("insert into Repn(RepnName,RepnNumber,RepnpDay,RepnPhone,RepnWhat,RepnPic,RepnState,ReppBool) values('{0}','{1}',getdate(),'{2}','{3}','{4}','待审核','未完成')", repn.RepnName1, repn.RepnNumber1, repn.RepnPhone1, repn.RepnWhat1, repn.RepnPic1);
            return db.ExecuteNonQuery(sb.ToString());

        }

        /// <summary>
        /// 修改审核状态
        /// </summary>
        /// <returns></returns>
        public int repn_upd(string id, string cz, string name)
        {
            sb.Clear();
            sb.AppendFormat("update Repn set repnstate = '{0}',ReppMan= '{1}' where ReID ='{2}'", cz, name, id);
            return db.ExecuteNonQuery(sb.ToString());
        }

        /// <summary>
        /// 通过id查看要审核的信息
        /// </summary>
        /// <returns></returns>
        public DataTable repn_WxShow(string id)
        {
            sb.Clear();
            sb.AppendLine("select * from Repn where ReID =" + id);
            return db.GetTable(sb.ToString());

        }

        /// <summary>
        /// 查看可以派出的维修人员
        /// </summary>
        /// <returns></returns>
        public DataTable repenWx()
        {
            sb.Clear();
            sb.AppendLine("select YgName from StfInfo where YgPos=2 and YgName not in(select ReppMan from Repn where ReppBool ='未完成' and RepnState = '已通过')");
            return db.GetTable(sb.ToString());
        }

        public DataTable sel(string number, string name)
        {
            sql.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID where RepnNumber like '%{0}%' or UserName like'%{1}%'", number, name);
            if (number==null&&name==null)
            {
                sql.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID "); 
            }
            return db.GetTable(sql.ToString());
        }

        public DataTable repnShow()//查询绑定
        {
            sb.Clear();
            sb.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID where RepnState ='待审核' order by RepnpDay desc");
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 查询维修完成状态
        /// </summary>
        /// <returns></returns>
        public DataTable repn_ReppBool(string phone)
        {
            sb.Clear();
            sb.AppendFormat("select *  from [dbo].[Repn] a join [dbo].[StfInfo] b on a.ReppMan = b.YgName where a.ReppBool = '未完成' and b.YgName = '{0}'", phone);
            return db.GetTable(sb.ToString());
        }

        public DataTable repnShow(string name, string shzt, string wczt)
        {
            sb.Clear();
            sb.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID where b.UserName like '%{0}%' and a.RepnState= '{1}' and ReppBool='{2}'", name, shzt, wczt);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 通过id查询审核信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable repn_shShow(string id)
        {
            sb.Clear();
            sb.AppendLine("select *  from [dbo].[Repn] a join [dbo].[UserInfo] b on a.RepnName = b.UserID where a.ReID =" + id);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 设置维修开始时间
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public int repn_starta(string id, string date)
        {
            sb.Clear();
            sb.AppendFormat("update [dbo].[Repn] set ReppDayk ='{0}' where ReID = '{1}'", date, id);
            return db.ExecuteNonQuery(sb.ToString());
        }

        /// <summary>
        /// 设置维修结束时间
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public int repn_end(string id, string date, string img)
        {
            sb.Clear();
            sb.AppendFormat("update [dbo].[Repn] set ReppDayj='{0}',ReppBool='已完成',ReppWcImg='{1}' where ReID = '{2}'", date, img, id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 根据名称查询维修
        /// </summary>
        /// <returns></returns>
        public DataTable repnSel(string name)
        {
            sb.Clear();
            sb.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID where UserName='{0}' ",name);
            return db.GetTable(sb.ToString());
        }
        public DataTable repnShow1(string name, string shzt, string wxzt)//查询绑定
        {
            sb.Clear();
            sb.AppendFormat("select * from Repn a join UserInfo b on a.RepnName = b.UserID where UserName='{0}' and RepnState='{1}' and  ReppBool='{2}'", name, shzt, wxzt);
            return db.GetTable(sb.ToString());
        }

    }
}
