using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSQLNV
    {
        public DataTable loadDSNV()
        {
            return (new DAOQLNV()).loadDSNV();
        }
        public bool Them(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            return (new DAOQLNV()).Them(code,name,dob,gioitinh,sdt,cmnd,email); 
                
                }
        public bool Sua(string code, string name, string dob, string gioitinh, string sdt, string cmnd, string email)
        {
            return (new DAOQLNV()).Sua(code, name, dob, gioitinh, sdt, cmnd, email);
        }
        public bool Xoa(string code)
        {
            return (new DAOQLNV()).Xoa(code);
        }
        public DataTable searchNV(string search)
        {
            return (new DAOQLNV()).searchNV(search); 
        }
    }
}
