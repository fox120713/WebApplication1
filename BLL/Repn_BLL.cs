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
    public class Repn_BLL
    {
        Repn_DAL dal = new Repn_DAL();

        public int repninsert(RepnMODEL repn)
        {
            return dal.repninsert(repn);

        }

        public DataTable sel(string number, string name)
        {
            return dal.sel(number,name);
        }

        public int repn_upd(string id, string cz, string name)
        {
            return dal.repn_upd(id, cz, name);
        }

        public DataTable repn_WxShow(string id)
        {
            return dal.repn_WxShow(id);
        }

        public DataTable repenWx()
        {
            return dal.repenWx();
        }

        public DataTable repnShow()//查询绑定
        {
            return dal.repnShow();
        }

        public DataTable repn_ReppBool(string phone)
        {
            return dal.repn_ReppBool(phone);
        }

        public DataTable repnShow(string name, string shzt, string wczt)
        {
            return dal.repnShow(name, shzt, wczt);
        }

        /// <summary>
        /// 通过id查询审核信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable repn_shShow(string id)
        {
            return dal.repn_shShow(id);
        }

        public int repn_starta(string id, string date)
        {
            return dal.repn_starta(id, date);
        }

        /// <summary>
        /// 设置维修结束时间
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public int repn_end(string id, string date, string img)
        {
            return dal.repn_end(id, date, img);
        }
        /// 根据名称查询维修
        /// </summary>
        /// <returns></returns>
        public DataTable repnSel(string name)
        {
            return dal.repnSel(name);
        }

        public DataTable repnShow1(string name, string shzt, string wxzt)//查询绑定
        {
            return dal.repnShow1(name, shzt, wxzt);
        }
    }
}
