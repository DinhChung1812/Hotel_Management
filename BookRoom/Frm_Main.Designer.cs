
namespace Login
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.men_ht = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlp = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qldp = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlhd = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlkh = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qltk = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_ht,
            this.men_qlp,
            this.men_qldp,
            this.men_qlnv,
            this.men_qlhd,
            this.men_qlkh,
            this.men_qltk,
            this.quảnLýDịchVụToolStripMenuItem,
            this.quảnLýTrảPhòngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // men_ht
            // 
            this.men_ht.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.men_ht.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_ht.Name = "men_ht";
            this.men_ht.Size = new System.Drawing.Size(104, 27);
            this.men_ht.Text = "tài khoản ";
            this.men_ht.Click += new System.EventHandler(this.men_ht_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // men_qlp
            // 
            this.men_qlp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qlp.Name = "men_qlp";
            this.men_qlp.Size = new System.Drawing.Size(145, 27);
            this.men_qlp.Text = "Quản Lý Phòng";
            this.men_qlp.Click += new System.EventHandler(this.men_qlp_Click);
            // 
            // men_qldp
            // 
            this.men_qldp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qldp.Name = "men_qldp";
            this.men_qldp.Size = new System.Drawing.Size(189, 27);
            this.men_qldp.Text = "Quảng Lý đặt phòng";
            this.men_qldp.Click += new System.EventHandler(this.men_qldp_Click);
            // 
            // men_qlnv
            // 
            this.men_qlnv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qlnv.Name = "men_qlnv";
            this.men_qlnv.Size = new System.Drawing.Size(171, 27);
            this.men_qlnv.Text = "Quản Lý nhân viên";
            this.men_qlnv.Click += new System.EventHandler(this.men_qlnv_Click);
            // 
            // men_qlhd
            // 
            this.men_qlhd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qlhd.Name = "men_qlhd";
            this.men_qlhd.Size = new System.Drawing.Size(190, 27);
            this.men_qlhd.Text = "Quản Lý Thuê phòng";
            this.men_qlhd.Click += new System.EventHandler(this.men_qlhd_Click);
            // 
            // men_qlkh
            // 
            this.men_qlkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qlkh.Name = "men_qlkh";
            this.men_qlkh.Size = new System.Drawing.Size(182, 27);
            this.men_qlkh.Text = "Quản lý khách hàng";
            this.men_qlkh.Click += new System.EventHandler(this.men_qlkh_Click);
            // 
            // men_qltk
            // 
            this.men_qltk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTàiKhoảnToolStripMenuItem,
            this.chỉnhSửaTàiKhoảnToolStripMenuItem});
            this.men_qltk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_qltk.Name = "men_qltk";
            this.men_qltk.Size = new System.Drawing.Size(165, 27);
            this.men_qltk.Text = "Quản lý tài khoản";
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm tài khoản";
            this.thêmTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thêmTàiKhoảnToolStripMenuItem_Click);
            // 
            // chỉnhSửaTàiKhoảnToolStripMenuItem
            // 
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Name = "chỉnhSửaTàiKhoảnToolStripMenuItem";
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Text = "Chỉnh sửa tài khoản";
            this.chỉnhSửaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            this.quảnLýDịchVụToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            this.quảnLýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            this.quảnLýDịchVụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDịchVụToolStripMenuItem_Click);
            // 
            // quảnLýTrảPhòngToolStripMenuItem
            // 
            this.quảnLýTrảPhòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTrảPhòngToolStripMenuItem.Name = "quảnLýTrảPhòngToolStripMenuItem";
            this.quảnLýTrảPhòngToolStripMenuItem.Size = new System.Drawing.Size(170, 27);
            this.quảnLýTrảPhòngToolStripMenuItem.Text = "Quản lý trả phòng";
            this.quảnLýTrảPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTrảPhòngToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 439);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(159, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng có khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(159, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng đặt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(159, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phòng trống";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(428, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1082, 439);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hinh1.png");
            this.imageList1.Images.SetKeyName(1, "iconHomeRed.jpg");
            this.imageList1.Images.SetKeyName(2, "iconHomeYellow.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1522, 519);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem men_ht;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_qlp;
        private System.Windows.Forms.ToolStripMenuItem men_qldp;
        private System.Windows.Forms.ToolStripMenuItem men_qlnv;
        private System.Windows.Forms.ToolStripMenuItem men_qlhd;
        private System.Windows.Forms.ToolStripMenuItem men_qlkh;
        private System.Windows.Forms.ToolStripMenuItem men_qltk;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaTàiKhoảnToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảPhòngToolStripMenuItem;
    }
}