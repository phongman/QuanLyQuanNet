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
using Quanlyquannet.DTO;

namespace Quanlyquannet.Views
{
    public partial class frm_QuanLyDichVu : DevExpress.XtraEditors.XtraForm
    { 
        BindingSource foodList = new BindingSource();
        public frm_QuanLyDichVu()
        {
            InitializeComponent();
            dgvQuanlydichvu.DataSource = foodList;
            
            refeshFood();

        }
        #region  method
         

        private void addFoodBinding()
        {
            clearBinding();
            txtMaDV.DataBindings.Add(new Binding("Text", dgvQuanlydichvu.DataSource, "MaDV", true, DataSourceUpdateMode.Never));  
            txtTenDV.DataBindings.Add(new Binding("Text", dgvQuanlydichvu.DataSource, "TenDV", true, DataSourceUpdateMode.Never));
            numDonGia.DataBindings.Add(new Binding("Value", dgvQuanlydichvu.DataSource, "Dongia", true, DataSourceUpdateMode.Never));

            dgvQuanlydichvu.Columns[0].HeaderText = "Tên dịch vụ";
            dgvQuanlydichvu.Columns[1].HeaderText = "Mã dịch vụ"; 
            dgvQuanlydichvu.Columns[2].HeaderText = "Đơn giá";

        }
        private void clearBinding()
        {
            txtMaDV.DataBindings.Clear();
            txtTenDV.DataBindings.Clear();
            numDonGia.DataBindings.Clear();
        }

        private void loadFood()
        {

            dgvQuanlydichvu.DataSource = DAO.DAOFood.LoadFoodList();
        }


        private void refeshFood()
        {
            loadFood();
            addFoodBinding();
        }


        #endregion

        #region event
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichvu = txtMaDV.Text;
                string tenDichvu = txtTenDV.Text;
                double giaTien = Convert.ToDouble(numDonGia.Value);

                DAO.DAOFood.InsertDichvu(maDichvu, tenDichvu, giaTien);
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo!");
                refeshFood();

            }
            catch
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại.Thêm dịch vụ thất bại", "Thông báo!");
                refeshFood();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDichvu = txtMaDV.Text;
            string tenDichvu = txtTenDV.Text;
            double giaTien = Convert.ToDouble(numDonGia.Value);

            DAO.DAOFood.UpdateDichvu(maDichvu, tenDichvu, giaTien);
            MessageBox.Show("Sửa Dịch vụ thành công!", "Thông báo!");
            refeshFood();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDichvu = txtMaDV.Text;
            string tenDichvu = txtTenDV.Text;
            var result = MessageBox.Show("Bạn có muốn xóa " + tenDichvu + " không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DAO.DAOFood.DeleteDichvu(maDichvu);
                MessageBox.Show("Xóa Dịch vụ thành công!", "Thông báo!");
                refeshFood(); 

            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            numDonGia.Value = numDonGia.Minimum;
        }

        private void frm_QuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void lblMaDV_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        { 
            foodList.DataSource = DAOFood.SearchFoodByName(txtTimkiemdichvu.Text);
            dgvQuanlydichvu.DataSource = foodList;
            addFoodBinding(); 
        }
        #endregion

        private void txtTimkiemdichvu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}