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
    public partial class FrmDoiPass : Form
    {
        public FrmDoiPass()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if ((new BUSChangePass().changePass(txtUser.Text,txtPass.Text,txtRePass.Text)))
                {
                    MessageBox.Show("thanh cong", "Thong bao");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("fail ", "Thong bao");
                }
            }
            catch (Exception)
            {

                throw;
            }
            

                 
        }
    }
}
