namespace Quanlyquannet.Views
{
    partial class frm_ThongKeDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKeDichVu));
            this.thongKeDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.quanLyQuanNet01DataSet = new Quanlyquannet.QuanLyQuanNet01DataSet();
            this.quanLyQuanNet01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeDichVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thongKe_DichVuTableAdapter = new Quanlyquannet.QuanLyQuanNet01DataSetTableAdapters.ThongKe_DichVuTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKe_DichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanNet01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanNet01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDichVuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe_DichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // thongKeDichVuBindingSource
            // 
            this.thongKeDichVuBindingSource.DataMember = "ThongKe_DichVu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpDenNgay);
            this.groupControl1.Controls.Add(this.dtpTuNgay);
            this.groupControl1.Controls.Add(this.lblTenTaiKhoan);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1274, 106);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Thông tin";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint_1);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(471, 29);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(86, 24);
            this.lblTenTaiKhoan.TabIndex = 7;
            this.lblTenTaiKhoan.Text = "Từ ngày:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(710, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Đến ngày:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Actions_button_cancel_icon;
            this.btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnHuy.Location = new System.Drawing.Point(667, 553);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(151, 51);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            // 
            // btnDongY
            // 
            this.btnDongY.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Appearance.Options.UseFont = true;
            this.btnDongY.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Accept_icon;
            this.btnDongY.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnDongY.Location = new System.Drawing.Point(470, 553);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(151, 51);
            this.btnDongY.TabIndex = 29;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.reportViewer1);
            this.panelControl1.Location = new System.Drawing.Point(12, 115);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1274, 432);
            this.panelControl1.TabIndex = 32;
            // 
            // quanLyQuanNet01DataSet
            // 
            this.quanLyQuanNet01DataSet.DataSetName = "QuanLyQuanNet01DataSet";
            this.quanLyQuanNet01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanNet01DataSetBindingSource
            // 
            this.quanLyQuanNet01DataSetBindingSource.DataSource = this.quanLyQuanNet01DataSet;
            this.quanLyQuanNet01DataSetBindingSource.Position = 0;
            // 
            // thongKeDichVuBindingSource1
            // 
            this.thongKeDichVuBindingSource1.DataMember = "ThongKe_DichVu";
            this.thongKeDichVuBindingSource1.DataSource = this.quanLyQuanNet01DataSetBindingSource;
            // 
            // thongKe_DichVuTableAdapter
            // 
            this.thongKe_DichVuTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongKe_DichVuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlyquannet.Views.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1270, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKe_DichVuBindingSource
            // 
            this.ThongKe_DichVuBindingSource.DataMember = "ThongKe_DichVu";
            this.ThongKe_DichVuBindingSource.DataSource = this.quanLyQuanNet01DataSet;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(391, 59);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(240, 23);
            this.dtpTuNgay.TabIndex = 22;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(650, 59);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(240, 23);
            this.dtpDenNgay.TabIndex = 23;
            // 
            // frm_ThongKeDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 674);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongKeDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_ThongKeDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanNet01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanNet01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDichVuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe_DichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource thongKeDichVuBindingSource;
        private System.Windows.Forms.BindingSource thongKeDichVuBindingSource1;
        private System.Windows.Forms.BindingSource quanLyQuanNet01DataSetBindingSource;
        private QuanLyQuanNet01DataSet quanLyQuanNet01DataSet;
        private QuanLyQuanNet01DataSetTableAdapters.ThongKe_DichVuTableAdapter thongKe_DichVuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKe_DichVuBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
    }
}