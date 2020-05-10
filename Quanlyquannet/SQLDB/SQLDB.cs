using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Quanlyquannet.SQLDB
{
    public class SQLDB
    {
<<<<<<< HEAD
        static string _ConnectionString = @"Data Source=DESKTOP-EP3U0I3\SQLEXPRESS;Initial Catalog=QuanLyQuanNet01;Integrated Security=True";
=======
        static string _ConnectionString = @"Data Source=DESKTOP-COPK1IA;Initial Catalog=QuanLyQuanNet;Integrated Security=True";
>>>>>>> QL-Dichvu


        static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(_ConnectionString);
            con.Open();
            return con;
        }

        public static void ExecuteNoneQuery(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                using (SqlConnection con = GetConnection())
                {
                    cmd.Connection = GetConnection();
                    //cmd.ExecuteNonQuery();
                }
            }
        }


        public static DataTable GetData(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (SqlConnection con = GetConnection())
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }


    }
}
