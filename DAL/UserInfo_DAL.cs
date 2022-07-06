using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class UserInfo_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();


        /// <summary>
        /// 根据登录手机号查询门牌号
        /// </summary>
        /// <returns></returns>
        public DataTable selnum(string phone)
        {
            sql.Clear();
            sql.AppendFormat("select UserCell from UserInfo where UserPhone='{0}'", phone);
            return db.GetTable(sql.ToString());

        }


        /// <summary>
        /// 居民表添加信息
        /// </summary>
        /// <returns></returns>
        public int userinfoInsert(UserInfo user)
        {
            sql.Clear();
            sql.AppendFormat("insert into UserInfo(UserImg,UserName,UserSex,UserAge,UserCard,UserCell,UserPhone) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", user.UserImg1, user.UserName1, user.UserSex1, user.UserAge1, user.UserCard1, user.UserCell1, user.UserPhone1);
            return db.ExecuteNonQuery(sql.ToString());


        }

        /// <summary>
        /// 根据编号修改居民表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserinfoUpdate(UserInfo user)
        {
            sql.Clear();
            sql.AppendFormat("update UserInfo set UserName='{0}',UserSex='{1}',UserAge='{2}',UserCard='{3}',UserCell='{4}',UserPhone='{5}',UserPwd='{6}' where UserID={7}", user.UserName1, user.UserSex1, user.UserAge1, user.UserCard1, user.UserCell1, user.UserPhone1, user.UserPwd1, user.UserID1);
            return db.ExecuteNonQuery(sql.ToString());

        }
        /// <summary>
        /// 根据编号修改居民表xin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(UserInfo user)
        {
            sql.Clear();
            sql.AppendFormat("update UserInfo set UserName='{0}',UserPwd='{1}',UserPhone='{2}' where UserID='{3}'", user.UserName1,user.UserPwd1, user.UserPhone1, user.UserID1);
            return db.ExecuteNonQuery(sql.ToString());

        }
        /// <summary>
        /// 根据编号删除
        /// </summary>
        /// <returns></returns>
        public int UserinfoDel(int id)
        {
            sql.Clear();
            sql.AppendFormat("delete from UserInfo where UserID='{0}'", id);
            return db.ExecuteNonQuery(sql.ToString());


        }

        public DataTable sel()//查询，绑定
        {
            sql.Clear();
            sql.AppendLine("select * from UserInfo");
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string name)//登录前准备——姓名查询
        {
            sql.Clear();
            sql.AppendFormat("select count(*) from UserInfo where UserPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string name, string mp)
        {
            sql.Clear();
            if (name == "" && mp == "")
            {
                sql.AppendLine("select * from UserInfo ");
            }
            else if (name != "" && mp == "")
            {
                sql.AppendFormat("select * from UserInfo where UserName like'%{0}%' ", name);
            }
            else if (name == "" && mp != "")
            {
                sql.AppendFormat("select * from UserInfo where UserCell like'%{0}%' ", mp);
            }
            else if (name != "" && mp != "")
            {
                sql.AppendFormat("select * from UserInfo where UserName like'%{0}%' and UserCell like'%{1}%'", name, mp);
            }

            return db.GetTable(sql.ToString());
        }

        public DataTable denglu(string name, string pwd)//登录
        {
            sql.Clear();
            sql.AppendFormat("select count(*) from UserInfo where UserPhone='{0}' and UserPwd='{1}'", name, pwd);
            return db.GetTable(sql.ToString());
        }

        /// <summary>
        /// 查询所有业主信息
        /// </summary>
        /// <returns></returns>
        public DataTable UserInfoAll()
        {
            sql.Clear();
            sql.AppendFormat(@"SELECT [UserID]
      ,[UserName]
      ,[UserSex]
      ,[UserAge]
      ,[UserCard]
      ,[UserCell]
      ,[UserPhone]
      ,[UserPwd]
  FROM [PRO].[dbo].[UserInfo]");
            return db.GetTable(sql.ToString());
        }

        public DataTable seluserid(string phone)//id查询
        {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserPhone='{0}'", phone);
            return db.GetTable(sql.ToString());
        }

        public int add(UserInfo user)//用户表新增
        {
            sql.Clear();
            sql.AppendFormat("insert into [UserInfo](UserName,UserSex,UserAge,UserCard,UserCell,UserPhone,UserPwd) values('{0}','{1}',{2},'{3}','{4}','{5}','123456')", user.UserName1, user.UserSex1, user.UserAge1, user.UserCard1, user.UserCell1, user.UserPhone1);
            return db.ExecuteNonQuery(sql.ToString());
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public int PwdUpd(string name, string pwd)
        {
            sql.Clear();
            sql.AppendFormat("update [UserInfo] set UserPwd='{0}'where UserPhone ='{1}'", pwd, name);
            return db.ExecuteNonQuery(sql.ToString());
        }
        public DataTable selna(string name)
        {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }
        public DataTable seluserMph(string cell)//门牌号查询
        {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserCell='{0}'", cell);
            return db.GetTable(sql.ToString());
        }

        public DataTable updatepic(string name, string pic)
        {
            sql.Clear();
            sql.AppendFormat("update UserInfo set pic='{0}' where UserPhone='{1}'", pic, name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selpic(string name)
        {
            sql.Clear();
            sql.AppendFormat("select count(pic) from UserInfo where UserPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selpic1(string name)
        {
            sql.Clear();
            sql.AppendFormat("select pic from UserInfo where UserPhone='{0}'", name);
            return db.GetTable(sql.ToString());
        }

        public DataTable selphone(string phone)
        {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserPhone='{0}'", phone);
            return db.GetTable(sql.ToString());
        }
        public DataTable selCell(string cell)
        {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserCell='{0}'", cell);
            return db.GetTable(sql.ToString());
        }
        /// <summary>
        /// 根据id查业主信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable selxx(int id) {
            sql.Clear();
            sql.AppendFormat("select * from UserInfo where UserID='{0}'",id);
            return db.GetTable(sql.ToString());
        
        
        }
        public DataTable seluseridnum(string phone)
        {
            sql.Clear();
            sql.AppendFormat("select count(*) from UserInfo where UserPhone='{0}'", phone);
            return db.GetTable(sql.ToString());
        }

        public DataTable seldong()
        {
            sql.Clear();
            sql.AppendLine("select distinct(left(UserCell,1)+'栋')as dong from [UserInfo]");
            return db.GetTable(sql.ToString());
        }

        public DataTable seldy(string dong)
        {
            sql.Clear();
            if (dong == "7栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='7栋'");
            }
            else if (dong == "1栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='1栋'");
            }
            else if (dong == "2栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='2栋'");
            }
            else if (dong == "3栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='3栋'");
            }
            else if (dong == "4栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='4栋'");
            }
            else if (dong == "5栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='5栋'");
            }
            else if (dong == "6栋")
            {
                sql.AppendLine("select distinct(SUBSTRING(UserCell,3,1)+'单元')as dong from [UserInfo] where left(UserCell,1)+'栋'='6栋'");
            }
            return db.GetTable(sql.ToString());
        }

        public DataTable selnumber(string dong, string dy)
        {
            sql.Clear();
            sql.AppendFormat("select distinct(SUBSTRING(UserCell,5,3)+'号')as dong from [UserInfo] where SUBSTRING(UserCell,3,1)+'单元'='{0}'and left(UserCell,1)+'栋'='{1}'", dy, dong);
            return db.GetTable(sql.ToString());
        }


    }
}
