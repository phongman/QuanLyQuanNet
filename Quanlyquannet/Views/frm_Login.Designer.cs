namespace Quanlyquannet.Views
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureEdit2);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.textMatKhau);
            this.groupControl1.Controls.Add(this.lblMatKhau);
            this.groupControl1.Controls.Add(this.txtTenDangNhap);
            this.groupControl1.Controls.Add(this.lblTenTaiKhoan);
            this.groupControl1.Location = new System.Drawing.Point(74, 67);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(604, 219);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // textMatKhau
            // 
            this.textMatKhau.Location = new System.Drawing.Point(252, 130);
            this.textMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatKhau.Properties.Appearance.Options.UseFont = true;
            this.textMatKhau.Size = new System.Drawing.Size(262, 26);
            this.textMatKhau.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Location = new System.Drawing.Point(113, 133);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(92, 22);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(252, 73);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(262, 28);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Appearance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(72, 73);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(133, 22);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThoat.Appearance.Options.UseFont = true;
            this.BtnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnThoat.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.logout_icon;
            this.BtnThoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnThoat.Location = new System.Drawing.Point(399, 322);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(151, 51);
            this.BtnThoat.TabIndex = 5;
            this.BtnThoat.Text = "Thoát";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::Quanlyquannet.Properties.Resources.Security_Password_2_icon;
            this.pictureEdit2.Location = new System.Drawing.Point(214, 121);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(38, 36);
            this.pictureEdit2.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Quanlyquannet.Properties.Resources.Admin_icon__1_;
            this.pictureEdit1.Location = new System.Drawing.Point(214, 66);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 36);
            this.pictureEdit1.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.ImageOptions.Image = global::Quanlyquannet.Properties.Resources.Login_icon;
            this.btnDangNhap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDangNhap.Location = new System.Drawing.Point(199, 322);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 51);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_DangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 422);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DangNhap";
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
        public DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        public DevExpress.XtraEditors.TextEdit textMatKhau;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}