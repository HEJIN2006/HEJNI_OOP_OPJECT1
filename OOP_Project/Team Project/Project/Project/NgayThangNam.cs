using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class NgayThangNam
    {
        public int d;
        public int m;
        public int y;

        public NgayThangNam()
        {
            d = 0;
            m = 0;
            y = 0;
        }
        public NgayThangNam(int d, int m, int y)
        {
            this.d = d;
            this.m = m;
            this.y = y;
        }
        public int Day
        { get { return d; } set { d = value; } }
        public int Month
        { get { return m; } set { m = value; } }
        public int Year
        { get { return y; } set { y = value; } }
        public override string ToString()
        {
            return $"ngay {d} thang {m} nam {y}";
        }

    }
}
