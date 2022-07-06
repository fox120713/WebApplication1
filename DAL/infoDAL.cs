using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODEL;
namespace DAL
{
    public class infoDAL
    {
        DBHelper db = new DBHelper();
        StringBuilder sb = new StringBuilder();

        //后勤部表格数据显示
        public DataTable infoALL()
        {
            sb.Clear();
            sb.AppendLine("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID where PosName='后勤部'");
            return db.GetTable(sb.ToString());
        }
        //后勤部员工条件查询
        public DataTable infosel(string name)
        {
            sb.Clear();
            sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID where PosName='后勤部' and YgName like '%{0}%'", name);
            return db.GetTable(sb.ToString());
        }
        //值班表格数据
        public DataTable ZBAll()
        {
            sb.Clear();
            sb.AppendLine("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID ");
            return db.GetTable(sb.ToString());
        }
        //值班表条件查询
        public DataTable ZBsel(string name, DateTime date)
        {
            sb.Clear();
            if (name.Trim() == null && name.Trim() == "")
            {
                if (date.ToString().Trim() != null && date.ToString().Trim() != "")
                {
                    sb.AppendFormat("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID where zbdate='{0}'", date);
                }

            }
            else
            {
                sb.AppendFormat("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID where YgName like '%{0}%'", name);
                sb.AppendFormat("and zbdate='{0}'", date);
            }
            return db.GetTable(sb.ToString());
        }
        public DataTable ZBsel(string name)
        {
            sb.Clear();
            sb.AppendFormat("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID where YgName like '%{0}%'", name);
            return db.GetTable(sb.ToString());
        }
        //值班表删除
        public int ZBdel(int id)
        {
            sb.Clear();
            sb.AppendFormat("delete from ZbInfo where YgId=" + id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        //值班表修改
        public int DALupd(ZbInfoMODEL u)
        {
            sb.Clear();
            sb.AppendFormat("update ZbInfo set YgName='{0}',zbdate='{1}',gznr='{2}',jttime='{3}' where YgId={4}", u.YgName1, u.Zbdate, u.Gznr, u.Jttime, u.YgId1);
            return db.ExecuteNonQuery(sb.ToString());
        }
        //添加页面自动显示姓名
        public DataTable cs(int id)
        {
            sb.Clear();
            sb.AppendLine("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID where PosName='后勤部' and YgId="+id);
            return db.GetTable(sb.ToString());
        }
        
        public DataTable xm(int id)
        {
            sb.Clear();            
            sb.AppendLine("select YgName from StfInfo where YgId="+id);
            return db.GetTable(sb.ToString());
        }
        //值班表增加
        public int ZBadd(ZbInfoMODEL u)
        {
            sb.Clear();
            sb.AppendFormat("insert ZbInfo values({0},'{1}',{2},'{3}','{4}','{5}','未报告','','')", u.YgId1, u.YgName1, u.YgPos1, u.Zbdate, u.Gznr, u.Jttime);
            //更改员工状态
            sb.AppendFormat("update StfInfo set YgState='{0}' where YgID={1}", "工作中", u.YgId1);
            return db.ExecuteNonQuery(sb.ToString());
        }
        //更改员工状态
        public int ygupd()
        {
            sb.Clear();
            //更改员工状态
            sb.AppendFormat("update StfInfo set YgState='{0}'", "无任务");
            return db.ExecuteNonQuery(sb.ToString());
        }
        public int ygupd(int id)
        {
            sb.Clear();
            //删除值班安排更改员工状态
            sb.AppendFormat("update StfInfo set YgState='{0}' where YgId={1}", "无任务",id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        public DataTable ztqr(int id)
        {
            sb.Clear();
            sb.AppendLine("select YgState from StfInfo where YgId=" + id);
            return db.GetTable(sb.ToString());
        }
        //员工界面查看自己的值班安排
        public DataTable myself(string phone)
        {
            sb.Clear();
            sb.AppendFormat("select * from StfInfo as a join ZbInfo as b on a.YgId=b.YgId where YgPhone='{0}' and zt='未报告' or zt='未通过'", phone);
            return db.GetTable(sb.ToString());
        }
        //根据日期查询自己的值班安排
        public DataTable myself(string phone,DateTime date)
        {
            sb.Clear();
            sb.AppendFormat("select * from StfInfo as a join ZbInfo as b on a.YgId=b.YgId where YgPhone='{0}' and  zbdate='{1}' and zt=='未报告'or zt=='未通过' ", phone, date);
            return db.GetTable(sb.ToString());
        }
        //工作报告提交后更改图片字段和状态
        public int reportupd(string imgurl,int id)
        {
            sb.Clear();
            sb.AppendFormat("update ZbInfo set  zt='待审核',cgimg='{0}'  where zbid={1}", imgurl, id);
            return db.ExecuteNonQuery(sb.ToString());
        }
         //管理员审核界面表格显示
        public DataTable shenhexinxi()
        {
            sb.Clear();
            sb.AppendFormat("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID where zt!='未报告'");
            return db.GetTable(sb.ToString());
        }
        public DataTable shenhexinxi(int id)
        {
            sb.Clear();
            sb.AppendFormat("select * from ZbInfo join Pos on ZBInfo.YgPos=Pos.PosID where zt!='未报告' and zbid="+id);
            return db.GetTable(sb.ToString());
        }
        public int tg(int id,string name)
        {
            sb.Clear();
            sb.AppendFormat("update ZbInfo set  zt='已通过' where zbid={0}",  id);
            sb.AppendFormat("update StfInfo set YgState='无任务' where YgName='{0}'", name);
            return db.ExecuteNonQuery(sb.ToString());
        }
        public DataTable ztcx(string zt)
        {
            sb.Clear();
            sb.AppendFormat("select * from ZbInfo where zt='{0}'",zt);
            return db.GetTable(sb.ToString());
        }
        public int btg(string cause,int id)
        {
            sb.Clear();
            sb.AppendFormat("update ZbInfo set  zt='未通过' ,cause='{0}' where zbid={1}",cause ,id);            
            return db.ExecuteNonQuery(sb.ToString());
        }
    }
}
