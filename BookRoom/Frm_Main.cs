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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
       
        

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
             showTongTang();

        }




        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiPass r = new FrmDoiPass();
            r.Show();
        }

        private void men_qlnv_Click(object sender, EventArgs e)
        {
            FrmQLNV qlnv = new FrmQLNV();
            qlnv.Show();
        }

        private void men_qldp_Click(object sender, EventArgs e)
        {
            BookRoom.DatPhong d = new BookRoom.DatPhong();
            d.Show();

                }

        private void men_qlp_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Show();
            this.Close();
        }

        private void men_qlkh_Click(object sender, EventArgs e)
        {
            FrmQLKhach f = new FrmQLKhach();
            f.Show();
        }

        private void men_qlhd_Click(object sender, EventArgs e)
        {
            BookRoom.ThuePhong t = new BookRoom.ThuePhong();
            t.Show();
              }
        public void ShowTang1()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong1();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang1 = new ListViewGroup("Tầng 1", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang1);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang1);
                if (status.Text=="Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if(status.Text=="Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void ShowTang2()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong2();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang2 = new ListViewGroup("Tầng 2", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang2);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang2);
                if (status.Text == "Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void ShowTang3()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong3();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang3 = new ListViewGroup("Tầng 3", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang3);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang3);
                if (status.Text == "Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void ShowTang4()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong4();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang4 = new ListViewGroup("Tầng 4", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang4);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang4);
                if (status.Text == "Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void ShowTang5()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong5();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang5 = new ListViewGroup("Tầng 5", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang5);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang5);
                if (status.Text == "Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void ShowTang6()
        {
            DataTable dt = new DataTable();
            dt = (new BUSMain()).get_phong6();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang6 = new ListViewGroup("Tầng 6", HorizontalAlignment.Left);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item = new ListViewItem(dt.Rows[i][1].ToString(), tang6);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt.Rows[i][2].ToString());
                listView1.Groups.Add(tang6);
                if (status.Text == "Trong")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Co Khach")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
            }
        }
        public void showTongTang()
        {
            ShowTang1();
            ShowTang2();
            ShowTang3();
            ShowTang4();
            ShowTang5();
            ShowTang6();
        }

        private void men_ht_Click(object sender, EventArgs e)
        {

        }
        public void isNV()
        {
            men_qlnv.Visible = false;
            men_qltk.Visible = false;
            this.Show();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRoom.PhuPhi p = new BookRoom.PhuPhi();
            p.Show();
        }

        private void quảnLýTrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRoom.TraPhong t = new BookRoom.TraPhong();
            t.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRoom.addAccount a = new BookRoom.addAccount();
            a.Show();
        }

        private void chỉnhSửaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRoom.editAccount edit = new BookRoom.editAccount();
            edit.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Home h = new Home();
            //h.Show();
        }
    }
}
