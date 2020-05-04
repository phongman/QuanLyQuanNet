using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DTO
{
    class TaiKhoanMay
    {


        private string taiKhoan;
        private DateTime gioVao;
        private double thoiGianSuDung;

        public TaiKhoanMay(string taiKhoan, DateTime gioVao, double thoiGianSuDung)
        {
            this.TaiKhoan = taiKhoan;
            this.GioVao = gioVao;
            this.ThoiGianSuDung = thoiGianSuDung;



        }
        public TaiKhoanMay()
        {
            
        }

        public TaiKhoanMay(DataRow row)
        {
            this.TaiKhoan = (string)row["TaiKhoan"];
            this.GioVao = Convert.ToDateTime(row["GioVao"]);
            this.ThoiGianSuDung = Convert.ToDouble(row["ThoiGianSuDung"]);
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public DateTime GioVao { get => gioVao; set => gioVao = value; }
        public double ThoiGianSuDung { get => thoiGianSuDung; set => thoiGianSuDung = value; }
    }
}
