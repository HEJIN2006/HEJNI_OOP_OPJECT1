using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ChungChiQT
    {
        private string macc;
        private string masv;
        private string tencc;
        private string loaicc;
        private string capdo;
        private NgayThangNam ngaycap;
        private NgayThangNam ngayhethan;

        public ChungChiQT()
        {
            macc = "";
            masv = "";
            tencc = "";
            loaicc = "";
            capdo = "";
            ngaycap = new NgayThangNam();
            ngayhethan = new NgayThangNam();
        }
        public ChungChiQT(string macc, string masv, string tencc, string loaicc, string capdo, NgayThangNam ngaycap, NgayThangNam ngayhethan)
        {
            this.macc = macc;
            this.masv = masv;
            this.tencc = tencc;
            this.loaicc = loaicc;
            this.capdo = capdo;
            this.ngaycap = ngaycap;
            this.ngayhethan = ngayhethan;
        }
        public string MaCC
        { get { return macc; } set { macc = value; } }
        public string MaSV
        { get { return masv; } set { masv = value; } }
        public string TenCC
        { get { return tencc; } set { tencc = value; } }
        public string LoaiCC
        { get { return loaicc; } set { loaicc = value; } }
        public string CapDo
        { get { return capdo; } set { capdo = value; } }
        public NgayThangNam NgayCap
        { get { return ngaycap; } set { ngaycap = value; } }
        public NgayThangNam NgayHetHan
        { get { return ngayhethan; } set { ngayhethan = value; } }
    }

}

