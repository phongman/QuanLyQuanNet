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
using System.Security.Cryptography;

namespace Quanlyquannet.Views
{
    public partial class frm_QuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        BindingSource accountsList = new BindingSource();
        public frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
            dgvQuanLyTaiKhoan.DataSource = accountsList;
            refreshAccounts();
        }

        private void addAccountsBindings()
        {
            clearBinding();
            txtETenTaiKhoan.DataBindings.Add(new Binding("Text", dgvQuanLyTaiKhoan.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", dgvQuanLyTaiKhoan.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            txtTien.DataBindings.Add(new Binding("Text", dgvQuanLyTaiKhoan.DataSource, "Tien", true, DataSourceUpdateMode.Never));
            nudQuyen.DataBindings.Add(new Binding("Text", dgvQuanLyTaiKhoan.DataSource, "Quyen", true, DataSourceUpdateMode.Never));
        }

        private void clearBinding()
        {
            txtETenTaiKhoan.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtTien.DataBindings.Clear();
            nudQuyen.DataBindings.Clear();
        }

        private void loadAccounts()
        {
            dgvQuanLyTaiKhoan.DataSource = DAO.DAOAccounts.LoadAccountsList();
        }


        private void refreshAccounts()
        {
            loadAccounts();
            addAccountsBindings();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtETenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTien.Text = "";
            nudQuyen.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtETenTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                double tien = Convert.ToDouble(txtTien.Text);
                int quyen = (int)nudQuyen.Value;

                byte[] temp = ASCIIEncoding.ASCII.GetBytes(matKhau);
                byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hashPass = "";
                foreach (byte item in hashData)
                {
                    hashPass += item;
                }
                DAO.DAOAccounts.InsertAccount(maKH, hashPass, tien, quyen);
                MessageBox.Show("Thêm người dùng thành công!", "Thông báo!");
                refreshAccounts();
            }
            catch
            {
                MessageBox.Show("Mã khách hàng đã tồn tại.Thêm người dùng thất bại", "Thông báo!");
                refreshAccounts();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtETenTaiKhoan.Text;
                double tien = Convert.ToDouble(txtTien.Text);
                int quyen = (int)nudQuyen.Value;
                DAO.DAOAccounts.UpdateAccount(maKH, tien, quyen);
                MessageBox.Show("Sửa thông tin người dùng thành công!", "Thông báo!");
                refreshAccounts();
            }
            catch
            {
                    MessageBox.Show("Sửa thông tin người dùng thất bại", "Thông báo!");
                    refreshAccounts();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtETenTaiKhoan.Text;
            if (MessageBox.Show("Bạn có muốn xóa " + maKH + " không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DAO.DAOAccounts.DeleteAccount(maKH);
                MessageBox.Show("Xóa người dùng thành công!", "Thông báo!");
                refreshAccounts();


            }
        }
    }
}