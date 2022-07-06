using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using MODEL;
namespace BLL
{
    public class PrepnBLL
    {
        PrpenDAL dal = new PrpenDAL();
        public DataTable PrepnShow()
        {
            return dal.PrepnShow();
        }

        public int Prepn_Add(PrepnModel prepn)
        {
            return dal.Prepn_Add(prepn);
        }

        public int shenhe(string id, string cz, string wxr)
        {
            return dal.shenhe(id, cz, wxr);
        }

        public DataTable Prpen_PrState(string phone)
        {
            return dal.Prpen_PrState(phone);
        }

        public DataTable PrepnSelShow(string priste, string PrIstate, string PrState)
        {
            return dal.PrepnSelShow(priste, PrIstate, PrState);
        }

        public DataTable ggshShow(string id)
        {
            return dal.ggshShow(id);
        }

        /// <summary>
        /// 设置维修开始时间
        /// </summary>
        /// <returns></returns>
        public int Prpen_date_start(string date, string id)
        {
            return dal.Prpen_date_start(date, id);
        }

        /// <summary>
        /// 设置维修结束时间
        /// </summary>
        /// <param name="date"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Prpen_date_end(string date, string img, string id)
        {
            return dal.Prpen_date_end(date, img, id);
        }
        /// <summary>
        /// 选择可以派出的维修人
        /// </summary>
        /// <returns></returns>
        public DataTable Prepn_wxr()
        {
            return dal.Prepn_wxr();
        }

    }
}
