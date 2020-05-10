using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLDB;
namespace Quanlyquannet.DTO
{
    class Food
    {
        public Food(string maDichvu, string tenDichvu, double giaTien)
        {
            this.MaDV = maDichvu;
            this.TenDV = tenDichvu;
            this.Dongia = giaTien;
        }
        public Food(DataRow row)
        {
            this.MaDV = (string)row["MaDV"];
            this.TenDV = row["TenDV"].ToString();
            this.Dongia = Convert.ToDouble(row["Dongia"]);
        }
        private string tenDichvu;
        private string maDichvu;
        private double giaTien;

        public string TenDV { get => tenDichvu; set => tenDichvu = value; }
        public string MaDV { get => maDichvu; set => maDichvu = value; }
        public double Dongia { get => giaTien; set => giaTien = value; }
    }
}
