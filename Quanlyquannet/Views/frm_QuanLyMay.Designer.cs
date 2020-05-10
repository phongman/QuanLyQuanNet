namespace Quanlyquannet.Views
{
    partial class frm_QuanLyMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyMay));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.numGiaTien = new System.Windows.Forms.NumericUpDown();
            this.txtMaMay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMay = new DevExpress.XtraEditors.TextEdit();
            this.lblTenMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaMay = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoiMay = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMay = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMay = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaMay = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTimKiemMay = new DevExpress.XtraEditors.TextEdit();
            this.lblTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiemMay = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvQuanLyMay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyMay)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1292, 58);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MÁY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numGiaTien);
            this.groupControl1.Controls.Add(this.txtMaMay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTenMay);
            this.groupControl1.Controls.Add(this.lblTenMay);
            this.groupControl1.Controls.Add(this.lblMaMay);
            this.groupControl1.Controls.Add(this.btnLamMoiMay);
            this.groupControl1.Controls.Add(this.btnThemMay);
            this.groupControl1.Controls.Add(this.btnXoaMay);
            this.groupControl1.Controls.Add(this.btnSuaMay);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(613, 595);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // numGiaTien
            // 
            this.numGiaTien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGiaTien.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numGiaTien.Location = new System.Drawing.Point(247, 304);
            this.numGiaTien.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numGiaTien.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numGiaTien.Name = "numGiaTien";
            this.numGiaTien.Size = new System.Drawing.Size(193, 28);
            this.numGiaTien.TabIndex = 46;
            this.numGiaTien.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numGiaTien.ValueChanged += new System.EventHandler(this.numGiaTien_ValueChanged);
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(247, 157);
            this.txtMaMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMay.Properties.Appearance.Options.UseFont = true;
            this.txtMaMay.Size = new System.Drawing.Size(193, 28);
            this.txtMaMay.TabIndex = 44;
            this.txtMaMay.EditValueChanged += new System.EventHandler(this.txtMaMay_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 157);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Mã máy: ";
            // 
            // txtTenMay
            // 
            this.txtTenMay.Location = new System.Drawing.Point(247, 232);
            this.txtTenMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMay.Properties.Appearance.Options.UseFont = true;
            this.txtTenMay.Size = new System.Drawing.Size(193, 28);
            this.txtTenMay.TabIndex = 40;
            // 
            // lblTenMay
            // 
            this.lblTenMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMay.Appearance.Options.UseFont = true;
            this.lblTenMay.Location = new System.Drawing.Point(134, 306);
            this.lblTenMay.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenMay.Name = "lblTenMay";
            this.lblTenMay.Size = new System.Drawing.Size(77, 22);
            this.lblTenMay.TabIndex = 43;
            this.lblTenMay.Text = "Giá tiền:";
            // 
            // lblMaMay
            // 
            this.lblMaMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMay.Appearance.Options.UseFont = true;
            this.lblMaMay.Location = new System.Drawing.Point(129, 232);
            this.lblMaMay.Margin = new System.Windows.Forms.Padding(4);
            this.lblMaMay.Name = "lblMaMay";
            this.lblMaMay.Size = new System.Drawing.Size(82, 21);
            this.lblMaMay.TabIndex = 41;
            this.lblMaMay.Text = "Tên máy:";
            // 
            // btnLamMoiMay
            // 
            this.btnLamMoiMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiMay.Appearance.Options.UseFont = true;
            this.btnLamMoiMay.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Reset_icon__1_;
            this.btnLamMoiMay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLamMoiMay.Location = new System.Drawing.Point(460, 509);
            this.btnLamMoiMay.Name = "btnLamMoiMay";
            this.btnLamMoiMay.Size = new System.Drawing.Size(125, 51);
            this.btnLamMoiMay.TabIndex = 39;
            this.btnLamMoiMay.Text = "Làm mới";
            this.btnLamMoiMay.Click += new System.EventHandler(this.btnLamMoiMay_Click);
            // 
            // btnThemMay
            // 
            this.btnThemMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMay.Appearance.Options.UseFont = true;
            this.btnThemMay.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Actions_list_add_icon;
            this.btnThemMay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnThemMay.Location = new System.Drawing.Point(27, 509);
            this.btnThemMay.Name = "btnThemMay";
            this.btnThemMay.Size = new System.Drawing.Size(125, 51);
            this.btnThemMay.TabIndex = 36;
            this.btnThemMay.Text = "Thêm";
            this.btnThemMay.Click += new System.EventHandler(this.btnThemMay_Click);
            // 
            // btnXoaMay
            // 
            this.btnXoaMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMay.Appearance.Options.UseFont = true;
            this.btnXoaMay.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.delete_icon__1_;
            this.btnXoaMay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoaMay.Location = new System.Drawing.Point(315, 509);
            this.btnXoaMay.Name = "btnXoaMay";
            this.btnXoaMay.Size = new System.Drawing.Size(125, 51);
            this.btnXoaMay.TabIndex = 38;
            this.btnXoaMay.Text = "Xóa";
            this.btnXoaMay.Click += new System.EventHandler(this.btnXoaMay_Click);
            // 
            // btnSuaMay
            // 
            this.btnSuaMay.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMay.Appearance.Options.UseFont = true;
            this.btnSuaMay.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.edit_icon;
            this.btnSuaMay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSuaMay.Location = new System.Drawing.Point(169, 509);
            this.btnSuaMay.Name = "btnSuaMay";
            this.btnSuaMay.Size = new System.Drawing.Size(125, 51);
            this.btnSuaMay.TabIndex = 37;
            this.btnSuaMay.Text = "Sửa";
            this.btnSuaMay.Click += new System.EventHandler(this.btnSuaMay_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Reset_icon__1_;
            this.btnLamMoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLamMoi.Location = new System.Drawing.Point(445, 619);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 51);
            this.btnLamMoi.TabIndex = 35;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnThem.Location = new System.Drawing.Point(12, 619);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 51);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.delete_icon__1_;
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(300, 619);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 51);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.edit_icon;
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(154, 619);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 51);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(613, 58);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 595);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTimKiemMay);
            this.groupControl2.Controls.Add(this.lblTenTaiKhoan);
            this.groupControl2.Controls.Add(this.btnTimKiemMay);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(619, 58);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(673, 100);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // txtTimKiemMay
            // 
            this.txtTimKiemMay.Location = new System.Drawing.Point(186, 52);
            this.txtTimKiemMay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMay.Name = "txtTimKiemMay";
            this.txtTimKiemMay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMay.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiemMay.Size = new System.Drawing.Size(193, 28);
            this.txtTimKiemMay.TabIndex = 28;
            this.txtTimKiemMay.EditValueChanged += new System.EventHandler(this.txtTimKiemMay_EditValueChanged);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(91, 55);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(82, 21);
            this.lblTenTaiKhoan.TabIndex = 26;
            this.lblTenTaiKhoan.Text = "Tên máy:";
            // 
            // btnTimKiemMay
            // 
            this.btnTimKiemMay.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMay.Appearance.Options.UseFont = true;
            this.btnTimKiemMay.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Search_icon1;
            this.btnTimKiemMay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimKiemMay.Location = new System.Drawing.Point(401, 45);
            this.btnTimKiemMay.Name = "btnTimKiemMay";
            this.btnTimKiemMay.Size = new System.Drawing.Size(140, 35);
            this.btnTimKiemMay.TabIndex = 27;
            this.btnTimKiemMay.Text = "Tìm kiếm";
            this.btnTimKiemMay.Click += new System.EventHandler(this.btnTimKiemMay_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvQuanLyMay);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(619, 158);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(673, 495);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Kết quả";
            // 
            // dgvQuanLyMay
            // 
            this.dgvQuanLyMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyMay.Location = new System.Drawing.Point(2, 25);
            this.dgvQuanLyMay.Name = "dgvQuanLyMay";
            this.dgvQuanLyMay.RowHeadersWidth = 51;
            this.dgvQuanLyMay.RowTemplate.Height = 24;
            this.dgvQuanLyMay.Size = new System.Drawing.Size(669, 468);
            this.dgvQuanLyMay.TabIndex = 0;
            // 
            // frm_QuanLyMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 653);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "frm_QuanLyMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ MÁY";
            this.Load += new System.EventHandler(this.frm_QuanLyMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyMay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtTimKiemMay;
        private DevExpress.XtraEditors.LabelControl lblTenTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemMay;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvQuanLyMay;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiMay;
        private DevExpress.XtraEditors.SimpleButton btnThemMay;
        private DevExpress.XtraEditors.SimpleButton btnXoaMay;
        private DevExpress.XtraEditors.SimpleButton btnSuaMay;
        private DevExpress.XtraEditors.TextEdit txtMaMay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenMay;
        private DevExpress.XtraEditors.LabelControl lblTenMay;
        private DevExpress.XtraEditors.LabelControl lblMaMay;
        private System.Windows.Forms.NumericUpDown numGiaTien;
    }
}