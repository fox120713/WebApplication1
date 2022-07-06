using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class infoBLL
    {
        infoDAL dal=new infoDAL();

        //后勤部表格数据显示
        public DataTable infoALL()
        {
            return dal.infoALL();
        }
        //后勤部员工查询
        public DataTable infosel(string name)
        {
            return dal.infosel(name);
        }
        //值班表格数据
        public DataTable ZBAll()
        {
            return dal.ZBAll();
        }
       //值班表条件查询
        public DataTable ZBsel(string name, DateTime date)
        {
            return dal.ZBsel(name,date);
        }
        public DataTable ZBsel(string name)
        {
            return dal.ZBsel(name);
        }
        //值班表删除
        public int ZBdel(int id)
        {
            return dal.ZBdel(id);
        }
        //值班表修改
        public int DALupd(ZbInfoMODEL u)
        {
            return dal.DALupd(u);
        }
        //值班表增加
        public int ZBadd(ZbInfoMODEL u)
        {
            return dal.ZBadd(u);
        }
        //更改员工状态
        public int ygupd()
        {
            return dal.ygupd();
        }
        public int ygupd(int id)
        {
            return dal.ygupd(id);
        }
        //添加页面自动显示姓名
        public DataTable cs(int id)
        {
            return dal.cs(id);
        }
        public DataTable xm(int id)
        {
            return dal.xm(id);
        }
        public DataTable ztqr(int id)
        {
            return dal.ztqr(id);
        }
        //员工界面查看自己的值班安排
        public DataTable myself(string phone)
        {
            return dal.myself(phone);
        }
        //根据日期查询自己的值班安排
        public DataTable myself(string phone,DateTime date)
        {
            return dal.myself(phone,date);
        }
        //工作报告提交后更改图片字段和状态
        public int reportupd(string imgurl, int id)
        {
            return dal.reportupd(imgurl, id);
        }
        public DataTable shenhexinxi()
        {
            return dal.shenhexinxi();
        }
        public DataTable shenhexinxi(int id)
        {
            return dal.shenhexinxi(id);
        }
        //管理员审核通过
        public int tg(int id,string name)
        {
            return dal.tg(id,name);
        }
        public DataTable ztcx(string zt)
        {
            return dal.ztcx(zt);
        }
        public int btg(string cause, int id)
        {
            return dal.btg(cause,id);
        }
    }
}
