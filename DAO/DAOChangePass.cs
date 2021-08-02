using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOChangePass
    {
        public bool changePass(string user, string pass, string repass)
        {
            string check = "select * from DangNhap where Taikhoan='"+user+"' and Matkhau='"+pass+"' ";
            if (((new DataProvider()).executeQuery(check)).Rows.Count>0)
            {
                string sql = "update DangNhap set Matkhau ='"+repass+"' where Taikhoan='"+user+"'";
                if ((new DataProvider()).executeNonQuery(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
