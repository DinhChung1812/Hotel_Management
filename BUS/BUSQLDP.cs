using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
   public class BUSQLDP
    {
        public DataTable loadDatPhong()
        {
            return (new DAOQLDP()).loadDatPhong();
        }
        public bool ThemDatPhong(string MaDP, string ngayNhan, string ngayTra, string ten, string soLuong, string sdt, string tt)
        {
            return (new DAOQLDP()).ThemDatPhong(MaDP, ngayNhan, ngayTra, ten, soLuong, sdt, tt);
        }

        public bool SuaDatPhong(string MaDP, string ngayNhan, string ngayTra, string ten, string soLuong, string sdt, string tt)
        {
            return (new DAOQLDP()).SuaDatPhong(MaDP, ngayNhan, ngayTra, ten, soLuong, sdt, tt);
        }
        public bool XoaDatPhong(string MaDP)
        {
            return (new DAOQLDP()).XoaDatPhong(MaDP);
        }
        public bool ThemCTPhong(string MaDP, string MaP)
        {
            return (new DAOQLDP()).ThemCTPhong(MaDP, MaP);
        }
        public bool XoaCTPhong(string MaDP)
        {
            return (new DAOQLDP()).XoaCTPhong(MaDP);
        }
        public DataTable loadComboxPhong(string loaiPhong)
        {
            return (new DAOQLDP()).loadComboxPhong(loaiPhong);    
        }
        public DataTable loadComboBoxXoaPhong(string MaDP)
        {
            return (new DAOQLDP()).loadComboBoxXoaPhong(MaDP);    
        }
    }
}
