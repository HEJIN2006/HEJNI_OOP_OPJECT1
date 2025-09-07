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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void rènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetQuaRenLuyen ketQuaRenLuyen=new KetQuaRenLuyen(); 
            this.Hide();    
            ketQuaRenLuyen.ShowDialog();  
            this.Show();    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quanLySinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quanLyKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhoa quanLyKhoa = new QuanLyKhoa();
            this.Hide();
            quanLyKhoa.ShowDialog();
            this.Show();
        }

        private void quanLyHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocPhan quanLyHocPhan = new QuanLyHocPhan();
            this.Hide();
            quanLyHocPhan.ShowDialog();
            this.Show();
        }

        private void quanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLop quanLyLop = new QuanLyLop();
            this.Hide();
            quanLyLop.ShowDialog();
            this.Show();
        }

        private void quanLyLichHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichHoc quanLyLichHoc = new QuanLyLichHoc();
            this.Hide();
            quanLyLichHoc.ShowDialog();
            this.Show();
        }

        private void quanLyĐiemSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem quanLyDiem = new QuanLyDiem();   
            this.Hide();
            quanLyDiem.ShowDialog();
            this.Show();
        }

        private void quanLyCoVanHocTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyCoVanHocTap quanLyCoVanHocTap = new QuanLyCoVanHocTap();
            this.Hide();    
            quanLyCoVanHocTap.ShowDialog();
            this.Show();
        }

        private void taiChinhSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TaiChinhSV taiChinh = new TaiChinhSV();
            this.Hide();
            taiChinh.ShowDialog();
            this.Show();
        }

        private void chungChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChungChi chungChi = new ChungChi(); 
            this.Hide();
            chungChi.ShowDialog();
            this.Show();
        }

        private void QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
