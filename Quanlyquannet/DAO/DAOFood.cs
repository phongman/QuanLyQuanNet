using Quanlyquannet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quanlyquannet.DAO
{
    class DAOFood
    {  
        public static List<Food> SearchFoodByName(string name)
        {
            List<Food> foodList = new List<Food>();
            string queryString = $"SELECT * FROM DichVu where TenDV like N'%{name}%'";
            SqlCommand cmd = new SqlCommand(queryString);
            //cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                Food food = new Food(item);
                foodList.Add(food);

            }

            return foodList;
        }
        public static void DeleteDichvu(string id)
        {
            SqlCommand cmd = new SqlCommand("Delete_Dichvu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idDichvu", id);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);

            
        }



        public static void UpdateDichvu(string maDichvu, string tenDichvu, double giaTien)
        {
            SqlCommand cmd = new SqlCommand("Update_Dichvu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idDichvu", maDichvu);
            cmd.Parameters.AddWithValue("@tenDichvu", tenDichvu);
            cmd.Parameters.AddWithValue("@giaTien", giaTien);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);

        }

        public static List<Food> LoadFoodList()
        {
            List<Food> foodList = new List<Food>();
            string queryString = "SELECT * FROM DichVu";
            SqlCommand cmd = new SqlCommand(queryString);
            //cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                Food food = new Food(item);
                foodList.Add(food);

            }

            return foodList;
        }

        public static void InsertDichvu(string maDichvu, string tenDichvu, double giaTien)
        {
            SqlCommand cmd = new SqlCommand("Insert_Dichvu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idDichvu", maDichvu);
            cmd.Parameters.AddWithValue("@tenDichvu", tenDichvu);
            cmd.Parameters.AddWithValue("@giaTien", giaTien);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd); 
        }
    }
}
