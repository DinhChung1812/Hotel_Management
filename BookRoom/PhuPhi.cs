using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookRoom
{
    public partial class PhuPhi : Form
    {

        DataTable dt = new DataTable();
        public PhuPhi()
        {
            InitializeComponent();
            showGridSanPham();
            showGridPhuThu();
        }

        public void showGridSanPham()
        {
            string strSelectSP = "select * from Khohang";
            dt = (new DataProvider()).executeQuery(strSelectSP);
            dgvSanPham.DataSource = dt;
            
        }

        public void showGridPhuThu()
        {
            string strSelectPhuThu = "select pt.MaPhu, pt.MaKh, pt.Maitem, pt.tensp, pt.soluong, kh.giaban, pt.trangthai, pt.thanhtien from Khohang as kh inner join Phuthu as pt " +
                "on kh.Maitem = pt.Maitem";
            dt = (new DataProvider()).executeQuery(strSelectPhuThu);
            dgvPhuThu.DataSource = dt;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["IDSP"].FormattedValue.ToString();
            txtSLConLai.Text = dgvSanPham.Rows[e.RowIndex].Cells["SL"].FormattedValue.ToString();
            txtGiaBan.Text = dgvSanPham.Rows[e.RowIndex].Cells["GiaBan"].FormattedValue.ToString();
            txtNameProduct.Text = dgvSanPham.Rows[e.RowIndex].Cells["NameSP"].FormattedValue.ToString();
        }

        public double TinhPhuThu(int a, double b)
        {
            double total = 0;
            total = a * b;
            return total;
        }

        private void txtSLBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaSP.Text))
                {
                    int slban = Convert.ToInt32(txtSLBan.Text);
                    double gia = Convert.ToDouble(txtGiaBan.Text);
                    double thanhtien = TinhPhuThu(slban, gia);
                    txtThanhTien.Text = thanhtien.ToString();
                }
                else
                {
                    MessageBox.Show("Ban can chon san pham", "Thong bao!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ban can nhap so", "Thong bao!!!");
                txtSLBan.Text = "";
                txtSLBan.Focus();
            }
            
        }

        private void PhuPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.dataSet1.Khachhang);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strThem = "insert into Phuthu(MaPhu,MaKh, Maitem, tensp,giaban,soluong,trangthai,thanhtien) " +
                "values ('"+txtMaPT.Text+"','"+cboIDCus.Text+"','"+txtMaSP.Text+"','"+txtNameProduct.Text+"','"+txtGiaBan.Text+"','"+txtSLBan.Text+"','0','"+txtThanhTien.Text+"')";
            if ((new DataProvider()).executeNonQuery(strThem))
            {
                MessageBox.Show("Ban them phu thu thanh cong", "Thong bao!!!");
                showGridPhuThu();
            }
            else
            {
                MessageBox.Show("Ban them phu thu that bai", "Thong bao!!!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strXoaPhuThu = "delete from Phuthu where MaPhu = '"+txtMaPT.Text+"'";
            if ((new DataProvider()).executeNonQuery(strXoaPhuThu))
            {
                MessageBox.Show("Ban xoa phu thu thanh cong", "Thong bao!!!");
                showGridPhuThu();
            }
        }

        private void dgvPhuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPT.Text = dgvPhuThu.Rows[e.RowIndex].Cells["idPhu"].FormattedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string strSua = "update Phuthu set MaKh = '"+cboIDCus.Text+"' where MaPhu = '"+txtMaPT.Text+"'";
            if ((new DataProvider()).executeNonQuery(strSua))
            {
                MessageBox.Show("Ban sua phu thu thanh cong", "Thong bao!!!");
                showGridPhuThu();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPT.Text = "";
            cboIDCus.Text = "kh01";
            txtMaSP.Text = "";
            txtNameProduct.Text = "";
            txtSLConLai.Text = "";
            txtSLBan.Text = "";
            txtGiaBan.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnChotPhi_Click(object sender, EventArgs e)
        {
            string strChotPhi = "update Phuthu set trangthai = '1' where MaPhu = '" + txtMaPT.Text + "'";
            if ((new DataProvider()).executeNonQuery(strChotPhi))
            {
                MessageBox.Show("Ban chot phi phu thu thanh cong", "Thong bao!!!");
                Console.WriteLine();
                showGridPhuThu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

            }
        }

        private void cboIDCus_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tenkh";
            if (cboIDCus.Text != "")
            {
                string strSelectTKH = "select Tenkh from Khachhang where MaKh = '" + cboIDCus.Text + "'";
                string fullname = (new DataProvider()).load_one_colums(strSelectTKH, cot);
                lb_tenk.Text = "" + fullname;

            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text))
            {
                showGridSanPham();

            }
            else
            {
                string text = txtTenSP.Text;
                string strSearchSP = "select * from Khohang where TenItem like N'%" + text + "%'";

                dt = (new DataProvider()).executeQuery(strSearchSP);
                dgvSanPham.DataSource = dt;
            }
        }

        private void txtTenSP_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
        }
    }
}
