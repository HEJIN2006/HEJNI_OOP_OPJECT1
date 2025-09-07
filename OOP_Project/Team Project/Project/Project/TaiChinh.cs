using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class TaiChinh
    {
        private string masv;
        private int hocphi;
        private int danop;
        private int thieu;
        private NgayThangNam handong;

        public TaiChinh()
        {
            masv = "";
            hocphi = 0;
            danop = 0;
            thieu = hocphi - danop;
            handong = new NgayThangNam();
        }
        public TaiChinh(string id, int tuition, int submited, NgayThangNam date)
        {
            this.masv = id;
            this.hocphi = tuition;
            this.danop = submited;
            this.thieu = tuition - submited;
            this.handong = date;
        }
        public string MaSV
        { get { return masv; } set { masv = value; } }
        public int HocPhi
        { get { return hocphi; } set { hocphi = value; } }
        public int DaNop
        { get { return danop; } set { danop = value; } }
        public int Thieu
        { get { return thieu; } set { thieu = value; } }
        public NgayThangNam HanDong
        { get { return handong; } set { handong = value; } }
    }

}

