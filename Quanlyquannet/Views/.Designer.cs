namespace Quanlyquannet.Views
{
    partial class frm_QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyDichVu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.grb = new DevExpress.XtraEditors.GroupControl();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtTenDV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDV = new DevExpress.XtraEditors.TextEdit();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblTenMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaDV = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTimkiemdichvu = new DevExpress.XtraEditors.TextEdit();
            this.lblTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.spbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvQuanlydichvu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb)).BeginInit();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiemdichvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlydichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1248, 58);
            this.panelControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grb
            // 
            this.grb.Controls.Add(this.numDonGia);
            this.grb.Controls.Add(this.txtTenDV);
            this.grb.Controls.Add(this.txtMaDV);
            this.grb.Controls.Add(this.lblTrangThai);
            this.grb.Controls.Add(this.lblTenMay);
            this.grb.Controls.Add(this.lblMaDV);
            this.grb.Controls.Add(this.btnLamMoi);
            this.grb.Controls.Add(this.btnThem);
            this.grb.Controls.Add(this.btnXoa);
            this.grb.Controls.Add(this.btnSua);
            this.grb.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb.Location = new System.Drawing.Point(0, 58);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(613, 675);
            this.grb.TabIndex = 2;
            this.grb.Text = "Thông tin";
            // 
            // numDonGia
            // 
            this.numDonGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDonGia.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDonGia.Location = new System.Drawing.Point(243, 308);
            this.numDonGia.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numDonGia.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(193, 28);
            this.numDonGia.TabIndex = 47;
            this.numDonGia.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(243, 225);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Properties.Appearance.Options.UseFont = true;
            this.txtTenDV.Size = new System.Drawing.Size(193, 28);
            this.txtTenDV.TabIndex = 42;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(243, 151);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Properties.Appearance.Options.UseFont = true;
            this.txtMaDV.Size = new System.Drawing.Size(193, 28);
            this.txtMaDV.TabIndex = 40;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Appearance.Options.UseFont = true;
            this.lblTrangThai.Location = new System.Drawing.Point(145, 310);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 21);
            this.lblTrangThai.TabIndex = 44;
            this.lblTrangThai.Text = "Đơn Giá:";
            // 
            // lblTenMay
            // 
            this.lblTenMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMay.Appearance.Options.UseFont = true;
            this.lblTenMay.Location = new System.Drawing.Point(105, 228);
            this.lblTenMay.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenMay.Name = "lblTenMay";
            this.lblTenMay.Size = new System.Drawing.Size(118, 22);
            this.lblTenMay.TabIndex = 43;
            this.lblTenMay.Text = "Tên Dịch vụ:";
            // 
            // lblMaDV
            // 
            this.lblMaDV.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.Appearance.Options.UseFont = true;
            this.lblMaDV.Location = new System.Drawing.Point(113, 154);
            this.lblMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(110, 22);
            this.lblMaDV.TabIndex = 41;
            this.lblMaDV.Text = "Mã Dịch vụ:";
            this.lblMaDV.Click += new System.EventHandler(this.lblMaDV_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Reset_icon__1_;
            this.btnLamMoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLamMoi.Location = new System.Drawing.Point(456, 568);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 51);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnThem.Location = new System.Drawing.Point(23, 568);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 51);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.delete_icon__1_;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(311, 568);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 51);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.edit_icon;
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(165, 568);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 51);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(613, 58);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 675);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTimkiemdichvu);
            this.groupControl2.Controls.Add(this.lblTenTaiKhoan);
            this.groupControl2.Controls.Add(this.spbTimKiem);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(619, 58);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(629, 100);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // txtTimkiemdichvu
            // 
            this.txtTimkiemdichvu.Location = new System.Drawing.Point(205, 52);
            this.txtTimkiemdichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiemdichvu.Name = "txtTimkiemdichvu";
            this.txtTimkiemdichvu.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemdichvu.Properties.Appearance.Options.UseFont = true;
            this.txtTimkiemdichvu.Size = new System.Drawing.Size(193, 28);
            this.txtTimkiemdichvu.TabIndex = 28;
            this.txtTimkiemdichvu.EditValueChanged += new System.EventHandler(this.txtTimkiemdichvu_EditValueChanged);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(64, 55);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(116, 22);
            this.lblTenTaiKhoan.TabIndex = 26;
            this.lblTenTaiKhoan.Text = "Tên dịch vụ:";
            // 
            // spbTimKiem
            // 
            this.spbTimKiem.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbTimKiem.Appearance.Options.UseFont = true;
            this.spbTimKiem.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Search_icon1;
            this.spbTimKiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.spbTimKiem.Location = new System.Drawing.Point(420, 45);
            this.spbTimKiem.Name = "spbTimKiem";
            this.spbTimKiem.Size = new System.Drawing.Size(140, 35);
            this.spbTimKiem.TabIndex = 27;
            this.spbTimKiem.Text = "Tìm kiếm";
            this.spbTimKiem.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvQuanlydichvu);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(619, 158);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(629, 575);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Kết quả";
            // 
            // dgvQuanlydichvu
            // 
            this.dgvQuanlydichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlydichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlydichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanlydichvu.Location = new System.Drawing.Point(2, 25);
            this.dgvQuanlydichvu.Name = "dgvQuanlydichvu";
            this.dgvQuanlydichvu.RowHeadersWidth = 51;
            this.dgvQuanlydichvu.RowTemplate.Height = 24;
            this.dgvQuanlydichvu.Size = new System.Drawing.Size(625, 548);
            this.dgvQuanlydichvu.TabIndex = 0;
            // 
            // frm_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 733);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grb)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiemdichvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlydichvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grb;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtTimkiemdichvu;
        private DevExpress.XtraEditors.LabelControl lblTenTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton spbTimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvQuanlydichvu;
        private DevExpress.XtraEditors.TextEdit txtTenDV;
        private DevExpress.XtraEditors.TextEdit txtMaDV;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblTenMay;
        private DevExpress.XtraEditors.LabelControl lblMaDV;
        private System.Windows.Forms.NumericUpDown numDonGia;
    }
}