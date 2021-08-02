using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;


namespace Login
{
    public partial class FrmQLKhach : Form
    {
               public FrmQLKhach()
        {
            InitializeComponent();
        }

        private void Imformation_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        public void loadGrid()
        {
            DataTable dt = (new BUSManageAccount()).loadKhach();
            dgvInformation.DataSource = dt;
            dgvInformation.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                  
            if (new BUSManageAccount().Them(txtCode.Text,txtTen.Text,dtpDob.Value.ToString(),cbGioiTinh.SelectedItem.ToString(),txtSDT.Text,txtCMND.Text,txtEmail.Text)) 
            {
                MessageBox.Show("Thêm thành công thanh cong", "Thong bao", MessageBoxButtons.OK);
                loadGrid(); 
            }
            else
            {
                MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK);
            }           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (new BUSManageAccount().Sua(txtCode.Text, txtTen.Text, dtpDob.Value.ToString(), cbGioiTinh.SelectedItem.ToString(), txtSDT.Text, txtCMND.Text, txtEmail.Text))
            {
                MessageBox.Show("Sửa thành công thanh cong", "Thong bao", MessageBoxButtons.OK);
                loadGrid();
            }
            else
            {
                MessageBox.Show("Sửa that bai", "Thong bao", MessageBoxButtons.OK);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (new BUSManageAccount().Xoa(txtCode.Text))
            {
                MessageBox.Show("Xóa thành công thanh cong", "Thong bao", MessageBoxButtons.OK);
                loadGrid();

            }
            else
            {
                MessageBox.Show("Xóa that bai", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtEmail.Text = "";
            dtpDob.Value = DateTime.Now;
            txtTen.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            cbGioiTinh.SelectedIndex = 0;
            loadGrid();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

            }
        }
        int indexRow;

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (new BUSManageAccount()).serachKH(txtNameSearch.Text);
            dgvInformation.DataSource = dt;
        }

        private void dgvInformation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRows = 0;
            try
            {
                indexRows = e.RowIndex;
                DataGridViewRow row = dgvInformation.Rows[indexRows];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                dtpDob.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtCMND.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                cbGioiTinh.SelectedItem = row.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
