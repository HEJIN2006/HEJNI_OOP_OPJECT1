using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Lop
    {
        private string makhoa;
        private string tenkhoa;
        private string malop;
        private string tenlop;
        private string khoahoc;
        private string giangvienchunhiem;
        public Lop()
        {
            this.makhoa = "Chưa có";
            this.tenkhoa = "Chưa đặt tên";
            this.malop = "Chưa có";
            this.tenlop = "Chưa đặt tên";
            this.khoahoc = "Chưa xác định";
            this.giangvienchunhiem = "Chưa phân công";
        }
        public Lop(string makhoa, string tenkhoa, string malop, string tenlop, string khoahoc, string giangvienchunhiem)

        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.malop = malop;
            this.tenlop = tenlop;
            this.khoahoc = khoahoc;
            this.giangvienchunhiem = giangvienchunhiem;
        }
        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }
        public string TenKhoa
        {
            get { return tenkhoa; }
            set { tenkhoa = value; }
        }
        public string MaLop
        {
            get { return malop; }
            set { malop = value; }
        }
        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        public string KhoaHoc
        {
            get { return khoahoc; }
            set { khoahoc = value; }
        }
        public string GiangVienChuNhiem
        {
            get { return giangvienchunhiem; }
            set { giangvienchunhiem = value; }
        }
    }
}
