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
    public class Ann_BLL
    {
        Ann_DAL dal = new Ann_DAL();

        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }
        /// <summary>
        /// 查询所有待审核数据
        /// </summary>
        /// <returns></returns>
        public DataTable seldsh() {
            return dal.seldsh();
        }

        public DataTable AnnAll()
        {
            return dal.AnnAll();
        }
        public DataTable AnnAll(string id)
        {
            return dal.AnnAll(id);
        }
        public DataTable AnnOrderBy()
        {
            return dal.AnnOrderBy();
        }

        public DataTable selzt()//状态查询
        {
            return dal.selzt();
        }

        public DataTable sel(string title, string zt)
        {
            return dal.sel(title, zt);
        }

        public int add(Ann ann)//添加
        {
            return dal.add(ann);
        }
      /// <summary>
        /// 根据id查询信息
        /// </summary>
        /// <returns></returns>
        public DataTable selid(int id) {
            return dal.selid(id);
        
        }
        /// <summary>
        /// 根据编号修改
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int update(string name, string sqrname, int id)
        {
            return dal.update(name,sqrname,id);
        
        
        }
        public int jj(string name, int id,string yy)
        {
            return dal.jj(name,id,yy);
        
        }
                /// <summary>
        /// 根据日期，状态查询
        /// </summary>
        /// <returns></returns>
        public DataTable seld(string zt) {
            return dal.seld(zt);
        
        
        }
                 /// <summary>
        /// 根据id查询信息
        /// </summary>
        /// <returns></returns>
        public DataTable selid1(int id) {
            return dal.selid1(id);
        
        }
    }
}
