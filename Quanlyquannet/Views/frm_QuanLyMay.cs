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
using Quanlyquannet.DAO;
namespace Quanlyquannet.Views
{
    public partial class frm_QuanLyMay : DevExpress.XtraEditors.XtraForm
    {
        BindingSource computerList = new BindingSource();
        public frm_QuanLyMay()
        {
            InitializeComponent();
            dgvQuanLyMay.DataSource = computerList;
            refeshComputer();

        }
        #region  method
        private void addComputerBinding()
        {
            clearBinding();
            txtMaMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "MaMay", true, DataSourceUpdateMode.Never));
            txtTenMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "TenMay", true, DataSourceUpdateMode.Never));
            numGiaTien.DataBindings.Add(new Binding("Value", dgvQuanLyMay.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));
        }

        private void clearBinding()
        {
            txtMaMay.DataBindings.Clear();
            txtTenMay.DataBindings.Clear();
            numGiaTien.DataBindings.Clear();
        }

        private void loadComputer()
        {
            
            dgvQuanLyMay.DataSource = DAO.DAOComputer.LoadComputerList();  
        }


        private void refeshComputer()
        {
            loadComputer();
            addComputerBinding();
        }


        #endregion

        #region  event
        private void btnThemMay_Click(object sender, EventArgs e)
        {
            try
            {
                string maMay = txtMaMay.Text;
                string tenMay = txtTenMay.Text;
                double giaTien = Convert.ToDouble(numGiaTien.Value);

                DAO.DAOComputer.InsertComputer(maMay, tenMay, giaTien);
                MessageBox.Show("Thêm máy thành công!","Thông báo!");
                refeshComputer();

            }
            catch
            {
                MessageBox.Show("Mã máy đã tồn tại.Thêm máy thất bại", "Thông báo!");
                refeshComputer();
            }
             
            
            


        }

        private void btnXoaMay_Click(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            var result = MessageBox.Show("Bạn có muốn xóa " + tenMay + " không?", "Thông báo", MessageBoxButtons.OKCancel);
            if ( result == DialogResult.OK)
            {
                DAO.DAOComputer.DeleteComputer(maMay);
                MessageBox.Show("Xóa máy thành công!", "Thông báo!");
                refeshComputer();


            }
        }

        private void btnSuaMay_Click(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            double giaTien = Convert.ToDouble(numGiaTien.Value);

            DAO.DAOComputer.UpdateComputer(maMay, tenMay, giaTien);
            MessageBox.Show("Sửa máy thành công!", "Thông báo!");
            refeshComputer();

        }

        private void btnLamMoiMay_Click(object sender, EventArgs e)
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            numGiaTien.Value = numGiaTien.Minimum;
             
        }

        private void txtMaMay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numGiaTien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_QuanLyMay_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiemMay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemMay_Click(object sender, EventArgs e)
        {
            computerList.DataSource = DAOComputer.SearchComputerByName(txtTimKiemMay.Text);
            dgvQuanLyMay.DataSource = computerList;
            addComputerBinding();
        }
    }

    #endregion
}