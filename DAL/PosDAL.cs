using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class PosDAL
    {
        DBHelper db = new DBHelper();
        StringBuilder sb = new StringBuilder();

        public int PosInsert(string POsname)
        {
            sb.Clear();
            sb.AppendFormat("insert into Pos values('{0}')", POsname);
            return db.ExecuteNonQuery(sb.ToString());
        }

        /// <summary>
        /// 根据编号修改部门信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Posupdate(string name, int id)
        {
            sb.Clear();
            sb.AppendFormat("update Pos set PosName='{0}' where PosID='{1}'", name, id);
            return db.ExecuteNonQuery(sb.ToString());


        }

        /// <summary>
        /// 查询部门表所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable PosAll() //查询，绑定
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Pos");
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 根据下拉选择查询部门
        /// </summary>
        /// <returns></returns>
        public DataTable PosAll(int PosID)
        {
            sb.Clear();
            sb.Append("select * from Pos");
            sb.AppendFormat(" where PosID='{0}'", PosID);
            return db.GetTable(sb.ToString());
        }

        /// <summary>
        /// 根据编号删除部门
        /// </summary>
        /// <returns></returns>
        public int Posdel(int id)
        {
            sb.Clear();
            sb.AppendFormat("delete from Pos where PosID='{0}'", id);
            return db.ExecuteNonQuery(sb.ToString());

        }

    }
}
