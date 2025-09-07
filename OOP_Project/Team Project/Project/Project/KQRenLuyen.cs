using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class KQRenLuyen
    {
        private string masv;
        private string hocky;
        private int namhoc;
        private int tongdiem;
        private string xeploai;

        public KQRenLuyen()
        {
            masv = "";
            hocky = "";
            namhoc = 0;
            tongdiem = 0;
            xeploai = "";
        }
        public KQRenLuyen(string masv, string hocky, int namhoc, int tongdiem, string xeploai)
        {
            this.masv = masv;
            this.hocky = hocky;
            this.namhoc = namhoc;
            this.tongdiem = tongdiem;
            this.xeploai = xeploai;
        }
        public string MaSV
        { get { return masv; } set { masv = value; } }
        public string HocKy
        { get { return hocky; } set { hocky = value; } }
        public int NamHoc
        { get { return namhoc; } set { namhoc = value; } }
        public int TongDiem
        { get { return tongdiem; } set { tongdiem = value; } }
        public string XepLoai
        { get { return xeploai; } set { xeploai = value; } }
    }

}

