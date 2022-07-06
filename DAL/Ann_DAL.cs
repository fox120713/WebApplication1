using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class Ann_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();

        public DataTable sel()//查询绑定
        {
            sql.Clear();
            sql.AppendLine("select * from Ann");
            return db.GetTable(sql.ToString());
        }
        /// <summary>
        /// 查询所有待审核数据
        /// </summary>
        /// <returns></returns>
        public DataTable seldsh() {
            sql.Clear();
            sql.AppendLine("select * from Ann where AnnaIstate='待审核' order by AnnaDate asc");
            return db.GetTable(sql.ToString());
        
        }


        /// <summary>
        /// 显示全部公告
        /// </summary>
        /// <returns></returns>
        public DataTable AnnAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select Annid,[AnnTitle],[AnnCon],[AnnaDate],Annimg, SUBSTRING(CONVERT(varchar(12) , AnnaDate, 23 ),6,5)  as  Adate,SUBSTRING([AnnCon],1,20) as AnnConn from Ann where AnnaIstate = '已通过'order by AnnaDate desc");
            return db.GetTable(sb.ToString());
        }
        public DataTable AnnAll(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select Annid,[AnnTitle],[AnnCon],[AnnaDate],Annimg, SUBSTRING(CONVERT(varchar(12) , AnnaDate, 23 ),6,5)  as  Adate,SUBSTRING([AnnCon],1,20) as AnnConn from Ann where Annid=" + id);
            return db.GetTable(sb.ToString());
        }
        public DataTable AnnOrderBy()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select top 6 Annid,[AnnTitle],[AnnCon],[AnnaDate],Annimg, CONVERT(varchar(12) , AnnaDate, 23 )  as  Adate,SUBSTRING([AnnCon],1,16) as AnnConn from Ann   order by Adate desc");
            return db.GetTable(sb.ToString());
        }

        public DataTable selzt()//查询状态，绑定
        {
            sql.Clear();
            sql.AppendLine("select distinct(AnnaIstate) from Ann");
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string title, string zt)
        {
            sql.Clear();
            if (zt=="全部"&&title=="")
            {
            sql.AppendLine("select * from Ann");
            return db.GetTable(sql.ToString());
            }
            else if (zt=="全部"&&title!="")
            {
                 sql.AppendFormat("select * from Ann where AnnTitle like '%{0}%'",title);
            }
            else
            {
                sql.AppendFormat("select * from Ann where AnnaIstate ='{0}' and AnnTitle like'%{1}%'", zt, title);
           
            }
            return db.GetTable(sql.ToString());

        }
        public int add(Ann ann)//新增
        {
            sql.Clear();
            sql.AppendFormat("insert into [Ann] (AnnTitle,AnnCon,AnnsqrID,AnnaDate,AnnaName,AnnaIstate,Annimg)values('{0}','{1}',{2},'{3}','{4}','待审核','1.jpg')",ann.AnnTitle1,ann.AnnCon1,ann.AnnsqrID1,ann.AnnaDate1,ann.AnnaName1);
            return db.ExecuteNonQuery(sql.ToString());
        }
        /// <summary>
        /// 根据id查询信息
        /// </summary>
        /// <returns></returns>
        public DataTable selid(int id) {
            sql.Clear();
            sql.AppendLine("select * from Ann where Annid="+id);
            return db.GetTable(sql.ToString());
        
        }
         /// <summary>
        /// 根据id查询信息
        /// </summary>
        /// <returns></returns>
        public DataTable selid1(int id) {
            sql.Clear();
            sql.AppendLine("select * from Ann join StfInfo on Ann.AnnsqrID=StfInfo.YgId where Annid=" + id);
            return db.GetTable(sql.ToString());
        }
        /// <summary>
        /// 根据编号修改
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int update(string name,string sqrname,int id) {
            sql.Clear();
            sql.AppendFormat("update Ann set AnnaIstate='已通过',AnnWhy='同意',AnnaSpr='{0}',AnnDate=getdate(),AnnaName='{1}' where Annid={2}", name, sqrname, id);
            return db.ExecuteNonQuery(sql.ToString());
        
        }
        /// <summary>
        /// 根据编号修改,拒绝
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int jj(string name, int id,string yy)
        {
            sql.Clear();
            sql.AppendFormat(" update Ann set AnnaIstate='未通过',AnnWhy='{0}',AnnaSpr='{1}' where Annid='{2}'", yy,name,id);
            return db.ExecuteNonQuery(sql.ToString());

        }
        /// <summary>
        /// 根据日期，状态查询
        /// </summary>
        /// <returns></returns>
        public DataTable seld(string zt) {
            sql.Clear();
            sql.AppendFormat("select * from Ann where AnnaIstate='{0}'",zt);
            return db.GetTable(sql.ToString());
        
        }
        

    }
}
