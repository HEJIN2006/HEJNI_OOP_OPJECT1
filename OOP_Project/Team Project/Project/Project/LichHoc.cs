using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class LichHoc
    {
        private string malophocphan;
        private string mamonhoc;
        private string giangvien;
        private string thoigianhoc;
        private int soluongsinhvien;
        private string phonghoc;
        private string tinhtrang;
        public LichHoc()
        {
            this.malophocphan = "Chưa có";
            this.mamonhoc = "Chưa xác định";
            this.giangvien = "Chưa phân công";
            this.thoigianhoc = "Chưa sắp lịch";
            this.soluongsinhvien = 0;
            this.phonghoc = "Chưa có phòng";
            this.tinhtrang = "Chưa xác định";
        }
        public LichHoc(string malophocphan, string mamonhoc, string giangvien, string thoigianhoc, int soluongsinhvien, string phonghoc, string tinhtrang)
        {
            this.malophocphan = malophocphan;
            this.mamonhoc = mamonhoc;
            this.giangvien = giangvien;
            this.thoigianhoc = thoigianhoc;
            this.soluongsinhvien = soluongsinhvien;
            this.phonghoc = phonghoc;
            this.tinhtrang = tinhtrang;
        }
        public string MaLopHocPhan
        {
            get { return malophocphan; }
            set { malophocphan = value; }
        }
        public string MaMonHoc
        {
            get { return mamonhoc; }
            set { mamonhoc = value; }
        }
        public string GiangVien
        {
            get { return giangvien; }
            set { giangvien = value; }
        }
        public string ThoiGianHoc
        {
            get { return thoigianhoc; }
            set { thoigianhoc = value; }
        }
        public int SoLuongSinhVien
        {
            get { return soluongsinhvien; }
            set { soluongsinhvien = value; }
        }
        public string PhongHoc
        {
            get { return phonghoc; }
            set { phonghoc = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

    }
}
