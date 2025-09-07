using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class CoVan
    {
        private string macv;
        private string tencv;
        private string email;
        private string phone;
        private string khoa;
        private string desc;

        public CoVan()
        {
            macv = "";
            tencv = "";
            email = "";
            phone = "";
            khoa = "";
            desc = "";
        }
        public CoVan(string identity, string full_name, string mail, string mobile, string fac, string description)
        {
            this.macv = identity;
            this.tencv = full_name;
            this.email = mail;
            this.phone = mobile;
            this.khoa = fac;
            this.desc = description;
        }
        public string MaCV
        { get { return macv; } set { macv = value; } }
        public string TenCV
        { get { return tencv; } set { tencv = value; } }
        public string Email
        { get { return email; } set { email = value; } }
        public string Phone
        { get { return phone; } set { phone = value; } }
        public string Khoa
        { get { return khoa; } set { khoa = value; } }
        public string Desc
        { get { return desc; } set { desc = value; } }
    }

}

