using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class StfInfo_DAL
    {
        StringBuilder sql = new StringBuilder();
        StringBuilder sb = new StringBuilder();
        DBHelper db = new DBHelper();




        public DataTable selgly(string name)
        {
            sql.Clear();
            sql.AppendFormat("select COUNT(*) from StfInfo where YgPhone='{0}' and YgPos=6 and YgPwd='{1}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selgly(string name, string pwd)
        {
            sql.Clear();
            sql.AppendFormat("select COUNT(*) from StfInfo where YgPhone='{0}' and YgPos=6 and YgPwd='{1}'", name, pwd);
            return db.GetTable(sql.ToString());
        }
        /// <summary>
        /// 员工表修改
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int stInfoupdate(StfInfoMODEL yg)
        {
            sb.Clear();
            sb.AppendFormat("update StfInfo set YgPwd={0},YgName='{1}',YgSex='{2}',YgAge='{3}',YgCell='{4}',YgPhone='{5}',Ygdate='{6}',YgPos='{7}' where YgId={8}", yg.YgPwd1, yg.YgName1, yg.YgSex1, yg.YgAge1, yg.YgCell1, yg.YgPhone1, yg.Ygdate, yg.Ygpos1, yg.YgId1);
            return db.ExecuteNonQuery(sb.ToString());
        }

        /// <summary>
        /// 根据员工id删除
        /// </summary>
        /// <param name="YgID"></param>
        /// <returns></returns>
        public int stInfoDel(int YgID)
        {
            sb.Clear();
            sb.AppendFormat("delete  from StfInfo where YgId='{0}'", YgID);
            return db.ExecuteNonQuery(sb.ToString());
        }

        public DataTable sel()//查询绑定
        {
            sql.AppendLine("select * from StfInfo");
            return db.GetTable(sql.ToString());
        }
        /// <summary>
        /// 根据下拉列表查询数据，联表查询
        /// </summary>
        /// <returns></returns>
        public DataTable StInfoAll(string name, string phone, int posID)
        {
            sb.Clear();
            if (posID == 7 && name == "" && phone == "")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
            }
            else if (posID != 7 && name == "" && phone=="")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgPos='{0}'", posID);
            }
            else if (posID == 7 && name != "" && phone=="")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgName like'%{0}%'", name);
            }
            else if (posID == 7 && name == "" && phone != "")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgPhone like'%{0}%'", phone);
            }
            else if (posID !=7 && name!="" && phone == "")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgName like'%{0}%' and YgPos='{1}'", name,posID);
            }
            else if (posID != 7 && name == "" && phone != "")
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgPhone like'%{0}%' and YgPos='{1}'", phone,posID);
            }
            else
            {
                sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
                sb.AppendFormat(" where YgName like'%{0}%' and YgPhone='{1}' and YgPos='{2}'", name, phone, posID);
            }

            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 员工表添加
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int stInfoInsert(StfInfoMODEL yg)
        {
            sb.Clear();
            sb.AppendFormat("insert into StfInfo(YgImg,YgName,YgSex,YgAge,YgCell,YgPhone,Ygdate,YgPos) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", yg.Ygimg, yg.YgName1, yg.YgSex1, yg.YgAge1, yg.YgCell1, yg.YgPhone1, yg.Ygdate, yg.Posid);
            //sb.AppendLine("INSERT INTO [dbo].[StfInfo]([YgImg] ,[YgName],[YgSex],[YgAge],[YgCell],[YgPhone],[Ygdate],[YgPos]) VALUES");
            //sb.AppendFormat(" '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",yg.Ygimg,yg.YgName1,yg.YgSex1,yg.YgAge1,yg.YgCell1,yg.YgPhone1,yg.Ygdate,yg.Posid);
            return db.ExecuteNonQuery(sb.ToString());


        }

        /// <summary>
        /// 查询员工信息表以及部门表所有的数据，联表查询
        /// </summary>
        /// <returns></returns>
        public DataTable StInfoAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from StfInfo join Pos on StfInfo.YgPos=Pos.PosID");
            return db.GetTable(sb.ToString());
        }

        public DataTable denglu(string name, string pwd)//登录
        {
            sql.Clear();
            sql.AppendFormat("select count(*) from [StfInfo] where YgPhone='{0}' and YgPwd='{1}'", name, pwd);
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string name)//登录前准备
        {
            sql.Clear();
            sql.AppendFormat("select count(*) from StfInfo where YgPhone = '{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable sex()//性别查询绑定
        {
            sql.Clear();
            sql.AppendFormat("select distinct(YgSex) from [StfInfo]");
            return db.GetTable(sql.ToString());
        }

        public DataTable selbf(string name, string sex)
        {
            sql.Clear();
            if (sex == "全部" && name == "")
            {
                sql.AppendLine("select * from [StfInfo] ");
            }
            else if (sex == "全部" && name != "")
                {
                    sql.AppendFormat("select * from [StfInfo] where  YgName like '%{0}%' ", name);
                }
                else
                {
                    sql.AppendFormat("select * from [StfInfo] where YgName like '%{0}%' and YgSex='{1}'", name, sex);
                }
            return db.GetTable(sql.ToString());
        }

        public DataTable selname(string name)
        {
            sql.Clear();
            sql.AppendFormat("select * from [StfInfo] where YgPhone ='{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selbm(string name)//部门查询
        {
            sql.Clear();
            sql.AppendFormat("select PosName from [StfInfo] join [Pos] on [Pos].PosID=[StfInfo].YgPos where YgPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }
        public DataTable cx(string name)
        {
            sb.Clear();
            sb.AppendFormat("select YgId,YgName,YgPos from StfInfo where YgPhone='{0}'", name);
            return db.GetTable(sb.ToString());
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public int PwdUpd(string name, string pwd)
        {
            sql.Clear();
            sql.AppendFormat("update [StfInfo] set YgPwd='{0}'where YgName ='{1}'", pwd, name);
            return db.ExecuteNonQuery(sql.ToString());
        }
        //查询是否有头像
        public DataTable selpic(string name)
        {
            sql.Clear();
            sql.AppendFormat("select count(pic) from StfInfo where YgPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }
        //头像
        public DataTable selpic1(string name)
        {
            sql.Clear();
            sql.AppendFormat("select pic from StfInfo where YgPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }
        public int updatepic(string name, string pic)//头像数据修改
        {
            sql.Clear();
            sql.AppendFormat("update [StfInfo] set pic='{0}' where YgPhone='{1}'", pic, name);
            return db.ExecuteNonQuery(sql.ToString());
        }

        //修改密码
        public int pwdupdate(string name, string pwd)
        {
            sql.Clear();
            sql.AppendFormat("update [StfInfo] set YgPwd='{0}' where YgPhone='{1}'", pwd, name);
            return db.ExecuteNonQuery(sql.ToString());
        }


        //姓名查询all
        public DataTable selnameall(string name)
        {
            sql.Clear();
            sql.AppendFormat("select * from StfInfo where YgName='{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selphone(string phone)
        {
            sql.Clear();
            sql.AppendFormat("select * from StfInfo where YgPhone='{0}'", phone);
            return db.GetTable(sql.ToString());
        }

        public DataTable selid(string id)
        {
            sql.Clear();
            sql.AppendFormat("select * from StfInfo where Ygid='{0}'", id);
            return db.GetTable(sql.ToString());
        }

        public int StfUpd(StfInfoMODEL stf)
        {
            sql.Clear();
            sql.AppendFormat("update StfInfo set [Ygdate] ='{0}',[YgName]='{1}',[YgPwd]='{2}',[YgPhone]='{3}',[YgPos]='{4}'where Ygid='{5}'",stf.Ygdate,stf.YgName1,stf.YgPwd1,stf.YgPhone1,stf.Ygpos1,stf.YgId1);
            return db.ExecuteNonQuery(sql.ToString());
        }

        public DataTable selxm(int ygid) {
            sql.Clear();
            sql.AppendFormat("select *from StfInfo where YgId='{0}'",ygid);
            return db.GetTable(sql.ToString());
        
        
        }

    }
}
