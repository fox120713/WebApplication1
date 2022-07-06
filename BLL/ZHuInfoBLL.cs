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
    public class ZHuInfoBLL
    {
        ZHuInfoDAL dal = new ZHuInfoDAL();


        public int jia(string name)
        {
            return dal.jia(name);
        }


        public DataTable sel(string id)
        {
            return dal.sel(id);

        }

        //显示数据
        public DataTable table()
        {
            return dal.table();
        }
        //显示要充值的人的信息
        public DataTable table(string id)
        {
            return dal.table(id);
        }
        //充值
        public int xg(double money, string id)
        {
            return dal.xg(money, id);
        }
        /// <summary>
        /// 根据水电费缴费金额扣除账户钱
        /// </summary>
        /// <returns></returns>
        public int jian(double money, string name)
        {
            return dal.jian(money, name);

        }
        /// <summary>
        /// 根据账户名查金额
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable cxMoney(string name)
        {
            return dal.cxMoney(name);
        }

        public int x(double money, string name)
        {
            return dal.x(money,name);
        }
        public DataTable selzh(int yzid) {
            return dal.selzh(yzid);
        }
        public int insert(ZHMODEL zh) {
            return dal.insert(zh);
        }
               /// <summary>
       /// 根据账户id查询金额
       /// </summary>
       /// <param name="money"></param>
       /// <param name="name"></param>
       /// <returns></returns>
        public DataTable cxMoney1(string zhid) {
            return dal.cxMoney1(zhid);
        
        
        
        }

    }
}
