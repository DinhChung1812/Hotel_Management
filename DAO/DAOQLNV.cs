using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOQLNV
    {
        public DataTable loadDSNV()
        {
            string sql = " select * from Nhanvien";
            return (new DataProvider()).executeQuery(sql);
        }
        public bool Them(string code, string name, string dob, string gioitinh,string sdt, string cmnd, string email)
        {   
            
            string sql = "insert into Nhanvien values('"+code+"',N'"+name+"','"+dob+"',N'"+gioitinh+"','"+sdt+"','"+cmnd+"','"+email+"')";
            string check = "select * from Nhanvien where Manv='" + code + "' ";
            string checkCMND = "select * from Nhanvien where Cmnd='" + cmnd + "'";
            if (((new DataProvider()).executeQuery(check)).Rows.Count==0 &&(new DataProvider()).executeQuery(checkCMND).Rows.Count==0) {
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
        public bool Sua(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            string sql = "update Nhanvien set Tennv=N'"+name+"',Ngaysinh='"+dob+"',gioitinh=N'"+gioitinh+"',sdt='"+sdt+"',Cmnd='"+cmnd+"',Email='"+email+"' where Manv='"+code+"'"; 
                if ((new DataProvider()).executeNonQuery(sql))
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
            string sql = "delete from Nhanvien where Manv='"+code+"'";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable searchNV(string search)
        {
            string sql = "select * from Nhanvien where Tennv like N'%" + search + "%'";
            return (new DataProvider()).executeQuery(sql);
        }
    }
}
