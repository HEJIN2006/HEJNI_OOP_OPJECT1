using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Khoa
    {
        private string makhoa;
        private string tenkhoa;
        private string tentruongkhoa;
        private string email;
        private string sodienthoai;
        private string diachi;

        public Khoa()
        {
            this.makhoa = "Ko có";
            this.tenkhoa = "Ko có";
            this.tentruongkhoa = "Ko có";
            this.email = "Ko có";
            this.sodienthoai = "Ko có";
            this.diachi = "Ko có";
        }

        public Khoa(string makhoa, string tenkhoa, string tentruongkhoa, string email, string sodienthoai, string diachi)
        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.tentruongkhoa = tentruongkhoa;
            this.email = email;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
        }

        public string MaKhoa { get => makhoa; set => makhoa = value; }
        public string TenKhoa { get => tenkhoa; set => tenkhoa = value; }
        public string TenTruongKhoa { get => tentruongkhoa; set => tentruongkhoa = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => sodienthoai; set => sodienthoai = value; }
        public string DiaChi { get => diachi; set => diachi = value; }

        public string ThongTin()
        {
            return $"Mã khoa: {MaKhoa}, Tên khoa: {TenKhoa}, Trưởng khoa: {TenTruongKhoa}, Email: {Email}, SĐT: {SoDienThoai}, Địa chỉ: {DiaChi}";
        }
        public bool KiemTraEmail()
        {
            return Email.Contains("@") && Email.Contains(".");
        }
    }
}
