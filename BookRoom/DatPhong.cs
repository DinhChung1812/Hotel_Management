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
    public partial class DatPhong : Form
    {
        DataTable dt = new DataTable();
        
        public DatPhong()
        {
            InitializeComponent();
            showGridRoom();
            showGridHoaDon();
           
        }

        private void showGridRoom()
        {
            string strSelectRoom = "select * from Phong";
            dt = (new DataProvider()).executeQuery(strSelectRoom);
            dgvRoom.DataSource = dt;
        }
        private void showGridHoaDon()
        {
            string strSelectHoaDon = "select hd.id_hoadon, hd.MaPhong, hd.Makh, hd.Manv, hd.Ngaydatphong, hd.soluongnguoi, hd.trangthai " +
                "from Hoadon as  hd INNER JOIN  Phong as p on hd.MaPhong = p.MaPhong ";
            dt = (new DataProvider()).executeQuery(strSelectHoaDon);
            dgvHoaDon.DataSource = dt;
        }

       // Dictionary<string, string> dic = new Dictionary<string, string>();
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            string strBookRoom = "insert into HoaDon (id_hoadon, MaPhong, Makh, Manv, Ngaydatphong,soluongnguoi, trangthai) " +
                "values ('"+txtIDHoaDon.Text.Trim()+"','"+txtIDRoom.Text.Trim()+"','"+cboIDCustomer.Text.Trim()+"','"+cboIDNV.Text.Trim()+"','"+dtpDayBook.Value.ToString()+"','"+txtSLN.Text.Trim()+"', 'Da dat');";
            string strUpdate = "update Phong set trangthai = 'Da Dat' where MaPhong = '"+txtIDRoom.Text+"'";

            //if (dic.ContainsKey(txtIDHoaDon.Text.Trim()))
            //{
            //    MessageBox.Show( "Da ton tai", "Alert");
            //}

            if ((new DataProvider()).executeNonQuery(strBookRoom) )
            {
                if ((new DataProvider()).executeNonQuery(strUpdate))
                {
                    MessageBox.Show("Cap nhat trang thai thanh cong", "Thong bao!!!");
                }
                MessageBox.Show("Dat phong thanh cong", "Thong bao!!!");


            }
            else
            {
                MessageBox.Show("Dat phong that bai", "Thong bao!!!");
            }
            showGridRoom();
            showGridHoaDon();

        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDRoom.Text = dgvRoom.Rows[e.RowIndex].Cells["IDRoom"].FormattedValue.ToString();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.dataSet11.Nhanvien);
            // TODO: This line of code loads data into the 'dataSet1.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.dataSet1.Khachhang);

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
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

                if (cboLuachon.SelectedIndex == 0)
                {
                    strSearchRoom = "select * from Phong where MaPhong like '%" + text + "%'";
                }
                if (cboLuachon.SelectedIndex == 1)
                {
                    strSearchRoom = "select * from Phong where TenPhong like '%" + text + "%'";
                }
                if (cboLuachon.SelectedIndex == 2)
                {
                    strSearchRoom = "select * from Phong where loaiphong like '%" + text + "%'";
                }
                if (cboLuachon.SelectedIndex == 3)
                {
                    strSearchRoom = "select * from Phong where Mota like '%" + text + "%'";
                }
                if (cboLuachon.SelectedIndex == 4)
                {
                    strSearchRoom = "select * from Phong where songtoida like '%" + text + "%'";
                }
                if (cboLuachon.SelectedIndex == 5)
                {
                    strSearchRoom = "select * from Phong where trangthai like '%" + text + "%'";
                }


                dt = (new DataProvider()).executeQuery(strSearchRoom);
                dgvRoom.DataSource = dt;
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDHoaDon.Text = dgvHoaDon.Rows[e.RowIndex].Cells["id_hoadon"].FormattedValue.ToString();
            txtIDRoom.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MaPhong"].FormattedValue.ToString();
            cboIDCustomer.Text = dgvHoaDon.Rows[e.RowIndex].Cells["Makh"].FormattedValue.ToString();
            cboIDNV.Text = dgvHoaDon.Rows[e.RowIndex].Cells["Manv"].FormattedValue.ToString();
            dtpDayBook.Text = dgvHoaDon.Rows[e.RowIndex].Cells["Ngaydatphong"].FormattedValue.ToString();
            txtSLN.Text = dgvHoaDon.Rows[e.RowIndex].Cells["soluongnguoi"].FormattedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string strDelete = "delete from Hoadon where id_hoadon = '"+txtIDHoaDon.Text+"'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string strSua = "update Hoadon set MaPhong = '"+txtIDRoom.Text+"', Makh = '"+cboIDCustomer.Text+"', Manv = '"+cboIDNV.Text+"', soluongnguoi = '"+txtSLN.Text+"' where id_hoadon = '"+txtIDHoaDon.Text+"'";
            if ((new DataProvider()).executeNonQuery(strSua))
            {
                MessageBox.Show("ban sua thanh cong", "Thong bao");
                showGridHoaDon();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
               
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

                lbPhong.Text = "" + fullnameRoom;
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

        private void gbRoom_Enter(object sender, EventArgs e)
        {

        }
    }
}
