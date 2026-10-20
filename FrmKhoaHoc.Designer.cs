namespace CourseRegistrationApp
{
    partial class FrmKhoaHoc
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
            this.gbHocVien = new System.Windows.Forms.GroupBox();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.gbKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a = new System.Windows.Forms.DateTimePicker();
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3 = new System.Windows.Forms.DateTimePicker();
            this.gbHocVien.SuspendLayout();
            this.gbKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHocVien
            // 
            this.gbHocVien.Controls.Add(this.chkNhanEmail);
            this.gbHocVien.Controls.Add(this.dtpNgaySinh);
            this.gbHocVien.Controls.Add(this.lblNgaySinh);
            this.gbHocVien.Controls.Add(this.txtSoDienThoai);
            this.gbHocVien.Controls.Add(this.txtHoTen);
            this.gbHocVien.Controls.Add(this.lblEmail);
            this.gbHocVien.Controls.Add(this.lblSDT);
            this.gbHocVien.Controls.Add(this.lblHoTen);
            this.gbHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHocVien.Location = new System.Drawing.Point(12, 13);
            this.gbHocVien.Name = "gbHocVien";
            this.gbHocVien.Size = new System.Drawing.Size(503, 340);
            this.gbHocVien.TabIndex = 0;
            this.gbHocVien.TabStop = false;
            this.gbHocVien.Text = "Thông tin học viên";
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(213, 309);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(18, 17);
            this.chkNhanEmail.TabIndex = 7;
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(116, 214);
            this.dtpNgaySinh.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(133, 28);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(0, 214);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(136, 128);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(274, 28);
            this.txtSoDienThoai.TabIndex = 4;
            this.txtSoDienThoai.Click += new System.EventHandler(this.FrmKhoaHoc_Load);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(136, 44);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(361, 28);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(0, 304);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(187, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Nhận Email thông báo";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(0, 128);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(115, 22);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(0, 45);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(135, 22);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên học viên";
            // 
            // gbKhoaHoc
            // 
            this.gbKhoaHoc.Controls.Add(this.lblTongTien);
            this.gbKhoaHoc.Controls.Add(this.numSoThang);
            this.gbKhoaHoc.Controls.Add(this.radOffline);
            this.gbKhoaHoc.Controls.Add(this.radOnline);
            this.gbKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.gbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKhoaHoc.Location = new System.Drawing.Point(521, 13);
            this.gbKhoaHoc.Name = "gbKhoaHoc";
            this.gbKhoaHoc.Size = new System.Drawing.Size(526, 340);
            this.gbKhoaHoc.TabIndex = 1;
            this.gbKhoaHoc.TabStop = false;
            this.gbKhoaHoc.Text = "Thông tin khóa học";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(6, 301);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(78, 25);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Số tiền ";
            // 
            // numSoThang
            // 
            this.numSoThang.Location = new System.Drawing.Point(10, 108);
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.ReadOnly = true;
            this.numSoThang.Size = new System.Drawing.Size(120, 28);
            this.numSoThang.TabIndex = 3;
            this.numSoThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(360, 81);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(160, 26);
            this.radOffline.TabIndex = 2;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Hình thức offline";
            this.radOffline.UseVisualStyleBackColor = true;
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(360, 49);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(160, 26);
            this.radOnline.TabIndex = 1;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Hình thức online";
            this.radOnline.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.Items.AddRange(new object[] {
            "C# WinForms cơ bản",
            "SQL Server cơ bản",
            "Web Frontend cơ bản",
            "Lập trình Python cơ bản"});
            this.cboKhoaHoc.Location = new System.Drawing.Point(10, 48);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(333, 30);
            this.cboKhoaHoc.TabIndex = 5;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(288, 395);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(143, 43);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(640, 395);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(143, 43);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(455, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh mục chức năng";
            // 
            // object_4694d3f7_82d8_4afc_819f_4ec7fde3849a
            // 
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a.Location = new System.Drawing.Point(116, 214);
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a.Name = "object_4694d3f7_82d8_4afc_819f_4ec7fde3849a";
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a.Size = new System.Drawing.Size(133, 22);
            this.object_4694d3f7_82d8_4afc_819f_4ec7fde3849a.TabIndex = 6;
            // 
            // object_a2627e09_6b3f_422d_bc1a_555fc73491e3
            // 
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3.Location = new System.Drawing.Point(116, 214);
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3.Name = "object_a2627e09_6b3f_422d_bc1a_555fc73491e3";
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3.Size = new System.Drawing.Size(133, 22);
            this.object_a2627e09_6b3f_422d_bc1a_555fc73491e3.TabIndex = 6;
            // 
            // FrmKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.gbKhoaHoc);
            this.Controls.Add(this.gbHocVien);
            this.Name = "FrmKhoaHoc";
            this.Text = "Đăng ký khóa học ";
            this.gbHocVien.ResumeLayout(false);
            this.gbHocVien.PerformLayout();
            this.gbKhoaHoc.ResumeLayout(false);
            this.gbKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHocVien;
        private System.Windows.Forms.GroupBox gbKhoaHoc;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.DateTimePicker object_4694d3f7_82d8_4afc_819f_4ec7fde3849a;
        private System.Windows.Forms.DateTimePicker object_a2627e09_6b3f_422d_bc1a_555fc73491e3;
    }
}

