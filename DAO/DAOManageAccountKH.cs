using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
   public class DAOManageAccountKH
    {
     
     
        public bool Them( string code, string name, string dob,string gioitinh, string sdt,string cmnd, string email)
        {
            string strInsert = "insert into Khachhang values('"+code+"',N'"+name+"','"+dob+"',N'"+gioitinh+"','"+sdt+"','"+cmnd+"','"+email+"')";
            string check = "select * from Khachhang where MaKh='" + code + "' ";
            string checkCMND = "select * from Khachhang where Cmnd='" + cmnd + "'";
            if (((new DataProvider()).executeQuery(check)).Rows.Count == 0&&(new DataProvider()).executeQuery(checkCMND).Rows.Count==0)
            {


                if ((new DataProvider()).executeNonQuery(strInsert))
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
        public bool Sua(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            string strUpdate = "update Khachhang set Tenkh=N'"+name+"',Ngaysinh='"+dob+"',gioitinh=N'"+gioitinh+"',sdt='"+sdt+"',Cmnd='"+cmnd+"',Email='"+email+"' where MaKh='"+code+"'";
            if ((new DataProvider()).executeNonQuery(strUpdate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public bool Xoa(string code)
            {
                string strDelete = "delete from Khachhang where MaKh='"+code+"' ";

                if ((new DataProvider()).executeNonQuery(strDelete))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public DataTable loadKhach()
        {
            string sql = "select * from Khachhang";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable serachKH(string name)
        {
            string sql = "select * from Khachhang where TenKh like N'%"+name+"%' ";
            return (new DataProvider()).executeQuery(sql);
        } 





    }
}
