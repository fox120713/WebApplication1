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

    public class LzInfo_BLL
    {
        LzInfo_DAL dal = new LzInfo_DAL();

        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }
        public DataTable sel(string name, string type)
        {
            return dal.sel(name, type);
        }
        /// <summary>
        /// 查询离职表所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable LzinfoAll()
        {
            return dal.LzinfoAll();
        }

        public int add(LzInfo lz)
        {
            return dal.add(lz);
        }

        public DataTable cx(string name, string posname, string zt)
        {
            return dal.cx(name, posname, zt);
        
        
        }
        /// <summary>
        /// 根据编号查询离职信息
        /// </summary>
        /// <returns></returns>
        public DataTable selxx(int id) {
            return dal.selxx(id);
        
        
        }
        public int update(LzInfo lz) {
            return dal.update(lz);
        
        }

    }
}
