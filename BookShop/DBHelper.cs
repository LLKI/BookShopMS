using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sunny.UI;
namespace BookShop
{
    public class DBHelper
    {
        //连接串设置
        private readonly static string conStr = "Data Source=DESKTOP-VSMLMCU;Initial Catalog=BookShopDB;Integrated Security=True";

        //连接对象
        private static SqlConnection Con
        {
            get
            {
                var con = new SqlConnection(conStr);
                con.Open();
                return con;
            }
        }

        //指令对象
        private static SqlCommand Cmd
        {
            get
            {
                //var cmd = new SqlCommand(Connection=Con);
                return Con.CreateCommand();
            }
        }

        //增删改的通用方法
        public static bool Update(string sql)
        {
            var cmd = Cmd;
            cmd.CommandText = sql;
            try
            {
                return cmd.ExecuteNonQuery() > 0;
            }
            catch(Exception ex) 
            {
                UIMessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        //返回第一行第一列的查询结果
        public static object SelectForScalar(string sql)
        {
            var cmd = Cmd;
            cmd.CommandText = sql;
            try
            {
                return cmd.ExecuteScalar();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        /// <summary>
        /// 获取DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataAdapter SelectForDataReader(string sql)
        {
            var cmd = Cmd;
            cmd.CommandText = sql;
            try
            {
                return new SqlDataAdapter(sql, cmd.Connection);
            }
            catch(Exception ex)
            {
                UIMessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
