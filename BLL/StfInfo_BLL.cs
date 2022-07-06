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
    public class StfInfo_BLL
    {
        StfInfo_DAL dal = new StfInfo_DAL();
        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }

        public DataTable selgly(string name)
        {
            return dal.selgly(name);
        }

        public DataTable selgly(string name ,string pwd)
        {
            return dal.selgly(name,pwd);
        }


        /// <summary>
        /// 根据id修改
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int stInfoupdate(StfInfoMODEL yg)
        {
            return dal.stInfoupdate(yg);


        }

        /// <summary>
        /// 根据员工id删除
        /// </summary>
        /// <param name="YgID"></param>
        /// <returns></returns>
        public int stInfoDel(int YgID)
        {
            return dal.stInfoDel(YgID);
        }

        public DataTable StInfoAll(string name, string phone, int posID)
        {
            return dal.StInfoAll(name, phone, posID);

        }

        /// <summary>
        /// 员工表添加
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int stInfoInsert(StfInfoMODEL yg)
        {
            return dal.stInfoInsert(yg);

        }

        /// <summary>
        /// 查询员工信息表以及部门表所有的数据，联表查询
        /// </summary>
        /// <returns></returns>
        public DataTable StInfoAll()
        {
            return dal.StInfoAll();
        }


        public DataTable denglu(string name, string pwd)//登录
        {
            return dal.denglu(name, pwd);
        }

        public DataTable sel(string name)//姓名查询——登录前准备
        {
            return dal.sel(name);
        }

        public DataTable sex()//性别查询
        {
            return dal.sex();
        }

        public DataTable selbf(string name, string sex)
        {
            return dal.selbf(name, sex);

        }

        public DataTable selname(string name)
        {
            return dal.selname(name);
        }

        public DataTable selbm(string name)//部门查询
        {
            return dal.selbm(name);
        }
        public DataTable cx(string name)
        {
            return dal.cx(name);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public int PwdUpd(string name, string pwd)
        {
            return dal.PwdUpd(name, pwd);
        }
        //查询对应头像
        public DataTable selpic(string name)
        {
            return dal.selpic(name);
        }

        public int updatepic(string name, string pic)
        {
            return dal.updatepic(name, pic);
        }
        //头像
        public DataTable selpic1(string name)
        {
            return dal.selpic1(name);
        }

        //修改密码
        public int pwdupdate(string name, string pwd)
        {
          return  dal.pwdupdate(name, pwd);
        }

        //姓名查询all
        public DataTable selnameall(string name)
        {
            return dal.selname(name);
        }

        public DataTable selphone(string phone)
        {
            return dal.selphone(phone);
        }
        public DataTable selid(string id)
        {
            return dal.selid(id);
        }
        public int StfUpd(StfInfoMODEL stf)
        {
            return dal.StfUpd(stf);
        }
        public DataTable selxm(int ygid)
        {

            return dal.selxm(ygid);
        }
    }
}
