using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class DopantDAL
    {
        DBHelper db = new DBHelper();
        StringBuilder sb = new StringBuilder();


        //<summary>
        //费用明细表查询
        //</summary>
        //<returns></returns>
        public DataTable DopantALL(string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from dopant join PayType on dopant.PayID=PayType.PayID where   UserName='{0}'", name);
            return db.GetTable(sb.ToString());

        }
        public int DopantInsert(string name, string Usercell, int payid, int money)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("insert into Dopant values('{0}','{1}','{2}','{3}','已缴费',getdate(),'{4}')", name, Usercell, payid, money, name);
            return db.ExecuteNonQuery(sb.ToString());
        }

        public DataTable table()
        {
            sb.Clear();
            sb.AppendLine("SELECT DopantID,UserName,UserCell,PayName,DopantMoney,DopantBool,DopantTime,DopantBlr FROM Dopant join PayType on Dopant.PayID=PayType.PayID");
            return db.GetTable(sb.ToString());
        }

        //添加收费
        public int tj(DopantMODEL a)
        {
            sb.Clear();
            sb.AppendFormat("insert Dopant(UserName,UserCell,PayID,DopantMoney) values('{0}','{1}','{2}','{3}')", a.UserName, a.UserCell, a.PayID, a.DopantMoney);
            return db.ExecuteNonQuery(sb.ToString());
        }

        public DataTable bd2()
        {
            sb.Clear();
            sb.AppendFormat("select distinct DopantBool from Dopant");
            return db.GetTable(sb.ToString());
        }

        public DataTable jfcx(string ld, int lx, string zt)
        {
            sb.Clear();
            sb.AppendLine("select DopantID,UserName,UserCell,PayName,DopantMoney,DopantBool,DopantTime,DopantBlr FROM Dopant join PayType on Dopant.PayID=PayType.PayID");
            if (ld != "" && zt != "全部" && lx != 0)
            {
                sb.AppendFormat(" where UserCell='{0}' and DopantBool='{1}' and Dopant.PayID='{2}'", ld, zt, lx);
            }
            else if (lx != 0 && zt != "全部")
            {
                sb.AppendFormat(" where Dopant.PayID='{0}' and DopantBool='{1}'", lx, zt);
            }
            else if (ld != "" && lx != 0)
            {
                sb.AppendFormat(" where UserCell='{0}' and Dopant.PayID='{1}'", ld, lx);
            }
            else if (ld != "" && zt != "全部")
            {
                sb.AppendFormat(" where UserCell='{0}' and DopantBool='{1}'", ld, zt);
            }
            else if (ld != "")
            {
                sb.AppendFormat(" where UserCell='{0}'", ld);
            }
            else if (lx != 0)
            {
                sb.AppendFormat(" where Dopant.PayID='{0}'", lx);
            }
            else if (zt != "全部")
            {
                sb.AppendFormat(" where DopantBool='{0}'", zt);
            }
            return db.GetTable(sb.ToString());
        }

        //<summary>
        //费用明细表查询
        //</summary>
        //<returns></returns>
        public DataTable DopantALL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from dopant join PayType on dopant.PayID=PayType.PayID where UserCell='1-1-101'");
            return db.GetTable(sb.ToString());


        }

        //修改收费
        public int xg(string name, int id)
        {
            sb.Clear();
            sb.AppendFormat("update Dopant set DopantBool='已缴费' , DopantTime=GETDATE() ,DopantBlr='{0}' where DopantID={1}", name, id);
            return db.ExecuteNonQuery(sb.ToString());
        }
        /// <summary>
        /// 根据业主名称查询缴费
        /// </summary>
        /// <returns></returns>
        public DataTable DopantALL(string name, string zt, string typename)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select * from dopant join PayType on dopant.PayID=PayType.PayID");
            if (name!=null && typename=="全部" && zt=="全部")
            {
                sb.AppendFormat(" where  UserName='{0}'", name);
            }
            else if (name != null && typename == "全部" && zt != "全部")
            {
                sb.AppendFormat("  where  UserName='{0}' and DopantBool='{1}'", name,zt);
            }
            else if (name != null && typename != "全部" && zt == "全部")
            {
                sb.AppendFormat("  where  UserName='{0}' and PayName='{1}'", name,typename);
            }
            else if (name != null && typename != "全部" && zt != "全部")
            {
                sb.AppendFormat("  where  UserName='{0}' and  DopantBool='{1}' and PayName='{2}'", name,zt,typename);
            }
            return db.GetTable(sb.ToString());
        }
        public DataTable cxld(string name)
        {
            sb.Clear();
            sb.AppendFormat("select UserCell from UserInfo where UserName='{0}'", name);
            return db.GetTable(sb.ToString());
        }
        public DataTable cxxm(string name)
        {
            sb.Clear();
            sb.AppendFormat("select count(*) from UserInfo where UserName='{0}'", name);
            return db.GetTable(sb.ToString());
        }

        public DataTable xs(int id)
        {
            sb.Clear();
            sb.AppendFormat("select UserName,UserCell,PayName,DopantMoney from Dopant join PayType on Dopant.PayID=PayType.PayID where DopantID=" + id);
            return db.GetTable(sb.ToString());
        }

        public int xg(int id)
        {
            sb.Clear();
            sb.AppendFormat("update Dopant set DopantBool='已缴费' , DopantTime=GETDATE() where DopantID={0}",  id);
            return db.ExecuteNonQuery(sb.ToString());
        }

    }
}
