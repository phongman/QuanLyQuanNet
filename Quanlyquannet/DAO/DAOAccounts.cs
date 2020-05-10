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
    class DAOAccounts
    {
        public static void DeleteAccount(string maKH)
        {
            SqlCommand cmd = new SqlCommand("Delete_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idKH", maKH);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public static List<Accounts> LoadAccountsList()
        {
            List<Accounts> accountsList = new List<Accounts>();
            SqlCommand cmd = new SqlCommand("ThongTin_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                Accounts account = new Accounts(item);
                accountsList.Add(account);

            }

            return accountsList;
        }

        public static void InsertAccount(string maKH, string matKhau, double tien, int quyen)
        {
            SqlCommand cmd = new SqlCommand("Insert_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@matKhau", matKhau);
            cmd.Parameters.AddWithValue("@tien", tien);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public static void UpdateAccount(string maKH, double tien, int quyen)
        {
            SqlCommand cmd = new SqlCommand("Update_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@tien", tien);
            cmd.Parameters.AddWithValue("@quyen", quyen);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static double GetAccountInfo(string maKH)
        {
            SqlCommand cmd = new SqlCommand("Info_account_byID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", maKH);
            DataTable dt = SQLDB.SQLDB.GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDouble(dt.Rows[0][2]);
            }
            else return 0;
        }
        public static void AddMoney(string maKH, double tienNap)
        {
            SqlCommand cmd = new SqlCommand("Add_Money");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@tienNap", tienNap);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
