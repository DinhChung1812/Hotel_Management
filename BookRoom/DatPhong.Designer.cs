
namespace BookRoom
{
    partial class DatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatPhong));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.lbGiaPhong = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lb_GiaPhong = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDayBook = new System.Windows.Forms.DateTimePicker();
            this.cboIDNV = new System.Windows.Forms.ComboBox();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new BookRoom.DataSet1();
            this.cboIDCustomer = new System.Windows.Forms.ComboBox();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BookRoom.DataSet1();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_phong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_khach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboLuachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.IDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescritionRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.id_hoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydatphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongnguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhangTableAdapter = new BookRoom.DataSet1TableAdapters.KhachhangTableAdapter();
            this.nhanvienTableAdapter = new BookRoom.DataSet1TableAdapters.NhanvienTableAdapter();
            this.gbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1043, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 34);
            this.btnExit.TabIndex = 69;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(707, 513);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(265, 34);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Hủy đặt phòng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(307, 513);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(308, 34);
            this.btnEdit.TabIndex = 67;
            this.btnEdit.Text = "Sửa thông tin đặt";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookRoom.Location = new System.Drawing.Point(23, 513);
            this.btnBookRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(243, 34);
            this.btnBookRoom.TabIndex = 68;
            this.btnBookRoom.Text = "Đặt phòng";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // gbRoom
            // 
            this.gbRoom.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gbRoom.Controls.Add(this.lbGiaPhong);
            this.gbRoom.Controls.Add(this.lbPhong);
            this.gbRoom.Controls.Add(this.lb_GiaPhong);
            this.gbRoom.Controls.Add(this.label12);
            this.gbRoom.Controls.Add(this.dtpDayBook);
            this.gbRoom.Controls.Add(this.cboIDNV);
            this.gbRoom.Controls.Add(this.cboIDCustomer);
            this.gbRoom.Controls.Add(this.lb_nhanvien);
            this.gbRoom.Controls.Add(this.lb_phong);
            this.gbRoom.Controls.Add(this.label10);
            this.gbRoom.Controls.Add(this.label8);
            this.gbRoom.Controls.Add(this.lb_khach);
            this.gbRoom.Controls.Add(this.label5);
            this.gbRoom.Controls.Add(this.txtSLN);
            this.gbRoom.Controls.Add(this.label11);
            this.gbRoom.Controls.Add(this.txtIDRoom);
            this.gbRoom.Controls.Add(this.label3);
            this.gbRoom.Controls.Add(this.txtIDHoaDon);
            this.gbRoom.Controls.Add(this.label2);
            this.gbRoom.Controls.Add(this.txtSearch);
            this.gbRoom.Controls.Add(this.cboLuachon);
            this.gbRoom.Controls.Add(this.TK);
            this.gbRoom.Controls.Add(this.dgvRoom);
            this.gbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoom.Location = new System.Drawing.Point(23, 49);
            this.gbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Padding = new System.Windows.Forms.Padding(4);
            this.gbRoom.Size = new System.Drawing.Size(1251, 430);
            this.gbRoom.TabIndex = 65;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Thông tin dữ liệu  bảng";
            this.gbRoom.Enter += new System.EventHandler(this.gbRoom_Enter);
            // 
            // lbGiaPhong
            // 
            this.lbGiaPhong.AutoSize = true;
            this.lbGiaPhong.Location = new System.Drawing.Point(629, 345);
            this.lbGiaPhong.Name = "lbGiaPhong";
            this.lbGiaPhong.Size = new System.Drawing.Size(25, 24);
            this.lbGiaPhong.TabIndex = 64;
            this.lbGiaPhong.Text = "...";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(448, 346);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(25, 24);
            this.lbPhong.TabIndex = 63;
            this.lbPhong.Text = "...";
            // 
            // lb_GiaPhong
            // 
            this.lb_GiaPhong.AutoSize = true;
            this.lb_GiaPhong.Location = new System.Drawing.Point(515, 346);
            this.lb_GiaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_GiaPhong.Name = "lb_GiaPhong";
            this.lb_GiaPhong.Size = new System.Drawing.Size(113, 24);
            this.lb_GiaPhong.TabIndex = 62;
            this.lb_GiaPhong.Text = "Giá phòng : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1075, 306);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 61;
            // 
            // dtpDayBook
            // 
            this.dtpDayBook.CustomFormat = "yyyy-MM-dd";
            this.dtpDayBook.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayBook.Location = new System.Drawing.Point(886, 341);
            this.dtpDayBook.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDayBook.Name = "dtpDayBook";
            this.dtpDayBook.Size = new System.Drawing.Size(188, 29);
            this.dtpDayBook.TabIndex = 60;
            // 
            // cboIDNV
            // 
            this.cboIDNV.DataSource = this.nhanvienBindingSource;
            this.cboIDNV.DisplayMember = "Manv";
            this.cboIDNV.FormattingEnabled = true;
            this.cboIDNV.Location = new System.Drawing.Point(887, 291);
            this.cboIDNV.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDNV.Name = "cboIDNV";
            this.cboIDNV.Size = new System.Drawing.Size(187, 32);
            this.cboIDNV.TabIndex = 59;
            this.cboIDNV.TextChanged += new System.EventHandler(this.cboIDNV_TextChanged);
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "Nhanvien";
            this.nhanvienBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboIDCustomer
            // 
            this.cboIDCustomer.DataSource = this.khachhangBindingSource;
            this.cboIDCustomer.DisplayMember = "MaKh";
            this.cboIDCustomer.FormattingEnabled = true;
            this.cboIDCustomer.Location = new System.Drawing.Point(132, 369);
            this.cboIDCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cboIDCustomer.Name = "cboIDCustomer";
            this.cboIDCustomer.Size = new System.Drawing.Size(240, 32);
            this.cboIDCustomer.TabIndex = 59;
            this.cboIDCustomer.TextChanged += new System.EventHandler(this.cboIDCustomer_TextChanged);
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
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Location = new System.Drawing.Point(1083, 301);
            this.lb_nhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(59, 24);
            this.lb_nhanvien.TabIndex = 58;
            this.lb_nhanvien.Text = "Tên : ";
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Location = new System.Drawing.Point(395, 346);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(59, 24);
            this.lb_phong.TabIndex = 58;
            this.lb_phong.Text = "Tên : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(718, 346);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ngày đặt phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã nhân viên :";
            // 
            // lb_khach
            // 
            this.lb_khach.AutoSize = true;
            this.lb_khach.Location = new System.Drawing.Point(395, 383);
            this.lb_khach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_khach.Name = "lb_khach";
            this.lb_khach.Size = new System.Drawing.Size(59, 24);
            this.lb_khach.TabIndex = 58;
            this.lb_khach.Text = "Tên : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Mã khách";
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(886, 384);
            this.txtSLN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(187, 29);
            this.txtSLN.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(718, 384);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Số lượng người";
            // 
            // txtIDRoom
            // 
            this.txtIDRoom.Location = new System.Drawing.Point(132, 331);
            this.txtIDRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDRoom.Name = "txtIDRoom";
            this.txtIDRoom.ReadOnly = true;
            this.txtIDRoom.Size = new System.Drawing.Size(240, 29);
            this.txtIDRoom.TabIndex = 57;
            this.txtIDRoom.TextChanged += new System.EventHandler(this.txtIDRoom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã phòng";
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(132, 294);
            this.txtIDHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Size = new System.Drawing.Size(240, 29);
            this.txtIDHoaDon.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID hóa đơn";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(607, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 32);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Text = "Nhập từ khóa....";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboLuachon
            // 
            this.cboLuachon.FormattingEnabled = true;
            this.cboLuachon.Items.AddRange(new object[] {
            "Mã phòng",
            "Tên phòng",
            "Loại phòng",
            "Mô tả phòng",
            "Số người tối đa",
            "Trạng thái"});
            this.cboLuachon.Location = new System.Drawing.Point(207, 43);
            this.cboLuachon.Margin = new System.Windows.Forms.Padding(4);
            this.cboLuachon.Name = "cboLuachon";
            this.cboLuachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLuachon.Size = new System.Drawing.Size(333, 32);
            this.cboLuachon.TabIndex = 53;
            this.cboLuachon.Text = "-- Lựa chọn trường tìm kiếm--";
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TK.Location = new System.Drawing.Point(8, 50);
            this.TK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(178, 25);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm phòng :";
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRoom,
            this.NameRoom,
            this.TypeRoom,
            this.DescritionRoom,
            this.SLNMax,
            this.StatusRoom});
            this.dgvRoom.Location = new System.Drawing.Point(8, 85);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.Size = new System.Drawing.Size(1223, 201);
            this.dgvRoom.TabIndex = 0;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // IDRoom
            // 
            this.IDRoom.DataPropertyName = "MaPhong";
            this.IDRoom.HeaderText = "Mã phòng";
            this.IDRoom.MinimumWidth = 6;
            this.IDRoom.Name = "IDRoom";
            this.IDRoom.Width = 165;
            // 
            // NameRoom
            // 
            this.NameRoom.DataPropertyName = "TenPhong";
            this.NameRoom.HeaderText = "Tên phòng";
            this.NameRoom.MinimumWidth = 6;
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.Width = 135;
            // 
            // TypeRoom
            // 
            this.TypeRoom.DataPropertyName = "loaiphong";
            this.TypeRoom.HeaderText = "Loại phòng";
            this.TypeRoom.MinimumWidth = 6;
            this.TypeRoom.Name = "TypeRoom";
            this.TypeRoom.Width = 165;
            // 
            // DescritionRoom
            // 
            this.DescritionRoom.DataPropertyName = "Mota";
            this.DescritionRoom.HeaderText = "Mô tả";
            this.DescritionRoom.MinimumWidth = 6;
            this.DescritionRoom.Name = "DescritionRoom";
            this.DescritionRoom.Width = 165;
            // 
            // SLNMax
            // 
            this.SLNMax.DataPropertyName = "songtoida";
            this.SLNMax.HeaderText = "Số người tối đa";
            this.SLNMax.MinimumWidth = 6;
            this.SLNMax.Name = "SLNMax";
            this.SLNMax.Width = 125;
            // 
            // StatusRoom
            // 
            this.StatusRoom.DataPropertyName = "trangthai";
            this.StatusRoom.HeaderText = "Trạng thái";
            this.StatusRoom.MinimumWidth = 6;
            this.StatusRoom.Name = "StatusRoom";
            this.StatusRoom.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(556, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Đặt phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 572);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1251, 306);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(996, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 61;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_hoadon,
            this.MaPhong,
            this.Makh,
            this.Manv,
            this.Ngaydatphong,
            this.soluongnguoi,
            this.trangthai});
            this.dgvHoaDon.Location = new System.Drawing.Point(13, 28);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(1217, 188);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // id_hoadon
            // 
            this.id_hoadon.DataPropertyName = "id_hoadon";
            this.id_hoadon.HeaderText = "ID";
            this.id_hoadon.MinimumWidth = 6;
            this.id_hoadon.Name = "id_hoadon";
            this.id_hoadon.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // Makh
            // 
            this.Makh.DataPropertyName = "Makh";
            this.Makh.HeaderText = "Mã khách hàng";
            this.Makh.MinimumWidth = 6;
            this.Makh.Name = "Makh";
            this.Makh.Width = 125;
            // 
            // Manv
            // 
            this.Manv.DataPropertyName = "Manv";
            this.Manv.HeaderText = "Mã nhân viên";
            this.Manv.MinimumWidth = 6;
            this.Manv.Name = "Manv";
            this.Manv.Width = 125;
            // 
            // Ngaydatphong
            // 
            this.Ngaydatphong.DataPropertyName = "Ngaydatphong";
            this.Ngaydatphong.HeaderText = "Ngày đặt phòng";
            this.Ngaydatphong.MinimumWidth = 6;
            this.Ngaydatphong.Name = "Ngaydatphong";
            this.Ngaydatphong.Width = 125;
            // 
            // soluongnguoi
            // 
            this.soluongnguoi.DataPropertyName = "soluongnguoi";
            this.soluongnguoi.HeaderText = "Số lượng người";
            this.soluongnguoi.MinimumWidth = 6;
            this.soluongnguoi.Name = "soluongnguoi";
            this.soluongnguoi.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 807);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DatPhong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDayBook;
        private System.Windows.Forms.ComboBox cboIDNV;
        private System.Windows.Forms.ComboBox cboIDCustomer;
        private System.Windows.Forms.Label lb_nhanvien;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_khach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboLuachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydatphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongnguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private DataSet1TableAdapters.KhachhangTableAdapter khachhangTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private DataSet1TableAdapters.NhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescritionRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusRoom;
        private System.Windows.Forms.Label lb_GiaPhong;
        private System.Windows.Forms.Label lbGiaPhong;
        private System.Windows.Forms.Label lbPhong;
    }
}

