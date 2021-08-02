using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace BookRoom
{
    public partial class TraPhong : Form
    {
        DataTable dt = new DataTable();

        public TraPhong()
        {
            InitializeComponent();
            showGridThanhToan();
        }

        private void showGridThanhToan()
        {
           
            string strSelect = "select * from HoaDon";
            dt = (new DataProvider()).executeQuery(strSelect); 
            dgvHoaDon.DataSource = dt;

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            string strTraPhong = "update Hoadon set Ngaytraphong = '"+dtpNgayTra.Text+"', phiphong ='"+txtPhiPhong.Text+"', phiphuthu = '"+txtPiPhuThu.Text+"', thanhtien = '"+txtTongPhi.Text+"', trangthai = 'Da Tra Phong' where id_hoadon = '"+txtMaHD.Text+"'";
            string strUpdateDelete = "update Phong set trangthai = 'Trong' where MaPhong = '" + txtMaPhong.Text + "'";
            if ((new DataProvider()).executeNonQuery(strTraPhong)&& (new DataProvider()).executeNonQuery(strUpdateDelete))
            {
                MessageBox.Show("Ban da tra phong thanh cong!!!","Thong bao");
                showGridThanhToan();
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells["IDHD"].FormattedValue.ToString();
            txtMaPhong.Text = dgvHoaDon.Rows[e.RowIndex].Cells["IDPhong"].FormattedValue.ToString();
            txtMaKhach.Text = dgvHoaDon.Rows[e.RowIndex].Cells["IDKh"].FormattedValue.ToString();
            txtMaNV.Text = dgvHoaDon.Rows[e.RowIndex].Cells["IDNv"].FormattedValue.ToString();
            dtpNgayDat.Text = dgvHoaDon.Rows[e.RowIndex].Cells["NDP"].FormattedValue.ToString();
            dtpNgayThue.Text = dgvHoaDon.Rows[e.RowIndex].Cells["NNP"].FormattedValue.ToString();
            dtpNgayTra.Text = dgvHoaDon.Rows[e.RowIndex].Cells["NTP"].FormattedValue.ToString();
            txtSLN.Text = dgvHoaDon.Rows[e.RowIndex].Cells["SLN"].FormattedValue.ToString();
            txtPhiPhong.Text = dgvHoaDon.Rows[e.RowIndex].Cells["PhiPhong"].FormattedValue.ToString();
            txtPiPhuThu.Text = dgvHoaDon.Rows[e.RowIndex].Cells["PhiPhuThu"].FormattedValue.ToString();
            txtTongPhi.Text = dgvHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].FormattedValue.ToString();

        }

        private void lbTenkhach_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tenkh";
            if (txtMaKhach.Text != "")
            {
                string strSelectTKH = "select Tenkh from Khachhang where MaKh = '" + txtMaKhach.Text + "'";
                string fullname = (new DataProvider()).load_one_colums(strSelectTKH, cot);
                lbTenkhach.Text = "" + fullname;
                string strSelectPhuPhi = "select kh.MaKh, pt.tensp,pt.giaban, pt.soluong,pt.thanhtien from Khachhang as kh inner join Phuthu as pt " +
                    "on kh.MaKh = pt.MaKh where kh.MaKh = '"+txtMaKhach.Text+"'";
                dt = (new DataProvider()).executeQuery(strSelectPhuPhi);
                dgvPhuThu.DataSource = dt;
               
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            string cot = "TenPhong";
            string cot1 = "giaphong";
            if (txtMaPhong.Text != "")
            {
                string strSelectGiaRoom = "select lp.giaphong from Phong as p inner join LPhong as lp on p.loaiphong = lp.loaiphong where MaPhong = '"+txtMaPhong.Text+"'";
                string strSelectIDRoom = "select TenPhong from Phong where MaPhong = '" + txtMaPhong.Text + "'";
                string fullnameRoom = (new DataProvider()).load_one_colums(strSelectIDRoom, cot);
                string giaphong = (new DataProvider()).load_one_colums(strSelectGiaRoom, cot1);

                lbTenphong.Text = "" + fullnameRoom;
                lbGiaPhong.Text = "" + giaphong;
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            string cot = "Tennv";
            if (txtMaKhach.Text != "")
            {
                string strSelectTNV = "select Tennv from Nhanvien where Manv = '" + txtMaNV.Text + "'";
                string fullnameNV = (new DataProvider()).load_one_colums(strSelectTNV, cot);
                lbTennv.Text = "" + fullnameNV;
            }
        }

        private void txtPiPhuThu_TextChanged(object sender, EventArgs e)
        {
            string cot2 = "TongPhuThu";
            if (txtMaKhach.Text != "")
            {
                string strSelectPT = "select sum(thanhtien) as TongPhuThu from Phuthu where MaKh = '" + txtMaKhach.Text + "'";
                string TongPhuthu = (new DataProvider()).load_one_colums(strSelectPT, cot2);
                txtPiPhuThu.Text = "" + TongPhuthu;
            }
        }

        public double TotalRoom(int SNO, double gia)
        {
            double total = 0;
            return total = SNO * gia;
        }

        

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtPhiPhong_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DateTime ngaymuon = Convert.ToDateTime(dtpNgayThue.Value);
            DateTime ngaytra = Convert.ToDateTime(dtpNgayTra.Value);
            TimeSpan Time = ngaytra - ngaymuon;

            double TienPhuThu;
            int TongSoNgay = Time.Days;
            double GiaPhong = Convert.ToDouble(lbGiaPhong.Text);
            double tien = GiaPhong * TongSoNgay;
            // TienPhuThu = Convert.ToDouble(txtPiPhuThu.Text);
            if (string.IsNullOrEmpty(txtPiPhuThu.Text))
            {
                TienPhuThu = 0;
            }
            else
            {
                TienPhuThu = Convert.ToDouble(txtPiPhuThu.Text);
            }
            double tongtien = TienPhuThu + tien;
            lbSongaythue.Text = "" + TongSoNgay;
            txtPhiPhong.Text = "" + tien;
            txtTongPhi.Text = "" + tongtien;

            lbTenphieu.Text = "" + lbTenkhach.Text.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                showGridThanhToan();

            }
            else
            {
                string strSearchRoom = "";
                string text = txtSearch.Text;

                if (cboOption.SelectedIndex == 0)
                {
                    strSearchRoom = "select * from Hoadon where MaPhong like '%" + text + "%'";
                }
                if (cboOption.SelectedIndex == 1)
                {
                    strSearchRoom = "select * from Hoadon where Makh like '%" + text + "%'";
                }                

                dt = (new DataProvider()).executeQuery(strSearchRoom);
                dgvHoaDon.DataSource = dt;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;


            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            // see the excel sheet behind the program       
            app.Visible = true;




            bool failed = false;
            do
            {
                try
                {
                    worksheet.Cells[1, 1] = "Mã hóa đơn: \t" + txtMaHD.Text;
                    worksheet.Cells[2, 1] = "Tên phòng: \t" + lbTenphong.Text;
                    worksheet.Cells[2, 1] = "Tên phòng: \t" + lbTenphong.Text;
                    worksheet.Cells[3, 1] = "Giá phòng: \t" + lbGiaPhong.Text;
                    worksheet.Cells[4, 1] = "Tên khách: \t" + lbTenkhach.Text;
                    worksheet.Cells[5, 1] = "Tên nhân viên: \t" + lbTennv.Text;
                    worksheet.Cells[6, 1] = "Ngày đặt: \t" + dtpNgayDat.Text;
                    worksheet.Cells[7, 1] = "Ngày thuê: \t" + dtpNgayThue.Text;
                    worksheet.Cells[8, 1] = "Ngày trả phòng: \t" + dtpNgayTra.Text;
                    worksheet.Cells[9, 1] = "Số ngày thuê: \t" + lbSongaythue.Text;
                    worksheet.Cells[10, 1] = "Phí phòng: \t" + txtPhiPhong.Text;
                    worksheet.Cells[11, 1] = "Phí phụ thu: \t" + txtPiPhuThu.Text;
                    worksheet.Cells[12, 1] = "Tổng phí: \t" + txtTongPhi.Text;

                    worksheet.Cells[14, 1] = "ID";
                    worksheet.Cells[14, 2] = "Mã phòng";
                    worksheet.Cells[14, 3] = "Mã khách";
                    worksheet.Cells[14, 4] = "Mã nhân viên";
                    worksheet.Cells[14, 5] = "Ngày đặt";
                    worksheet.Cells[14, 6] = "Ngày nhận";
                    worksheet.Cells[14, 7] = "Ngày trả";
                    worksheet.Cells[14, 8] = "Số người";
                    worksheet.Cells[14, 9] = "Phí phòng";
                    worksheet.Cells[14, 10] = "Phụ thu";
                    worksheet.Cells[14, 11] = "Thành tiền";
                    worksheet.Cells[14, 12] = "Trạng thái";

                    for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvHoaDon.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 15, j + 1] = dgvHoaDon.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    failed = false;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    failed = true;
                }
                System.Threading.Thread.Sleep(10);
            } while (failed);
        }
    }
}
