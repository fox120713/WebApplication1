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
    public class CarInfo_BLL
    {
        CarInfo_DAL dal = new CarInfo_DAL();

        public DataTable sel()//查询绑定
        {
            return dal.sel();
        }

        public DataTable sel(string id)
        {
            return dal.sel(id);
        }

        public DataTable seled()//查询绑定
        {
            return dal.seled();
        }

        public int update(CarInfo car)//空车位修改
        {
            return dal.update(car);
        }

    }
}
