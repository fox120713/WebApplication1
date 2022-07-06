using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;
namespace DAL
{
    public class RepnnDAL
    {
        DBHelper db = new DBHelper();



        public int xg(DateTime a, int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("update Repnn set RepnnPDays='{0}',Repnzt='已完成',Moneyzt='已退' where RepnnID='{1}'", a, id);
            return db.ExecuteNonQuery(sb.ToString());

        }
        /// <summary>
        /// 更改状态为审核未通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updshw(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set Repnzt='审核未通过' where RepnnID='{0}'", id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 更改状态为进行中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updsh(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set Repnzt='进行中' where RepnnID='{0}'", id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 装修申请添加
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mph"></param>
        /// <returns></returns>
        public int Repnntj(int id, string mph, string img)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO [PRO].[dbo].[Repnn]([UserID],[UserCell],[RepnnpDay],[RepnnMoney],[Repnzt],[Moneyzt],[ztSpimg]) VALUES('{0}','{1}',GETDATE(),2000,'待审核','未退','{2}')", id, mph, img);
            return db.ExecuteNonQuery(sb.ToString());

        }

        /// <summary>
        /// 查询能验收的人
        /// </summary>
        /// <returns></returns>
        public DataTable SelYsl(string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from Repnn where Repnzt ='验收中' and ztspr ='{0}'", name);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 派遣验收人
        /// </summary>
        /// <param name="id"></param>
        /// <param name="spr"></param>
        /// <returns></returns>
        public int xzspr(string id, string spr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set ztspr='{0}' where RepnnID = '{1}'", spr, id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 更改审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updshSS(string id, string zt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set Repnzt='{0}' where RepnnID='{1}'", zt, id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 通过id查询所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable RepnnIDSel(string id)
        {
            StringBuilder sb = new StringBuilder();
            DBHelper db = new DBHelper();
            sb.AppendLine("select * from Repnn a join UserInfo b on a.UserID =b.UserID Where a.RepnnID=" + id);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 当业主更改状态时，状态更改为完成审核中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int up(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set Repnzt='审核完成中' where RepnnID='{0}'",id);
            return db.ExecuteNonQuery(sb.ToString());
        
        
        }

        /// <summary>
        /// 装修申请添加
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mph"></param>
        /// <returns></returns>
        public int Repnntj(int id, string mph)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO [PRO].[dbo].[Repnn]([UserID],[UserCell],[RepnnpDay],[RepnnMoney],[Repnzt],[Moneyzt]) VALUES('{0}','{1}',GETDATE(),2000,'未完成','未退')", id, mph);
            return db.ExecuteNonQuery(sb.ToString());

        }



        /// <summary>
        /// 根据门牌号查询当前信息
        /// </summary>
        /// <param name="mph"></param>
        /// <returns></returns>
        public DataTable Repnnxx(string mph)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select *from Repnn where UserCell='{0}'", mph);
            return db.GetTable(sb.ToString());
        }

        public DataTable RepnnShow()
        {
            StringBuilder sb = new StringBuilder();
            DBHelper db = new DBHelper();
            sb.AppendLine("select * from Repnn a join UserInfo b on a.UserID =b.UserID where Repnzt ='待验收'");
            return db.GetTable(sb.ToString());
        }

        public DataTable RepnnShow(string name)
        {
            StringBuilder sb = new StringBuilder();
            DBHelper db = new DBHelper();
            sb.AppendFormat("  select * from Repnn a join UserInfo b on a.UserID =b.UserID where b.UserName like '%{0}%'", name);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 查看业主申请装修状态为待审核
        /// </summary>
        /// <returns></returns>
        public DataTable repnnshowwc() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Repnn a join UserInfo b on a.UserID =b.UserID where Repnzt='待审核'");
            return db.GetTable(sb.ToString());
        }
        /// <summary>
        /// 修改状态未已完成
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updztwc(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" update Repnn set RepnnPDays=GETDATE(),Repnzt ='已完成',Moneyzt ='已退'where RepnnID ='{0}'", id);
            return db.ExecuteNonQuery(sb.ToString());
        }

    }
}
