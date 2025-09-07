namespace Project
{
    partial class QuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLichHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyĐiemSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyCoVanHocTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiChinhSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renLuyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chungChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaSv = new System.Windows.Forms.TextBox();
            this.textBox_HoTenSv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MaLop = new System.Windows.Forms.TextBox();
            this.textBox_MaKhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_CoVan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_QuayLai = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_DanhSachSV = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MaCoVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyKhoaToolStripMenuItem,
            this.quanLyHocPhanToolStripMenuItem,
            this.quanLyLopToolStripMenuItem,
            this.quanLyLichHọcToolStripMenuItem,
            this.quanLyĐiemSinhVienToolStripMenuItem,
            this.quanLyCoVanHocTapToolStripMenuItem,
            this.taiChinhSinhVienToolStripMenuItem,
            this.renLuyenToolStripMenuItem,
            this.chungChiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyKhoaToolStripMenuItem
            // 
            this.quanLyKhoaToolStripMenuItem.Name = "quanLyKhoaToolStripMenuItem";
            this.quanLyKhoaToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.quanLyKhoaToolStripMenuItem.Text = " Khoa";
            this.quanLyKhoaToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhoaToolStripMenuItem_Click);
            // 
            // quanLyHocPhanToolStripMenuItem
            // 
            this.quanLyHocPhanToolStripMenuItem.Name = "quanLyHocPhanToolStripMenuItem";
            this.quanLyHocPhanToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.quanLyHocPhanToolStripMenuItem.Text = "Học Phần";
            this.quanLyHocPhanToolStripMenuItem.Click += new System.EventHandler(this.quanLyHocPhanToolStripMenuItem_Click);
            // 
            // quanLyLopToolStripMenuItem
            // 
            this.quanLyLopToolStripMenuItem.Name = "quanLyLopToolStripMenuItem";
            this.quanLyLopToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.quanLyLopToolStripMenuItem.Text = "Lớp ";
            this.quanLyLopToolStripMenuItem.Click += new System.EventHandler(this.quanLyLopToolStripMenuItem_Click);
            // 
            // quanLyLichHọcToolStripMenuItem
            // 
            this.quanLyLichHọcToolStripMenuItem.Name = "quanLyLichHọcToolStripMenuItem";
            this.quanLyLichHọcToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.quanLyLichHọcToolStripMenuItem.Text = "Lịch Học";
            this.quanLyLichHọcToolStripMenuItem.Click += new System.EventHandler(this.quanLyLichHọcToolStripMenuItem_Click);
            // 
            // quanLyĐiemSinhVienToolStripMenuItem
            // 
            this.quanLyĐiemSinhVienToolStripMenuItem.Name = "quanLyĐiemSinhVienToolStripMenuItem";
            this.quanLyĐiemSinhVienToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.quanLyĐiemSinhVienToolStripMenuItem.Text = "Điểm Sinh Viên";
            this.quanLyĐiemSinhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyĐiemSinhVienToolStripMenuItem_Click);
            // 
            // quanLyCoVanHocTapToolStripMenuItem
            // 
            this.quanLyCoVanHocTapToolStripMenuItem.Name = "quanLyCoVanHocTapToolStripMenuItem";
            this.quanLyCoVanHocTapToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.quanLyCoVanHocTapToolStripMenuItem.Text = "Cố Vấn Học Tập";
            this.quanLyCoVanHocTapToolStripMenuItem.Click += new System.EventHandler(this.quanLyCoVanHocTapToolStripMenuItem_Click);
            // 
            // taiChinhSinhVienToolStripMenuItem
            // 
            this.taiChinhSinhVienToolStripMenuItem.Name = "taiChinhSinhVienToolStripMenuItem";
            this.taiChinhSinhVienToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.taiChinhSinhVienToolStripMenuItem.Text = "Tài Chính Sinh Viên";
            this.taiChinhSinhVienToolStripMenuItem.Click += new System.EventHandler(this.taiChinhSinhVienToolStripMenuItem_Click);
            // 
            // renLuyenToolStripMenuItem
            // 
            this.renLuyenToolStripMenuItem.Name = "renLuyenToolStripMenuItem";
            this.renLuyenToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.renLuyenToolStripMenuItem.Text = "Điểm Rèn Luyện";
            this.renLuyenToolStripMenuItem.Click += new System.EventHandler(this.rènLuyệnToolStripMenuItem_Click);
            // 
            // chungChiToolStripMenuItem
            // 
            this.chungChiToolStripMenuItem.Name = "chungChiToolStripMenuItem";
            this.chungChiToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.chungChiToolStripMenuItem.Text = "Chứng Chỉ";
            this.chungChiToolStripMenuItem.Click += new System.EventHandler(this.chungChiToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(-62, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1421, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quản Lý Sinh Viên";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SV:";
            // 
            // textBox_MaSv
            // 
            this.textBox_MaSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaSv.Location = new System.Drawing.Point(119, 142);
            this.textBox_MaSv.Name = "textBox_MaSv";
            this.textBox_MaSv.Size = new System.Drawing.Size(144, 34);
            this.textBox_MaSv.TabIndex = 3;
            // 
            // textBox_HoTenSv
            // 
            this.textBox_HoTenSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoTenSv.Location = new System.Drawing.Point(462, 139);
            this.textBox_HoTenSv.Name = "textBox_HoTenSv";
            this.textBox_HoTenSv.Size = new System.Drawing.Size(233, 34);
            this.textBox_HoTenSv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ & Tên SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1049, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới Tính:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(851, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 34);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(1182, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 33);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1276, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 33);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa Chỉ:";
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DiaChi.Location = new System.Drawing.Point(135, 204);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(197, 34);
            this.textBox_DiaChi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SDT.Location = new System.Drawing.Point(568, 199);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(176, 34);
            this.textBox_SDT.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Lớp:";
            // 
            // textBox_MaLop
            // 
            this.textBox_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaLop.Location = new System.Drawing.Point(901, 201);
            this.textBox_MaLop.Name = "textBox_MaLop";
            this.textBox_MaLop.Size = new System.Drawing.Size(144, 34);
            this.textBox_MaLop.TabIndex = 16;
            // 
            // textBox_MaKhoa
            // 
            this.textBox_MaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaKhoa.Location = new System.Drawing.Point(1193, 201);
            this.textBox_MaKhoa.Name = "textBox_MaKhoa";
            this.textBox_MaKhoa.Size = new System.Drawing.Size(144, 34);
            this.textBox_MaKhoa.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1063, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã Khoa:";
            // 
            // textBox_CoVan
            // 
            this.textBox_CoVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CoVan.Location = new System.Drawing.Point(173, 262);
            this.textBox_CoVan.Name = "textBox_CoVan";
            this.textBox_CoVan.Size = new System.Drawing.Size(144, 34);
            this.textBox_CoVan.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mã Cố Vấn:";
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(368, 258);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(127, 42);
            this.button_Them.TabIndex = 21;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(781, 255);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(127, 42);
            this.button_Sua.TabIndex = 22;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(582, 255);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(127, 42);
            this.button_Xoa.TabIndex = 23;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Location = new System.Drawing.Point(970, 252);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(142, 42);
            this.button_TimKiem.TabIndex = 24;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            // 
            // button_QuayLai
            // 
            this.button_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayLai.Location = new System.Drawing.Point(1159, 255);
            this.button_QuayLai.Name = "button_QuayLai";
            this.button_QuayLai.Size = new System.Drawing.Size(127, 42);
            this.button_QuayLai.TabIndex = 25;
            this.button_QuayLai.Text = "Quay Lại";
            this.button_QuayLai.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSalmon;
            this.label11.Location = new System.Drawing.Point(544, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 34);
            this.label11.TabIndex = 28;
            this.label11.Text = "Danh Sách SV";
            // 
            // dataGridView_DanhSachSV
            // 
            this.dataGridView_DanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_MaSV,
            this.Column_HoTen,
            this.Column_NgaySinh,
            this.Column_GioiTinh,
            this.Column_DiaChi,
            this.Column_MaLop,
            this.Column_MaKhoa,
            this.Column_MaCoVan});
            this.dataGridView_DanhSachSV.Location = new System.Drawing.Point(45, 387);
            this.dataGridView_DanhSachSV.Name = "dataGridView_DanhSachSV";
            this.dataGridView_DanhSachSV.RowHeadersWidth = 51;
            this.dataGridView_DanhSachSV.RowTemplate.Height = 24;
            this.dataGridView_DanhSachSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DanhSachSV.Size = new System.Drawing.Size(1269, 233);
            this.dataGridView_DanhSachSV.TabIndex = 29;
            this.dataGridView_DanhSachSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.MinimumWidth = 6;
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.Width = 125;
            // 
            // Column_MaSV
            // 
            this.Column_MaSV.HeaderText = "Mã SV";
            this.Column_MaSV.MinimumWidth = 6;
            this.Column_MaSV.Name = "Column_MaSV";
            this.Column_MaSV.Width = 125;
            // 
            // Column_HoTen
            // 
            this.Column_HoTen.HeaderText = "HọTên";
            this.Column_HoTen.MinimumWidth = 6;
            this.Column_HoTen.Name = "Column_HoTen";
            this.Column_HoTen.Width = 125;
            // 
            // Column_NgaySinh
            // 
            this.Column_NgaySinh.HeaderText = "Ngày Sinh";
            this.Column_NgaySinh.MinimumWidth = 6;
            this.Column_NgaySinh.Name = "Column_NgaySinh";
            this.Column_NgaySinh.Width = 125;
            // 
            // Column_GioiTinh
            // 
            this.Column_GioiTinh.HeaderText = "Giới Tính";
            this.Column_GioiTinh.MinimumWidth = 6;
            this.Column_GioiTinh.Name = "Column_GioiTinh";
            this.Column_GioiTinh.Width = 125;
            // 
            // Column_DiaChi
            // 
            this.Column_DiaChi.HeaderText = "Địa Chỉ";
            this.Column_DiaChi.MinimumWidth = 6;
            this.Column_DiaChi.Name = "Column_DiaChi";
            this.Column_DiaChi.Width = 125;
            // 
            // Column_MaLop
            // 
            this.Column_MaLop.HeaderText = "Mã Lớp";
            this.Column_MaLop.MinimumWidth = 6;
            this.Column_MaLop.Name = "Column_MaLop";
            this.Column_MaLop.Width = 125;
            // 
            // Column_MaKhoa
            // 
            this.Column_MaKhoa.HeaderText = "Mã Khoa";
            this.Column_MaKhoa.MinimumWidth = 6;
            this.Column_MaKhoa.Name = "Column_MaKhoa";
            this.Column_MaKhoa.Width = 125;
            // 
            // Column_MaCoVan
            // 
            this.Column_MaCoVan.HeaderText = "Mã Cố Vấn";
            this.Column_MaCoVan.MinimumWidth = 6;
            this.Column_MaCoVan.Name = "Column_MaCoVan";
            this.Column_MaCoVan.Width = 125;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1359, 770);
            this.Controls.Add(this.dataGridView_DanhSachSV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_QuayLai);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.textBox_CoVan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_MaKhoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_MaLop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_HoTenSv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MaSv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLySinhVien";
            this.Text = "Quản Lý Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLySinhVien_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLichHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyĐiemSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyCoVanHocTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiChinhSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renLuyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chungChiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaSv;
        private System.Windows.Forms.TextBox textBox_HoTenSv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MaLop;
        private System.Windows.Forms.TextBox textBox_MaKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_CoVan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_QuayLai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaCoVan;
    }
}

