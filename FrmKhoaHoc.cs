using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CourseRegistrationApp
{
    public partial class FrmKhoaHoc : Form
    {
        
        public FrmKhoaHoc()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmKhoaHoc_Load);
            cboKhoaHoc.SelectedIndexChanged += new EventHandler(cboKhoaHoc_SelectedIndexChanged);
            numSoThang.ValueChanged += new EventHandler(numSoThang_ValueChanged);
        }

        public class KhoaHoc
        {
            public string TenKhoaHoc { get; set; }
            public decimal HocPhi { get; set; }
        }

        // Form load 
        private void FrmKhoaHoc_Load(object sender, EventArgs e)
        {
            // 1. Danh sách khóa học
            var danhSachKhoaHoc = new BindingSource();

            danhSachKhoaHoc.DataSource = new System.ComponentModel.BindingList<KhoaHoc>
            {
            new KhoaHoc { TenKhoaHoc = "C# WinForms cơ bản", HocPhi = 800000 },
            new KhoaHoc { TenKhoaHoc = "SQL Server cơ bản", HocPhi = 700000 },
            new KhoaHoc { TenKhoaHoc = "Web Frontend cơ bản", HocPhi = 750000 },
            new KhoaHoc { TenKhoaHoc = "Lập trình Python cơ bản", HocPhi = 650000 }
            };

            cboKhoaHoc.DataSource = danhSachKhoaHoc;
            cboKhoaHoc.DisplayMember = "TenKhoaHoc"; // Hiển thị tên khóa học 
            cboKhoaHoc.ValueMember = "HocPhi";       // Lưu giá trị học phí 

            // 2. Mặc định khóa học đầu 
            cboKhoaHoc.SelectedIndex = 0;

            // 3. Mặc định hình thức
            radOnline.Checked = true;

            // 4. Giới hạn số tháng 
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;

            numSoThang.Value = 1; // Mặc định là 1

            // 5. Tính toán và hiển thị tổng học phí 
            TinhTongTien();
        }

        // Tổng học phí 
        private void TinhTongTien()
        {
            if (cboKhoaHoc.SelectedItem != null)
            {
                // Lấy thông tin đối tượng khóa học đang được chọn
                KhoaHoc kh = (KhoaHoc)cboKhoaHoc.SelectedItem;
                decimal hocPhiMotThang = kh.HocPhi;
                int soThang = (int)numSoThang.Value;

                // Công thức
                decimal tongTien = hocPhiMotThang * soThang;

                // Hiển thị định dạng tiền tệ Việt Nam (VNĐ)
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        // Tổng tiền theo khóa học 
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien(); // Cập nhật lại 
        }

        // Tổng tiền dựa theo số tháng 
        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien(); // Cập nhật lại 
        }

        // Nút đăng ký 
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập 
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (cboKhoaHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            // 2. Thông tin phiếu đăng ký
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

            KhoaHoc kh = (KhoaHoc)cboKhoaHoc.SelectedItem;
            string tenKhoaHoc = kh.TenKhoaHoc;

            // Xác định hình thức 
            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp (Offline)";

            int soThang = (int)numSoThang.Value;
            string tongTien = lblTongTien.Text;

            // Checkbox nhận email 
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            // 3. Hiển thị phiếu đăng ký bằng MessageBox 
            string thongBao = "--- PHIẾU ĐĂNG KÝ KHÓA HỌC ---\n\n" +
                              $"+ Họ tên: {hoTen}\n" +
                              $"+ Số điện thoại: {soDienThoai}\n" +
                              $"+ Ngày sinh: {ngaySinh}\n" +
                              $"+ Khóa học: {tenKhoaHoc}\n" +
                              $"+ Hình thức học: {hinhThuc}\n" +
                              $"+ Số tháng đăng ký: {soThang}\n" +
                              $"+ Tổng học phí: {tongTien}\n" +
                              $"+ Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(thongBao, "Kết quả đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút làm mới 
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();                       
            txtSoDienThoai.Clear();                 
            dtpNgaySinh.Value = DateTime.Now;       
            chkNhanEmail.Checked = false;           
            cboKhoaHoc.SelectedIndex = 0;           
            radOnline.Checked = true;               
            numSoThang.Value = 1;                   
            txtHoTen.Focus();                       
        }

        // Nút thoát

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Xác nhận thoát 
            DialogResult result = MessageBox.Show("Thoát chương trình?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Ràng buộc: Chỉ cho phép nhập chữ cái và khoảng cách và backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ràng buộc: Chỉ cho phép nhập số 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

    }
}