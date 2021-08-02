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
    public partial class ThuePhong : Form
    {
        DataTable dt = new DataTable();
        public ThuePhong()
        {
            InitializeComponent();
            showGridRoom();
            showGridHoaDon();
            showGridHoaDon2();
        }

        private void showGridRoom()
        {
            string strSelectRoom = "select * from Phong";
            dt = (new DataProvider()).executeQuery(strSelectRoom);
            dgvRoom.DataSource = dt;
        }
        private void showGridHoaDon()
        {
            string strSelectHoaDon = "select hd.id_hoadon, hd.MaPhong, hd.Makh, hd.Manv, hd.Ngaynhanphong, hd.soluongnguoi, hd.trangthai " +
                "from Hoadon as  hd INNER JOIN  Phong as p on hd.MaPhong = p.MaPhong ";
            dt = (new DataProvider()).executeQuery(strSelectHoaDon);
            dgvBookRoom.DataSource = dt;
        }

        private void showGridHoaDon2()
        {
            string strSelectHoaDon = "select hd.id_hoadon, hd.MaPhong, hd.Makh, hd.Manv, hd.Ngaynhanphong, hd.soluongnguoi, p.trangthai " +
                "from Hoadon as  hd INNER JOIN  Phong as p on hd.MaPhong = p.MaPhong ";
            dt = (new DataProvider()).executeQuery(strSelectHoaDon);
            dgvThuePhong2.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                showGridRoom();

            }
            else
            {
                string strSearchRoom = "";
                string text = txtSearch.Text;

                if (cboOption.SelectedIndex == 0)
                {
                    strSearchRoom = "select * from Phong where MaPhong like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 1)
                {
                    strSearchRoom = "select * from Phong where TenPhong like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 2)
                {
                    strSearchRoom = "select * from Phong where loaiphong like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 3)
                {
                    strSearchRoom = "select * from Phong where Mota like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 4)
                {
                    strSearchRoom = "select * from Phong where songtoida like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 5)
                {
                    strSearchRoom = "select * from Phong where trangthai like '%" + text + "%'";
                }


                dt = (new DataProvider()).executeQuery(strSearchRoom);
                dgvRoom.DataSource = dt;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.dataSet1.Nhanvien);
            // TODO: This line of code loads data into the 'dataSet1.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.dataSet1.Khachhang);

        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string strBookRoom = "insert into HoaDon (id_hoadon, MaPhong, Makh, Manv, Ngaynhanphong ,soluongnguoi, trangthai) " +
                "values ('" + txtIDHoaDon.Text.Trim() + "','" + txtIDRoom.Text.Trim() + "','" + cboIDCustomer.Text.Trim() + "','" + cboIDNV.Text.Trim() + "','" + dtpBookRoom.Value.ToString() + "','" + txtSLN.Text.Trim() + "','Dang thue');";
            string strUpdate = "update Phong set trangthai = 'Dang thue' where MaPhong = '" + txtIDRoom.Text + "'";

            if ((new DataProvider()).executeNonQuery(strBookRoom))
            {
                if ((new DataProvider()).executeNonQuery(strUpdate))
                {
                    MessageBox.Show("Cap nhat trang thai thanh cong", "Thong bao!!!");
                }
                MessageBox.Show("Thue phong thanh cong", "Thong bao!!!");


            }
            else
            {
                MessageBox.Show("Thue phong that bai", "Thong bao!!!");
            }
            showGridRoom();
            showGridHoaDon();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDRoom.Text = dgvRoom.Rows[e.RowIndex].Cells["IDRoom"].FormattedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string strDelete = "delete from HoaDon where id_hoadon = '" + txtIDHoaDon.Text + "'";
            string strUpdateDelete = "update Phong set trangthai = 'Trong' where MaPhong = '" + txtIDRoom.Text + "'";
            if ((new DataProvider()).executeNonQuery(strDelete))
            {
                if ((new DataProvider()).executeNonQuery(strUpdateDelete))
                {
                    MessageBox.Show("ban xoa thanh cong", "Thong bao");
                    showGridRoom();
                    showGridHoaDon();
                }
            }
        }

        private void dgvBookRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDHoaDon.Text = dgvBookRoom.Rows[e.RowIndex].Cells["IDHoaDon"].FormattedValue.ToString();
            txtIDRoom.Text = dgvBookRoom.Rows[e.RowIndex].Cells["IDBookRoom"].FormattedValue.ToString();
            cboIDCustomer.Text = dgvBookRoom.Rows[e.RowIndex].Cells["IDCusBook"].FormattedValue.ToString();
            cboIDNV.Text = dgvBookRoom.Rows[e.RowIndex].Cells["IDNVBook"].FormattedValue.ToString();
            dtpBookRoom.Text = dgvBookRoom.Rows[e.RowIndex].Cells["DayBookRoom"].FormattedValue.ToString();
            txtSLN.Text = dgvBookRoom.Rows[e.RowIndex].Cells["SLN"].FormattedValue.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strSua = "update Hoadon set MaPhong = '" + txtIDRoom.Text + "', Makh = '" + cboIDCustomer.Text + "', Manv = '" + cboIDNV.Text + "', soluongnguoi = '" + txtSLN.Text + "' where id_hoadon = '" + txtIDHoaDon.Text + "'";
            string strSuaRoom = "update Phong set trangthai = 'Da Dat' where MaPhong = '" + txtIDRoom.Text + "'";
            if ((new DataProvider()).executeNonQuery(strSua))
            {
                if ((new DataProvider()).executeNonQuery(strSuaRoom))
                {
                    MessageBox.Show("ban sua thanh cong", "Thong bao");
                    showGridHoaDon();
                    showGridRoom();
                }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon chuyen sang Phu phi khong ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                PhuPhi pp = new PhuPhi();
                pp.ShowDialog();
            }
        }

        private void txtIDRoom_TextChanged(object sender, EventArgs e)
        {
            string cot = "TenPhong";
            string cot1 = "giaphong";
            if (txtIDRoom.Text != "")
            {
                string strSelectGiaRoom = "select lp.giaphong from Phong as p inner join LPhong as lp on p.loaiphong = lp.loaiphong where MaPhong = '" + txtIDRoom.Text + "'";
                string strSelectIDRoom = "select TenPhong from Phong where MaPhong = '" + txtIDRoom.Text + "'";
                string fullnameRoom = (new DataProvider()).load_one_colums(strSelectIDRoom, cot);
                string giaphong = (new DataProvider()).load_one_colums(strSelectGiaRoom, cot1);

                lbTenphong.Text = "" + fullnameRoom;
                lbGiaPhong.Text = "" + giaphong;
            }
        }

        private void cboIDCustomer_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tenkh";
            if (cboIDCustomer.Text != "")
            {
                string strSelectTKH = "select Tenkh from Khachhang where MaKh = '" + cboIDCustomer.Text + "'";
                string fullname = (new DataProvider()).load_one_colums(strSelectTKH, cot);
                lb_khach.Text = "" + fullname;

            }
        }

        private void cboIDNV_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tennv";
            if (cboIDNV.Text != "")
            {
                string strSelectTNV = "select Tennv from Nhanvien where Manv = '" + cboIDNV.Text + "'";
                string fullnameNV = (new DataProvider()).load_one_colums(strSelectTNV, cot);
                lb_nhanvien.Text = "" + fullnameNV;
            }
        }

        private void dgvThuePhong2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDHD2.Text = dgvThuePhong2.Rows[e.RowIndex].Cells["idhd"].FormattedValue.ToString();
            txtIDRoom2.Text = dgvThuePhong2.Rows[e.RowIndex].Cells["maphong"].FormattedValue.ToString();
            cboIDCus2.Text = dgvThuePhong2.Rows[e.RowIndex].Cells["makhach"].FormattedValue.ToString();
            cboIDNV2.Text = dgvThuePhong2.Rows[e.RowIndex].Cells["manv"].FormattedValue.ToString();
            txtSLN2.Text = dgvThuePhong2.Rows[e.RowIndex].Cells["soluongnguoi"].FormattedValue.ToString();
        }

        private void txtIDRoom2_TextChanged(object sender, EventArgs e)
        {
            string cot = "TenPhong";
            string cot1 = "giaphong";
            if (txtIDRoom2.Text != "")
            {
                string strSelectIDRoom = "select TenPhong from Phong where MaPhong = '" + txtIDRoom2.Text + "'";
                string strSelectGiaRoom = "select lp.giaphong from Phong as p inner join LPhong as lp on p.loaiphong = lp.loaiphong where MaPhong = '" + txtIDRoom2.Text + "'";
                
                string fullnameRoom = (new DataProvider()).load_one_colums(strSelectIDRoom, cot);
                string giaphong = (new DataProvider()).load_one_colums(strSelectGiaRoom, cot1);

                lb_name_p2.Text = "" + fullnameRoom;
                lb_GiaPhong1.Text = "" + giaphong;
            }
        }

        private void cboIDCus2_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tenkh";
            if (cboIDCus2.Text != "")
            {
                string strSelectTKH = "select Tenkh from Khachhang where MaKh = '" + cboIDCus2.Text + "'";
                string fullname = (new DataProvider()).load_one_colums(strSelectTKH, cot);
                lb_namek2.Text = "" + fullname;

            }
        }

        private void cboIDNV2_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tennv";
            if (cboIDNV2.Text != "")
            {
                string strSelectTNV = "select Tennv from Nhanvien where Manv = '" + cboIDNV2.Text + "'";
                string fullnameNV = (new DataProvider()).load_one_colums(strSelectTNV, cot);
                lb_name_nv2.Text = "" + fullnameNV;
            }
        }

        private void btnThue2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtIDHD2.Text.Trim());
            Console.WriteLine(txtIDRoom.Text.Trim());
            Console.WriteLine(cboIDCus2.Text.Trim());
            Console.WriteLine(cboIDNV2.Text.Trim());
            Console.WriteLine();
            Console.WriteLine(txtSLN2.Text.Trim());

            string strBookRoom = "update Hoadon set Ngaynhanphong = '"+ dtpNgayThue2.Value.ToString() + "', trangthai = 'Da thue' where id_hoadon = '"+ txtIDHD2.Text.Trim() + "'";
            string strUpdate = "update Phong set trangthai = 'Dang thue' where MaPhong = '" + txtIDRoom2.Text + "'";

            if ((new DataProvider()).executeNonQuery(strBookRoom))
            {
                if ((new DataProvider()).executeNonQuery(strUpdate))
                {
                    MessageBox.Show("Cap nhat trang thai thanh cong", "Thong bao!!!");
                }
                MessageBox.Show("Thue phong thanh cong", "Thong bao!!!");


            }
            else
            {
                MessageBox.Show("Thue Phong that bai", "Thong bao!!!");
            }
            showGridRoom();
            showGridHoaDon();
            showGridHoaDon2();
        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            string strDelete = "delete from HoaDon where id_hoadon = '" + txtIDHD2.Text + "'";
            string strUpdateDelete = "update Phong set trangthai = 'Trong' where MaPhong = '" + txtIDRoom2.Text + "'";
            if ((new DataProvider()).executeNonQuery(strDelete))
            {
                if ((new DataProvider()).executeNonQuery(strUpdateDelete))
                {
                    MessageBox.Show("ban xoa thanh cong", "Thong bao");
                    showGridRoom();
                    showGridHoaDon();
                }
            }
        }

        private void dtpBookRoom_ValueChanged(object sender, EventArgs e)
        {

        }
        public void showGrid2()
        {
            string sql = "";
            dt = (new DataProvider()).executeQuery(sql);
            dgvThuePhong2.DataSource = dt;
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            string strUpdatePhong = "update Hoadon set Ngaynhanphong = '" + dtpNgayThue2.Text + "' where id_hoadon = '" + txtIDHD2.Text + "'";
            if ((new DataProvider()).executeNonQuery(strUpdatePhong))
            {
                MessageBox.Show("Update thanh cong");
                showGridHoaDon2();
            }
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

            }
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch2.Text))
            {
                showGridHoaDon2();

            }
            else
            {
                string strSearchRoom = "";
                string text = txtSearch2.Text;

                if (cboOption2.SelectedIndex == 0)
                {
                    strSearchRoom = "select hd.id_hoadon, hd.MaPhong, hd.Makh, hd.Manv, hd.Ngaynhanphong, hd.soluongnguoi, p.trangthai from Hoadon as  hd INNER JOIN  Phong as p on hd.MaPhong = p.MaPhong where p.MaPhong like '%" + text + "%'";
                }
                if (cboOption2.SelectedIndex == 1)
                {
                    strSearchRoom = "select hd.id_hoadon, hd.MaPhong, hd.Makh, hd.Manv, hd.Ngaynhanphong, hd.soluongnguoi, p.trangthai from Hoadon as  hd INNER JOIN  Phong as p on hd.MaPhong = p.MaPhong where hd.Makh like '%" + text + "%'";
                }

                dt = (new DataProvider()).executeQuery(strSearchRoom);
                dgvThuePhong2.DataSource = dt;
            }
        }

        private void txtSearch2_Click(object sender, EventArgs e)
        {
            txtSearch2.Text = "";
        }
    }
}
