using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOUser
    {
        public bool checkUser(string user, string pass)
        {
            string sql = "select * from DangNhap where Taikhoan='" + user + "'and Matkhau='" + pass + "'";
            if ((new DataProvider()).executeQuery(sql).Rows.Count!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string checkQuyen(string user, string pass)
        {
            string sql = "select phanquyen from DangNhap where Taikhoan='"+user+"' and Matkhau='"+pass+"'";
            DataTable dt = (new DataProvider()).executeQuery(sql);
            return dt.Rows[0][0].ToString().Trim();
        }
    }
}
