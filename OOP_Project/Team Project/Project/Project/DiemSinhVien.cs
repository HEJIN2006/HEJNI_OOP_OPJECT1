using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DiemSinhVien
    {
        private string masv;
        private string mahp;
        private string tenmh;

        private double diemqt;
        private double diemck;
        private double diemtk;

        public string MaSinhVien
        {
            get { return masv; }
            set { masv = value; }
        }
        public string MaLopHocPhan
        {
            get { return mahp; }
            set { mahp = value; }
        }
        public string TenMonHoc
        {
            get { return tenmh; }
            set { tenmh = value; }
        }
        public double DiemQuaTrinh
        {
            get { return diemqt; }
            set { diemqt = value; TinhDiemTongKet(); }
        }
        public double DiemCuoiKy
        {
            get { return diemck; }
            set { diemck = value; TinhDiemTongKet(); }
        }
        public double DiemTongKet
        {
            get { return diemtk; }
            private set { diemtk = value; }
        }

        public DiemSinhVien()
        {
            this.masv = "Chưa có mã";
            this.mahp = "Chưa có lớp HP";
            this.tenmh = "Chưa có môn học";
            this.diemqt = 0.0;
            this.diemck = 0.0;
            this.diemtk = 0.0;
        }
        private void TinhDiemTongKet()
        {
            this.diemtk = (this.diemqt * 0.4) + (this.diemck * 0.6);
        }

        public DiemSinhVien(string masv, string mahp, string tenmh,
                            double diemqt, double diemck)
        {
            this.masv = masv;
            this.mahp = mahp;
            this.tenmh = tenmh;
            this.diemqt = diemqt;
            this.diemck = diemck;
            TinhDiemTongKet();
        }
        public override string ToString()
        {
            return $"{MaSinhVien} - {TenMonHoc} ({MaLopHocPhan}) | QT: {DiemQuaTrinh} | CK: {DiemCuoiKy} | TK: {DiemTongKet}";
        }

    }
}
