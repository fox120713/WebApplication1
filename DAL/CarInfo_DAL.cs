using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MODEL;
namespace DAL
{
    public class CarInfo_DAL
    {
        StringBuilder sql = new StringBuilder();
        DBHelper db = new DBHelper();

        public DataTable sel()//查询绑定
        {
            sql.Clear();
            sql.AppendLine("select * from CarInfo where CarSta=0");
            return db.GetTable(sql.ToString());
        }

        public DataTable sel(string id)
        {
            sql.Clear();
            if (id=="")
            {
            sql.AppendLine("select * from CarInfo where CarSta=0");
                
            }
            else
            {
                sql.AppendFormat("select * from CarInfo where CarSta=0 and CarBH={0}", int.Parse(id));
            }
            return db.GetTable(sql.ToString());
        }

        public DataTable seled()//绑定表格
        {
            sql.Clear();
            sql.AppendFormat("select distinct(typee) from CarInfo ");
            return db.GetTable(sql.ToString());
        }

        public int update(CarInfo car)//空车位修改
        {
            sql.Clear();
            sql.AppendFormat("update [CarInfo] set Typee='{0}', CarNum='{1}',UserID='{2}',UserPhone='{3}',CarSta={4} where CarBH={5}", car.Typee1,car.CarNum1, car.UserID1, car.UserPhone1, car.CarSta1, car.CarBH1);
            return db.ExecuteNonQuery(sql.ToString());
        }

    }
}
