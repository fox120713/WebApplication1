using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=PRO;Integrated Security=True");
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] pms)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = type;//sql 语句
            if (pms.Length > 0)
            {
                foreach (var item in pms)
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //返回受影响行数
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        /// <summary>
        /// 返回受影响行数的第二种调用方式，提前指定好执行文本的方式
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            return ExecuteNonQuery(sql, CommandType.Text, pms);

        }


        //返回表
        /// <summary>
        /// 返回一张表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public DataTable GetTable(string sql, CommandType type, params SqlParameter[] pms)
        {
            //返回受影响行数
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            //7.转换完毕后需要创建一个仓库用于存储转换出来的表
            //创建一个数据表对象
            DataTable dt = new DataTable();
            //把转换出来的表放到这个里面去
            sda.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 返回一张表的第二种方式,提前指定好执行文本的方式
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public DataTable GetTable(string sql, params SqlParameter[] pms)
        {
            return GetTable(sql, CommandType.Text, pms);
        }

        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public  object ExecuteScalar(string sql, CommandType type, params SqlParameter[] pms)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = type;//sql 语句
            if (pms.Length > 0)
            {
                foreach (var item in pms)
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //返回受影响行数
            object i = cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        /// <summary>
        /// 返回首行首列的第二种方式,提前指定好执行文本的方式
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public  object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            return ExecuteScalar(sql, CommandType.Text, pms);
        }


        /// <summary>
        /// 返回游标对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public SqlDataReader GetReader(string sql, CommandType type, params SqlParameter[] pms)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = type;//sql 语句
            if (pms.Length > 0)
            {
                foreach (var item in pms)
                {
                    if (item != null)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
            }
            //返回受影响行数
            SqlDataReader i = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            return i;

        }
        /// <summary>
        /// 返回游标对象第二种方式，提前指定好执行文本的方式
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public SqlDataReader GetReader(string sql, params SqlParameter[] pms)
        {
            return GetReader(sql, CommandType.Text, pms);
        }
    }
}
