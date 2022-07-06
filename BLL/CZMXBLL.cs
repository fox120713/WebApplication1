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
   public class CZMXBLL
    {
       CZMXDAL dal = new CZMXDAL();
        /// <summary>
       /// 添加一条充值记录
       /// </summary>
       /// <returns></returns>
       public int czinsert(CZMXModel czmodel) {
           return dal.czinsert(czmodel);
          
       }
       /// <summary>
       ///根据业主id查询缴费充值记录
       /// </summary>
       /// <returns></returns>
       public DataTable czsel(int id) {
           return dal.czsel(id);
       }
        /// <summary>
       /// 缴费充值记录月份
       /// </summary>
       /// <returns></returns>
       public DataTable months() {
           return dal.months();
       }
              /// <summary>
       ///根据业主id和月份查询缴费充值记录
       /// </summary>
       /// <returns></returns>
       public DataTable czsel(int id, string mo)
       {
           return dal.czsel(id, mo);
       
       }
       /// <summary>
       /// 退款到账记录
       /// </summary>
       /// <param name="userid"></param>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int tuikuancz(string userid, string mph)
       {
           return dal.tuikuancz(userid, mph);
       }

    }
}
