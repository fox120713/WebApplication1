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
    public class Home_BLL
    {
        Home_DAL dal = new Home_DAL();

        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }

        public DataTable sel(string type)
        {
            return dal.sel(type);
        }


        public DataTable sellx(string type)//查询类型
        {
            return dal.sellx(type);
        }

        public int del(string mp)//删除
        {
            return dal.del(mp);
        }

    }
}
