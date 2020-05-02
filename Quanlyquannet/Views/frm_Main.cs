using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quanlyquannet.Views;

namespace Quanlyquannet
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue"; //Giao diện hiển thị đầu tiên
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnNapTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_NapTien = new frm_NapTien();
            frm_NapTien.ShowDialog();
        }

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void numericChartRangeControlClient3_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnQuanLyMay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyMay = new frm_QuanLyMay();
            frm_QuanLyMay.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeDoanhThu = new frm_ThongKeDoanhThu();
            frm_ThongKeDoanhThu.ShowDialog();
        }

        private void bbtnGioSuDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeGioSuDung = new frm_ThongKeGioSuDung();
            frm_ThongKeGioSuDung.ShowDialog();
        }

        private void bbtnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeDichVu = new frm_ThongKeDichVu();
            frm_ThongKeDichVu.ShowDialog();
        }

        private void bbtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbtnQuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyTaiKhoan = new frm_QuanLyTaiKhoan();
            frm_QuanLyTaiKhoan.ShowDialog();
        }

        private void bbtnQuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyDichVu = new frm_QuanLyDichVu();
            frm_QuanLyDichVu.ShowDialog();
        }
    }
    
}
