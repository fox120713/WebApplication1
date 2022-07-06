using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class LzInfo_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();

        public DataTable sel()//查询绑定
        {
            sql.AppendLine("select * from LzInfo");
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string name, string type)
        {
            sql.Clear();
            if (type == "全部" && name == null)
            {
                sql.AppendLine("select * from LzInfo");
            }
            else
            {
                sql.AppendFormat("select * from LzInfo where YgName='%{0}%' or PosName= '%{1}%'", name, type);
            }
            return db.GetTable(sql.ToString());
        }

        /// <summary>
        /// 查询离职表所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable LzinfoAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from LzInfo");
            return db.GetTable(sb.ToString());

        }

        public int add(LzInfo lz)
        {
            sql.Clear();
            sql.AppendFormat("insert into LzInfo values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8} ')", lz.YgId1, lz.YgName1, lz.PosName1, lz.YgRdate1, lz.YgSdate1, lz.YGlzYY1, lz.YgBool1, lz.YGlzYY1, lz.YgLdate1);
            return db.ExecuteNonQuery(sql.ToString());
        }

        public DataTable cx(string name, string posname, string zt)
        {
            sql.Clear();
            sql.AppendLine("select * from LzInfo");
            if (name != null && posname == "全部" && zt == "全部")
            {
                sql.AppendFormat(" where YgName like '%{0}%'", name);
            }
           else  if (name == "" && posname != "全部" && zt == "全部")
            {
                sql.AppendFormat(" where PosName='{0}'", posname);
            }
            else if (name == "" && posname != "全部" && zt == "全部")
            {
                sql.AppendFormat(" where PosName='{0}'", posname);
            }
            else if (name == "" && posname == "全部" && zt != "全部")
            {
                sql.AppendFormat(" where YgBool='{0}'", zt);
            }
            else if (name !="" && posname != "全部" && zt != "全部")
            {
                sql.AppendFormat(" where YgName like '%{0}%' and PosName='{1}' and YgBool='{2}' ", name, posname, zt);
            }
            return db.GetTable(sql.ToString());


        }
        /// <summary>
        /// 根据编号查询离职信息
        /// </summary>
        /// <returns></returns>
        public DataTable selxx(int id) {
            sql.Clear();
            sql.AppendFormat("select * from LzInfo where ID='{0}'",id);
            return db.GetTable(sql.ToString());
        
        
        }
        /// <summary>
        /// 修改离职状态
        /// </summary>
        /// <returns></returns>
        public int update(LzInfo lz) {
            sql.Clear();
            sql.AppendFormat("update LzInfo set YgBool='{0}',Ygyy='{1}',YgLdate=GETDATE() where ID='{2}'",lz.YgBool1,lz.Ygyy1,lz.ID1);
            return db.ExecuteNonQuery(sql.ToString());
        
        
        }

    }
}
