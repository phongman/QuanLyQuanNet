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
    public partial class frm_QuanLyMay : DevExpress.XtraEditors.XtraForm
    {
        BindingSource computerList = new BindingSource();
        public frm_QuanLyMay()
        {
            InitializeComponent();
            dgvQuanLyMay.DataSource = computerList;
            loadComputer();
            addComputerBinding();
        }
        #region  method
        private void addComputerBinding()
        {
            txtMaMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "MaMay", true, DataSourceUpdateMode.Never));
            txtTenMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "TenMay", true, DataSourceUpdateMode.Never));
            numGiaTien.DataBindings.Add(new Binding("Value", dgvQuanLyMay.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));
             

        
        }

        private void loadComputer()
        {
            dgvQuanLyMay.DataSource = DAO.DAOComputer.LoadComputerList();
        }

        #endregion

        #region  event
        private void btnThemMay_Click(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            double giaTien = Convert.ToDouble(numGiaTien.Value);

            DAO.DAOComputer.InsertComputer(maMay, tenMay, giaTien);
            MessageBox.Show("Thêm món thành công!");
            loadComputer();

        }

        private void btnXoaMay_Click(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            if (MessageBox.Show("Bạn có muốn xóa "+tenMay+ " không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DAO.DAOComputer.DeleteComputer(maMay);
                MessageBox.Show("Xóa món thành công!");
                loadComputer();

            }
        }

        private void btnSuaMay_Click(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            double giaTien = Convert.ToDouble(numGiaTien.Value);

            DAO.DAOComputer.UpdateComputer(maMay, tenMay, giaTien);
            MessageBox.Show("Sửa món thành công!");
            loadComputer();
        }

        private void btnLamMoiMay_Click(object sender, EventArgs e)
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            numGiaTien.Value = numGiaTien.Minimum;
        }
    }

    #endregion
}