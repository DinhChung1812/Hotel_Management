using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Login
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        public void loadGrid()
        {
            dt = (new BUSRom()).loadRoom();
            dgvRoom.DataSource = dt;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadGrid();
            
        }

        private void btnBookroom_Click(object sender, EventArgs e)
        {

        }
        int index;
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvRoom.Rows[index];
            txtRoomID.Text = row.Cells[0].Value.ToString();
            txtRoom.Text = row.Cells[1].Value.ToString();
            txtRoomPrice.Text = row.Cells[6].Value.ToString();
            // txtStatus.Text = row.Cells[5].Value.ToString();
            cbTrangThai.SelectedItem = row.Cells[5].Value.ToString();
            cboRoomType.SelectedItem = row.Cells[2].Value.ToString();
            txtRoomFloor.Text = row.Cells[1].Value.ToString().Substring(0,1);
            txtMoTa.Text = row.Cells[3].Value.ToString();
            numSongToiDa.Value = Convert.ToInt32(row.Cells[4].Value.ToString());  
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((new BUSRom()).addRoom(txtRoomID.Text,txtRoom.Text,cboRoomType.SelectedItem.ToString(),txtMoTa.Text,numSongToiDa.Value.ToString(),cbTrangThai.SelectedItem.ToString()))
            {
                MessageBox.Show("thêm phòng thành công!!!", "Thong Bao!!!");
                loadGrid();
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại!!!", "Thong Bao!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((new BUSRom()).UpdateRoom(txtRoomID.Text, txtRoom.Text, cboRoomType.SelectedItem.ToString(), txtMoTa.Text, numSongToiDa.Value.ToString(), cbTrangThai.SelectedItem.ToString()))
            {
                MessageBox.Show("Sửa thông tin phòng thành công!!!", "Thong Bao!!!");
                loadGrid();
            }
            else
            {
                MessageBox.Show("Sửa thông tin phòng thất bại!!!", "Thong Bao!!!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((new BUSRom()).DeleteRoom(txtRoomID.Text))
            {
                MessageBox.Show("Xóa phòng thành công!!!", "Thong Bao!!!");
                loadGrid();
            }
            else
            {
                MessageBox.Show("Xóa phòng thất bại!!!", "Thong Bao!!!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = "";
            cboRoomType.SelectedIndex = 0;
            txtRoomFloor.Text = "";
            txtRoom.Text = "";
            txtRoomPrice.Text = "";
            cbTrangThai.SelectedIndex = -1;
            txtSearch.Text = "";
            cboOptionSearch.SelectedIndex = -1;
            loadGrid();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong???", "Thong bao???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Frm_Main m = new Frm_Main();
                m.Show();



            }

        }

        private void txtRoomDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = cboOptionSearch.SelectedIndex;
            string text = txtSearch.Text;
            DataTable dt = (new BUSRom()).searchRoom(n, text);
            dgvRoom.DataSource = dt;

        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomType.SelectedIndex==0)
            {
                txtRoomPrice.Text = "600000";
            }
            if (cboRoomType.SelectedIndex==1)
            {
                txtRoomPrice.Text = "300000";
            }
            if (cboRoomType.SelectedIndex==2)
            {
                txtRoomPrice.Text = "400000";
            }
            if (cboRoomType.SelectedIndex==3)
            {
                txtRoomPrice.Text = "500000";
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
