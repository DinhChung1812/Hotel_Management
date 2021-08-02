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
    public partial class editAccount : Form
    {
        public editAccount()
        {
            InitializeComponent();
            LoadToDatagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editAccount_Load(object sender, EventArgs e)
        {
            String sql = "Select * from DangNhap";
            DataTable dt = new DataProvider().executeQuery(sql);
            dataGridView1.DataSource = dt;
        }

        public void LoadToDatagrid()
        {
            String sql = "select * from DangNhap";
            DataTable dt = new DataProvider().executeQuery(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String sql = "UPDATE [dbo].[DangNhap] "
                  + " SET "
                  + " [Matkhau] = '" + dataGridView1.Rows[i].Cells[1].Value + "'"
                  + " ,[FullName] = '" + dataGridView1.Rows[i].Cells[2].Value + "'"
                  + " ,[Email] = '" + dataGridView1.Rows[i].Cells[3].Value + "'"
                  + " ,[phanquyen] = '" + dataGridView1.Rows[i].Cells[4].Value + "'"
                  + " ,[trangthai] = '" + dataGridView1.Rows[i].Cells[5].Value + "' "
                  + " WHERE [Taikhoan] = '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                new DataProvider().executeQuery(sql);

            }
            LoadToDatagrid();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String sql = "select * from DangNhap Where Taikhoan like N'%"+tbxTimKiem.Text+"%'";
            DataTable dt = new DataProvider().executeQuery(sql);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count==0)
            {
                LoadToDatagrid();
            }
        }
    }
}
