using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class PosBLL
    {
        PosDAL dal = new PosDAL();


        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="POsname"></param>
        /// <returns></returns>
        public int PosInsert(string POsname)
        {
            return dal.PosInsert(POsname);


        }

        /// <summary>
        /// 根据编号修改部门信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Posupdate(string name, int id)
        {
            return dal.Posupdate(name, id);

        }

        /// <summary>
        /// 查询部门表所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable PosAll()
        {
            return dal.PosAll();
        }

        /// <summary>
        /// 根据编号删除部门
        /// </summary>
        /// <returns></returns>
        public int Posdel(int id)
        {
            return dal.Posdel(id);
        }

        /// <summary>
        /// 根据下拉选择查询部门
        /// </summary>
        /// <returns></returns>
        public DataTable PosAll(int PosID)
        {
            return dal.PosAll(PosID);
        }
       
    }
}
