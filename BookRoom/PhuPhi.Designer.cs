
namespace BookRoom
{
    partial class PhuPhi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuPhi));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPhuThu = new System.Windows.Forms.DataGridView();
            this.idPhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.IDSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.cboIDCus = new System.Windows.Forms.ComboBox();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BookRoom.DataSet1();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_tenk = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSLConLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.khachhangTableAdapter = new BookRoom.DataSet1TableAdapters.KhachhangTableAdapter();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox4.Controls.Add(this.dgvPhuThu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(623, 412);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(864, 352);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bảng phụ thu";
            // 
            // dgvPhuThu
            // 
            this.dgvPhuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhu,
            this.MaKH,
            this.MaSP,
            this.TenSp,
            this.SoLuong,
            this.Gia,
            this.TrangThai,
            this.Tongtien});
            this.dgvPhuThu.Location = new System.Drawing.Point(35, 43);
            this.dgvPhuThu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhuThu.Name = "dgvPhuThu";
            this.dgvPhuThu.RowHeadersWidth = 51;
            this.dgvPhuThu.Size = new System.Drawing.Size(797, 260);
            this.dgvPhuThu.TabIndex = 0;
            this.dgvPhuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuThu_CellClick);
            // 
            // idPhu
            // 
            this.idPhu.DataPropertyName = "MaPhu";
            this.idPhu.HeaderText = "Mã hóa đơn";
            this.idPhu.MinimumWidth = 6;
            this.idPhu.Name = "idPhu";
            this.idPhu.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKh";
            this.MaKH.HeaderText = "Mã khách";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "Maitem";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSp
            // 
            this.TenSp.DataPropertyName = "tensp";
            this.TenSp.HeaderText = "Tên sản phẩm";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "giaban";
            this.Gia.HeaderText = "Giá bán";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "trangthai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "thanhtien";
            this.Tongtien.HeaderText = "Thành tiền";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(623, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(864, 272);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảng sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSP,
            this.NameSP,
            this.GiaNhap,
            this.SL,
            this.GiaBan});
            this.dgvSanPham.Location = new System.Drawing.Point(35, 39);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(797, 206);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // IDSP
            // 
            this.IDSP.DataPropertyName = "Maitem";
            this.IDSP.HeaderText = "Mã sản phẩm";
            this.IDSP.MinimumWidth = 6;
            this.IDSP.Name = "IDSP";
            this.IDSP.Width = 125;
            // 
            // NameSP
            // 
            this.NameSP.DataPropertyName = "TenItem";
            this.NameSP.HeaderText = "Tên sản phẩm";
            this.NameSP.MinimumWidth = 6;
            this.NameSP.Name = "NameSP";
            this.NameSP.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "gianhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 125;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "soluong";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "giaban";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý phi phát sinh";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox3.Controls.Add(this.txtNameProduct);
            this.groupBox3.Controls.Add(this.cboIDCus);
            this.groupBox3.Controls.Add(this.lb_tensp);
            this.groupBox3.Controls.Add(this.lb_tenk);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.btnNhapLai);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSLBan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSLConLai);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtMaSP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMaPT);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(29, 199);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(563, 565);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm đặt mua";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Location = new System.Drawing.Point(390, 154);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(155, 36);
            this.txtNameProduct.TabIndex = 60;
            // 
            // cboIDCus
            // 
            this.cboIDCus.DataSource = this.khachhangBindingSource;
            this.cboIDCus.DisplayMember = "MaKh";
            this.cboIDCus.FormattingEnabled = true;
            this.cboIDCus.Location = new System.Drawing.Point(153, 98);
            this.cboIDCus.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDCus.Name = "cboIDCus";
            this.cboIDCus.Size = new System.Drawing.Size(169, 32);
            this.cboIDCus.TabIndex = 59;
            this.cboIDCus.TextChanged += new System.EventHandler(this.cboIDCus_TextChanged);
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "Khachhang";
            this.khachhangBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Location = new System.Drawing.Point(308, 169);
            this.lb_tensp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(73, 24);
            this.lb_tensp.TabIndex = 58;
            this.lb_tensp.Text = "Tên SP";
            // 
            // lb_tenk
            // 
            this.lb_tenk.AutoSize = true;
            this.lb_tenk.Location = new System.Drawing.Point(335, 108);
            this.lb_tenk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenk.Name = "lb_tenk";
            this.lb_tenk.Size = new System.Drawing.Size(120, 24);
            this.lb_tenk.TabIndex = 58;
            this.lb_tenk.Text = "Tên khách....";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(206, 483);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 58);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(153, 330);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(169, 36);
            this.txtThanhTien.TabIndex = 1;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(8, 482);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(159, 60);
            this.btnNhapLai.TabIndex = 56;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành tiền";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(379, 405);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 53);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(153, 270);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(169, 36);
            this.txtGiaBan.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(197, 401);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 57);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(8, 405);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 49);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá";
            // 
            // txtSLBan
            // 
            this.txtSLBan.Location = new System.Drawing.Point(441, 213);
            this.txtSLBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLBan.Multiline = true;
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(104, 36);
            this.txtSLBan.TabIndex = 1;
            this.txtSLBan.TextChanged += new System.EventHandler(this.txtSLBan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng bán";
            // 
            // txtSLConLai
            // 
            this.txtSLConLai.Enabled = false;
            this.txtSLConLai.Location = new System.Drawing.Point(153, 213);
            this.txtSLConLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLConLai.Multiline = true;
            this.txtSLConLai.Name = "txtSLConLai";
            this.txtSLConLai.Size = new System.Drawing.Size(105, 36);
            this.txtSLConLai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng kho";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(153, 154);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(124, 36);
            this.txtMaSP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(153, 38);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Multiline = true;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(169, 36);
            this.txtMaPT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phụ thu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(29, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm đặt mua";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(219, 39);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(317, 35);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.Text = "Từ khóa ....";
            this.txtTenSP.Click += new System.EventHandler(this.txtTenSP_Click);
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên sản phẩm";
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // PhuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 808);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhuPhi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PhuPhi_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPhuThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboIDCus;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label lb_tenk;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSLBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSLConLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private DataSet1TableAdapters.KhachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.TextBox txtNameProduct;
    }
}