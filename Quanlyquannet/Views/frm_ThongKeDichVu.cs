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
    public partial class frm_ThongKeDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThongKeDichVu()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frm_ThongKeDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanNet01DataSet.ThongKe_DichVu' table. You can move, or remove it, as needed.
            
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanNet01DataSet.ThongKe_DichVu' table. You can move, or remove it, as needed.

            this.thongKe_DichVuTableAdapter.Fill(this.quanLyQuanNet01DataSet.ThongKe_DichVu, dtpTuNgay.Value , dtpDenNgay.Value);

            this.reportViewer1.RefreshReport();

        }
    }
}