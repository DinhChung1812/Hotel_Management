using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSManageAccount
    {
        DAO.DAOManageAccountKH daoKH;

        public bool Them(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            return (new DAOManageAccountKH()).Them(code,name,dob,gioitinh,sdt,cmnd,email);
        }
        public bool Sua(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            return (new DAOManageAccountKH()).Sua(code, name,dob,gioitinh,sdt,cmnd,email);
        }
        public bool Xoa(string code)
        {
           return (new DAOManageAccountKH()).Xoa(code);
        }
        public DataTable loadKhach()
        {
            return (new DAOManageAccountKH()).loadKhach();
        }
        public DataTable serachKH(string name)
        {
            return (new DAOManageAccountKH()).serachKH(name);
        }
    }
}
