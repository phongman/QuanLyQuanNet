using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace Quanlyquannet.Models
{
    class LoginMod
    {
        //Khai báo biến
        protected string user { get; set; }
        protected string pass { get; set; }

        //hàm khởi tạo kiểm tra đăng nhập
        public LoginMod(string _user,string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }
        //kiểm tra đăng nhập
        public string CheckDangNhap()
        {
            string str = "";
            // truyền vào 2 bieesn IdDangNhap và MatKhau
            string[] para = new string[2] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Models.connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
