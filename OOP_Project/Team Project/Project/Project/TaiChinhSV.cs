using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class TaiChinhSV : Form
    {
        public TaiChinhSV()
        {
            InitializeComponent();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();
            this.Hide();
            quanLySinhVien.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhoa quanLyKhoa = new QuanLyKhoa();
            this.Hide();
            quanLyKhoa.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocPhan quanLyHocPhan = new QuanLyHocPhan();
            this.Hide();
            quanLyHocPhan.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLop quanLyLop = new QuanLyLop();
            this.Hide();
            quanLyLop.ShowDialog();
            this.Show();
        }

        private void quảnLýLịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichHoc quanLyLichHoc = new QuanLyLichHoc();
            this.Hide();
            quanLyLichHoc.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem quanLyDiem = new QuanLyDiem();
            this.Hide();
            quanLyDiem.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyCoVanHocTap quanLyCoVanHocTap = new QuanLyCoVanHocTap();
            this.Hide();
            quanLyCoVanHocTap.ShowDialog();
            this.Show();
        }

        private void rènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetQuaRenLuyen ketQuaRenLuyen = new KetQuaRenLuyen();
            this.Hide();
            ketQuaRenLuyen.ShowDialog();
            this.Show();
        }

        private void chứngChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChungChi chungChi = new ChungChi();
            this.Hide();
            chungChi.ShowDialog();
            this.Show();
        }

        private void TaiChinhSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
