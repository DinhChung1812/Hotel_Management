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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        static string user;
        static string pass;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;
            Frm_Main m = new Frm_Main();
            try
            {
                if ((new BUSUser()).checkUser(txtUser.Text, txtPass.Text))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thong bao");
                    if (new BUSUser().checkQuyen(txtUser.Text,txtPass.Text)=="3")
                    {
                        
                        this.Hide();
                         m = new Frm_Main();
                        m.isNV();
                        m.Show();
                    }
                    else
                    {
                        Frm_Main f = new Frm_Main();
                        f.Show();
                        this.Hide();
                        
                        
                       
                        
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại ", "Thong bao");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login error: " + ex.Message);
            }
        }

        private void choRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                lbIconUser.ForeColor = Color.Blue;
            }
            else
            {
                lbIconUser.ForeColor = Color.Red;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                lbIconPass.ForeColor = Color.Blue;
            }
            else
            {
                lbIconPass.ForeColor = Color.Red;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng kí không???", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
               // Register register = new Register();
                //register.Show();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
