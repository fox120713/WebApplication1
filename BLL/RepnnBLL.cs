
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
   public class RepnnBLL
    {
       RepnnDAL dal = new RepnnDAL();


       public int xg(DateTime a, int id)
       {
           return dal.xg(a, id);
       }
       /// <summary>
       /// 更改状态为审核未通过
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public int updshw(string id)
       {
           return dal.updshw(id);
       }

       /// <summary>
       /// 更改状态为进行中
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public int updsh(string id)
       {
           return dal.updsh(id);
       }
       /// <summary>
       /// 查询能验收的人
       /// </summary>
       /// <returns></returns>
       public DataTable SelYsl(string name)
       {
           return dal.SelYsl(name);
       }

       /// <summary>
       /// 装修申请添加
       /// </summary>
       /// <param name="id"></param>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int Repnntj(int id, string mph, string img)
       {
           return dal.Repnntj(id, mph, img);
       }


       /// <summary>
       /// 派遣验收人
       /// </summary>
       /// <param name="id"></param>
       /// <param name="spr"></param>
       /// <returns></returns>
       public int xzspr(string id, string spr)
       {
           return dal.xzspr(id, spr);
       }

       /// <summary>
       /// 更改审核状态
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public int updshSS(string id, string zt)
       {
           return dal.updshSS(id, zt);
       }

       /// <summary>
       /// 通过id查询所有信息
       /// </summary>
       /// <returns></returns>
       public DataTable RepnnIDSel(string id)
       {
           return dal.RepnnIDSel(id);
       }
         /// <summary>
        /// 当业主更改状态时，状态更改为完成审核中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public int up(int id)
       {
           return dal.up(id);
       
       }
       /// <summary>
       /// 装修申请添加
       /// </summary>
       /// <param name="id"></param>
       /// <param name="mph"></param>
       /// <returns></returns>
       public int Repnntj(int id, string mph)
       {
           return dal.Repnntj(id, mph);
       }


       public DataTable RepnnShow()
       {
           return dal.RepnnShow();
       }

       /// <summary>
       /// 根据门牌号查询当前信息
       /// </summary>
       /// <param name="mph"></param>
       /// <returns></returns>
       public DataTable Repnnxx(string mph)
       {
           return dal.Repnnxx(mph);

       }


       public DataTable RepnnShow(string name)
       {
           return dal.RepnnShow(name);
       }
        /// <summary>
        /// 查看业主申请装修状态为审核完成中
        /// </summary>
        /// <returns></returns>
       public DataTable repnnshowwc() {
           return dal.repnnshowwc();
       }

       /// <summary>
       /// 修改状态未已完成
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public int updztwc(string id)
       {
           return dal.updztwc(id);
       }
    }
}
