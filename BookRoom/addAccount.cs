using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRoom
{
    public partial class addAccount : Form
    {
        public addAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxMaxacnhan.Text.Equals("123456"))
            {
                String sql = "Insert into DangNhap values('" + tbxTentaikhoan.Text + "','" + tbxMatkhau.Text + "'" +
                ",N'" + tbxName.Text + "','" + tbxEmail.Text + "','3','1')";
                if (new DataProvider().executeNonQuery(sql))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng , nhập lại!");
                tbxMaxacnhan.Text = "";
            }
            
        }

        private void addAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
