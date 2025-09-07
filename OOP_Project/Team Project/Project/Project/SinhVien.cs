using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class SinhVien
    {
        private string masv;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sodt;
        private string email;
        private string lop;
        private string khoanganh;
        private string khoahoc;
        private string trangthaihoctap;

        public string MaSinhVien
        {
            get { return masv; }
            set { masv = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SoDienThoai
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public string KhoaNganh
        {
            get { return khoanganh; }
            set { khoanganh = value; }
        }
        public string KhoaHoc
        {
            get { return khoahoc; }
            set { khoahoc = value; }
        }
        public string TrangThaiHocTap
        {
            get { return trangthaihoctap; }
            set { trangthaihoctap = value; }
        }

        public SinhVien()
        {
            this.masv = "Chưa có mã";
            this.hoten = "Chưa có tên";
            this.ngaysinh = DateTime.MinValue;
            this.gioitinh = "Chưa rõ";
            this.diachi = "Chưa có địa chỉ";
            this.sodt = "Chưa có số ĐT";
            this.email = "Chưa có email";
            this.lop = "Chưa có lớp";
            this.khoanganh = "Chưa có ngành";
            this.khoahoc = "Chưa có khóa";
            this.trangthaihoctap = "Chưa rõ";
        }

        public SinhVien(string masv, string hoten, DateTime ngaysinh,
                        string gioitinh, string diachi, string sodt,
                        string email, string lop, string khoanganh,
                        string khoahoc, string trangthaihoctap)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sodt = sodt;
            this.email = email;
            this.lop = lop;
            this.khoanganh = khoanganh;
            this.khoahoc = khoahoc;
            this.trangthaihoctap = trangthaihoctap;
        }

        public override string ToString()
        {
            return $"{MaSinhVien} - {HoTen} - {Lop} - {KhoaNganh} - {TrangThaiHocTap}";
        }
    }

}

