using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOQLDP
    {
        public DataTable loadDatPhong()
        {
            string sql = "select * from DatPhong";
            return (new DataProvider()).executeQuery(sql);
        }
        public bool ThemDatPhong(string MaDP, string ngayNhan, string ngayTra, string ten, string soLuong, string sdt, string tt)
        {
            string sql = "insert into DatPhong values ('"+MaDP+"','"+ngayNhan+"','"+ngayTra+"','"+ten+"','"+soLuong+"','"+sdt+"','"+tt+"')";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SuaDatPhong(string MaDP, string ngayNhan, string ngayTra, string ten, string soLuong, string sdt, string tt)
        {
            string sql = "update DatPhong set NgayNhan='"+ngayNhan+"',NgayTra='"+ngayTra+"',TenKH='"+ten+"',SoLuong='"+soLuong+"',SDT='"+sdt+"',TtChung='"+tt+"' where MaDP='"+MaDP+"' ";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool XoaDatPhong(string MaDP)
        {
            string sql = "delete from DatPhong where MaDP='"+MaDP+"'";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ThemCTPhong(string MaDP, string MaP)
        {
            string sql = "insert into ChiTietDatPhong (MADP,MAP) values('"+MaDP+"','"+MaP+"')";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool XoaCTPhong(string MaDP)
        {
            string sql = "delete from ChiTietDatPhong where MADP='" + MaDP + "'";
            if ((new DataProvider()).executeNonQuery(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable loadComboxPhong(string loaiPhong)
        {
            string sql = "select p.TenPhong from Phong p join LoaiPhong l on p.MaLP=l.MaLP where l.MaLP='"+loaiPhong+"' and p.TinhTrangP='check-out'";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable loadComboBoxXoaPhong(string MaDP)
        {
            string sql = "select MaPhong from ChiTietDatPhong where MaDP='"+MaDP+"'";
            return (new DataProvider()).executeQuery(sql);
        }
    }
}
