using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;

namespace DAL
{
    public class YgKqDAL
    {
        DBHelper db = new DBHelper();
        StringBuilder sql = new StringBuilder();
        StringBuilder sb = new StringBuilder();

        public DataTable YgKqALL()
        {
            sql.Clear();
            sql.AppendLine("select * from [StfInfo]");
            return db.GetTable(sql.ToString());
        }

        /// <summary>
        /// 根据id查找员工信息
        /// </summary>
        /// <returns></returns>
        public DataTable YgKqALL(int id)
        {
            sb.Clear();
            sb.AppendLine("select  pos.PosName,YgKq.YgName,YgKq.DaKaSj,YgKq.BeiZhu,YgKq.Ctime from YgKq join Pos on YgKq.PosName=Pos.PosID  where YgId=" + id);
            return db.GetTable(sb.ToString());

        }

        /// <summary>
        /// 考勤汇总
        /// </summary>
        /// <returns></returns>
        public DataTable YGKqSum()
        {
            sb.Clear();
            sb.AppendLine(@"select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID
 group by YgName,YgId,a.PosName order by PosName,YgId asc");
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 考勤汇总
        /// </summary>
        /// <returns></returns>
        public DataTable YGKqSum(string name, string zt, int bm)
        {
            sb.Clear();
            if (name=="" && zt=="全部"&& bm==99)
            {
                sb.AppendLine(@" select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID
 group by YgName,YgId,a.PosName order by PosName,YgId asc");

            }
            else if (name=="" && zt=="异常"&& bm==99)
            {
                sb.AppendLine(@"  select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID
 group by YgName,YgId,a.PosName having count(Ctime)>0 order by PosName,YgId asc ");
            }
            else if (name=="" && zt=="异常"&& bm!=99)
            {
                sb.AppendFormat(@" select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID where a.PosName='{0}' 
 group by YgName,YgId,a.PosName having count(Ctime)>0 order by PosName,YgId asc ",bm);
            }
            else if (name=="" && zt=="全部"&& bm!=99)
            {
                sb.AppendFormat(@"select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID where a.PosName='{0}' 
 group by YgName,YgId,a.PosName order by PosName,YgId asc ", bm);
            }
            else if (name!="" && zt=="全部"&& bm==99)
            {
                 sb.AppendFormat(@" select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID where a.YgName like '%{0}%'
 group by YgName,YgId,a.PosName order by PosName,YgId asc  ", name);
            }
            else if (name != "" && zt == "异常" && bm == 99)
            {
                sb.AppendFormat(@" select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID where  a.YgName like '%{0}%'
 group by YgName,YgId,a.PosName having count(Ctime)>0 order by PosName,YgId asc  ", name);
            }
            else if (name!="" && zt=="异常" && bm!=99)
            {
                sb.AppendFormat(@"select a.PosName, YgId ,a.YgName,count(YgName) as Ygday ,count(Ctime) as ygcount,SUM(Ctime)as ygtime from YgKq as a join Pos as b on a.PosName=b.PosID where a.PosName='{0}' and a.YgName like '%{1}%'
 group by YgName,YgId,a.PosName having count(Ctime)>0 order by PosName,YgId asc ",bm,name);
            }
           

            return db.GetTable(sb.ToString());
        }

        public int tj(YgKqMODEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert YgKq values('{0}','{1}','{2}','{3}','{4}','{5}')", a.PosName1, a.YgName1, a.YgId1, a.DaKaSj1, a.BeiZhu1, a.Ctime1);
            return db.ExecuteNonQuery(sb.ToString());
        }

        public DataTable cx(string name, string zt,string sj)
        {
            sb.Clear();
            if (zt=="全部")
            {

                sb.AppendFormat("select DaKaSj,BeiZhu,Ctime from YgKq where YgName='{0}' and DaKaSj like '{1}%'", name, sj);
            }
            else
            {
                sb.AppendFormat("select DaKaSj,BeiZhu,Ctime from YgKq where YgName='{0}' and BeiZhu='{1}' and DaKaSj like '{2}%'", name, zt, sj);   
            }
            return db.GetTable(sb.ToString());
        }

        public DataTable bd()
        {
            sb.Clear();
            sb.AppendFormat("select distinct BeiZhu from YgKq");
            return db.GetTable(sb.ToString());
        }
        public DataTable cx(string name)
        {
            sb.Clear();
            sb.AppendFormat("select DaKaSj,BeiZhu,Ctime from YgKq where YgName='{0}'", name);
            return db.GetTable(sb.ToString());
        }


        public DataTable xz(string name, int y,int m,int d)
        {
            sb.Clear();
            //sb.AppendFormat("select count(*) from YgKq where YgPhone='{0}' and year(DaKaSj)= '{1}' and MONTH(DaKaSj)='{2}' and DAY(DaKaSj)='{3}'", name, y,m,d);
            sb.AppendFormat("select count(*) from YgKq as a join StfInfo as b on a.YgId=b.YgId where YgPhone='{0}' and year(DaKaSj)= '{1}' and MONTH(DaKaSj)='{2}' and DAY(DaKaSj)='{3}'", name,y,m,d);
            return db.GetTable(sb.ToString());
        }
        /// <summary>
        /// 查询考勤表里的年份
        /// </summary>
        /// <returns></returns>
        public DataTable kqYear() {
            sb.Clear();
            sb.AppendLine(" select distinct YEAR(DaKaSj) as years from YgKq  ");
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 根据打卡时间查询信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sj"></param>
        /// <returns></returns>
        public DataTable kqcx(int id,string sj) {
            sb.Clear();
            sb.AppendFormat(" select  pos.PosName,YgKq.YgName,YgKq.DaKaSj,YgKq.BeiZhu,YgKq.Ctime from YgKq join Pos on YgKq.PosName=Pos.PosID where YgId='{0}' and DaKaSj like '{1}%'", id, sj);
            return db.GetTable(sb.ToString());
        }

        

    }
}
