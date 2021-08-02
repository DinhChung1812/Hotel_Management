using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using HtmlAgilityPack;
//using xNet;


using BUS;

namespace Login
{
    public partial class FrmQLNV : Form
    {
        public FrmQLNV()
        {
            InitializeComponent();
        }
        public void showGrid()
        {
            dgvLoadNV.DataSource= (new BUSQLNV()).loadDSNV();
        }

        private void FrmQLNV_Load(object sender, EventArgs e)
        {
            showGrid();
        }
             public string Gender(ComboBox cbG)
        {
            if (cbG.SelectedIndex==0)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public string boPhan(ComboBox cbBP)
        {
            if (cbBP.SelectedIndex==0)
            {
                return "LT";
            }
            else
            {
                return "KT";
            }
        }
         private void btnThem_Click(object sender, EventArgs e)
        {
            //checkEmail(txtEmail);
            //checkSDT(txtSDT);

                if (checkSDT(txtSDT) == true&& checkEmail(txtEmail) == true)
                {


                    if ((new BUSQLNV()).Them(txtCode.Text, txtName.Text, dtpDOB.Value.ToString(), cbGender.SelectedItem.ToString(), txtSDT.Text, txtcmnd.Text, txtEmail.Text))
                    {
                        MessageBox.Show("Them thanh cong", "Thông báo", MessageBoxButtons.OK);
                        showGrid();
                    }
                    else
                    {
                        MessageBox.Show("Them thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin nhập vào", "Thông báo", MessageBoxButtons.OK);
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((new BUSQLNV()).Xoa(txtCode.Text))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                showGrid();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        int index;
        private void dgvLoadNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvLoadNV.Rows[index];
            txtCode.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            dtpDOB.Value = DateTime.Parse(row.Cells[2].Value.ToString());

           
            if (row.Cells[3].Value.ToString()=="Nam")
            {
                cbGender.SelectedIndex = 0;
            }
            if(row.Cells[3].Value.ToString() == "Nữ")
            {
                cbGender.SelectedIndex = 1;
            }
            txtSDT.Text = row.Cells[4].Value.ToString();
            txtcmnd.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((new BUSQLNV()).Sua(txtCode.Text, txtName.Text, dtpDOB.Value.ToString(), cbGender.SelectedItem.ToString(), txtSDT.Text, txtcmnd.Text, txtEmail.Text))
            {
                MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK);
                showGrid();
            }
            else
            {
                MessageBox.Show("Update thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (new BUSQLNV()).searchNV(txtSearch.Text);
            dgvLoadNV.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ???", "Thong bao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

            }
        }
         public bool checkEmail(TextBox t)
        {
            string email = t.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success) { 
                // MessageBox.Show("Email không đúng", "Thông báo", MessageBoxButtons.OK);
                return true;
                    }else{
            return false;
        }
        }
        public bool checkSDT(TextBox t)
        {
            string sdt = t.Text;
            if (sdt.All(Char.IsDigit)||sdt.Length>=9)
            {
                // MessageBox.Show("Sai số điện thoại", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
