using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class HocPhan
    {
        private string mahocphan;
        private string tenmonhoc;
        private int sotinchi;
        private string khoaquanly;
        private string giangvienphutrach;
        private string lichhoc;
        private string loaimonhoc;
        public HocPhan()
        {
            this.mahocphan = "Chưa có";
            this.tenmonhoc = "Chưa đặt tên";
            this.sotinchi = 0;
            this.khoaquanly = "Chưa rõ";
            this.giangvienphutrach = "Chưa phân công";
            this.lichhoc = "Chưa có lịch";
            this.loaimonhoc = "Chưa xác định";
        }
        public HocPhan(string mahocphan, string tenmonhoc, int sotinchi, string khoaquanly, string giangvienphutrach, string lichhoc, string loaimonhoc)

        {
            this.mahocphan = mahocphan;
            this.tenmonhoc = tenmonhoc;
            this.sotinchi = sotinchi;
            this.khoaquanly = khoaquanly;
            this.giangvienphutrach = giangvienphutrach;
            this.lichhoc = lichhoc;
            this.loaimonhoc = loaimonhoc;
        }

        public string MaHocPhan
        {
            get { return mahocphan; }
            set { mahocphan = value; }
        }

        public string TenMonHoc
        {
            get { return tenmonhoc; }
            set { tenmonhoc = value; }
        }

        public int SoTinChi
        {
            get { return sotinchi; }
            set { sotinchi = value; }
        }

        public string KhoaQuanLy
        {
            get { return khoaquanly; }
            set { khoaquanly = value; }
        }

        public string GiangVienPhuTrach
        {
            get { return giangvienphutrach; }
            set { giangvienphutrach = value; }
        }

        public string LichHoc
        {
            get { return lichhoc; }
            set { lichhoc = value; }
        }

        public string LoaiMonHoc
        {
            get { return loaimonhoc; }
            set { loaimonhoc = value; }
        }

    }
}
