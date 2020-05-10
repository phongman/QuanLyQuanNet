using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quanlyquannet.Views
{
    public partial class frm_NapTien : DevExpress.XtraEditors.XtraForm
    {
        public frm_NapTien()
        {
            InitializeComponent();
        }

        private void frm_NapTien_Load(object sender, EventArgs e)
        {

        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtTenTaiKhoan.Text;
                double tienNap = Convert.ToDouble(txtSoTienNap.Text);
                DAO.DAOAccounts.AddMoney(maKH, tienNap);
                MessageBox.Show("Nạp tiền thành công!", "Thông báo!");
                txtTenTaiKhoan.Text = maKH;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo!");
            }
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string maKH = txtTenTaiKhoan.Text;
            txtThoiGianMoi.Text = DAO.DAOAccounts.GetAccountInfo(maKH).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}