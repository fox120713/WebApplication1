using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
using DAL;
namespace BLL
{
    public class UserInfo_BLL
    {
        UserInfo_DAL dal = new UserInfo_DAL();

        /// <summary>
        /// 根据登录手机号查询门牌号
        /// </summary>
        /// <returns></returns>
        public DataTable selnum(string phone)
        {
            return dal.selnum(phone);

        }


        /// <summary>
        /// 居民表添加信息
        /// </summary>
        /// <returns></returns>
        public int userinfoInsert(UserInfo user)
        {
            return dal.userinfoInsert(user);

        }

        /// <summary>
        /// 根据编号修改居民表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserinfoUpdate(UserInfo user)
        {
            return dal.UserinfoUpdate(user);
        }

        /// <summary>
        /// 根据编号删除居民表
        /// </summary>
        /// <returns></returns>
        public int UserinfoDel(int id)
        {
            return dal.UserinfoDel(id);

        }

        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }
        public DataTable sel(string name)//姓名查询
        {
            return dal.sel(name);
        }

        public DataTable sel(string name, string mp)
        {
            return dal.sel(name, mp);
        }

        public DataTable denglu(string name, string pwd)//登录
        {
            return dal.denglu(name, pwd);
        }

        /// <summary>
        /// 查询所有业主信息
        /// </summary>
        /// <returns></returns>
        public DataTable UserInfoAll()
        {
            return dal.UserInfoAll();
        }

        public DataTable seluserid(string phone)
        {
            return dal.seluserid(phone);
        }

        public int add(UserInfo user)//新增
        {
            return dal.add(user);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public int PwdUpd(string name, string pwd)
        {
            return dal.PwdUpd(name, pwd);
        }
        public DataTable selna(string name)
        {
            return dal.selna(name);
        }
        public DataTable seluserMph(string cell)//门牌号查询
        {
            return dal.seluserMph(cell);
        }

        public DataTable updatepic(string name, string pic)
        {
            return dal.updatepic(name, pic);
        }

        public DataTable selpic(string name)
        {
            return dal.selpic(name);
        }

        public DataTable selpic1(string name)
        {
            return dal.selpic1(name);
        }
        public DataTable selphone(string phone)
        {
            return dal.selphone(phone);
        }
        /// <summary>
        ///查询楼栋号
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public DataTable selCell(string cell)
        {
            return dal.selCell(cell);
        
        }
                /// <summary>
        /// 根据id查业主信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable selxx(int id) {
            return dal.selxx(id);
        }
                /// <summary>
        /// 根据编号修改居民表xin
        /// </summary>
        /// <param name="user"></param>
        public DataTable seldong()
        {
            return dal.seldong();
        }

        public DataTable seldy(string dong)
        {
            return dal.seldy(dong);
        }

        public DataTable selnumber(string dong, string dy)
        {
            return dal.selnumber(dong, dy);
        }
        public int Update(UserInfo user)
        {
            return dal.Update(user);
        
        }
        public DataTable seluseridnum(string phone)
        {
            return dal.seluseridnum(phone);
        }



    }
}
