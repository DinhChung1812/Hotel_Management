using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAORoom
    {
        public bool addRoom(string MaPhong, string TenPhong,string LoaiPhong, string Mota, string Songtoida,string trangthai)
        {
            string strAddRoom = " insert into Phong values('"+MaPhong+"','"+TenPhong+"','"+LoaiPhong+"',N'"+Mota+"','"+Songtoida+"',N'"+trangthai+"')";
            string check = "select * from Phong where MaPhong='" + MaPhong + "'";
            
            if (((new DataProvider()).executeQuery(check)).Rows.Count==0) {
                if ((new DataProvider()).executeNonQuery(strAddRoom))
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

        public bool UpdateRoom(string MaPhong, string TenPhong, string LoaiPhong, string Mota, string Songtoida, string trangthai)
        {
            string strUpdateRoom = "update Phong set TenPhong = '" + TenPhong + "',loaiphong ='" + LoaiPhong + "',Mota = '" + Mota+ "',songtoida = '" + Songtoida+"',trangthai='"+trangthai+"' where MaPhong = '" + MaPhong + "'";
            if ((new DataProvider()).executeNonQuery(strUpdateRoom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRoom(string MaPhong)
        {
            string strDeleteRoom = "Delete from Phong where MaPhong = '" + MaPhong + "' ";
            if ((new DataProvider()).executeNonQuery(strDeleteRoom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable loadRoom()
        {
            string sql = "select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable searchRoom(int n, string text)
        {
            string searchPhong = "";
            if (n == 0)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.MaPhong like '%"+text+"%'";
            }
            if (n == 1)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.TenPhong like '%"+text+"%'";
            }
            if (n == 2)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.loaiphong like '%"+text+"%'";
            }
            if (n == 3)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.songtoida like '%"+text+"%'";
            }
            if (n == 4)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.Mota like '%"+text+"%'";
            }
            if (n == 5)
            {
                searchPhong = "  select p.MaPhong,p.TenPhong,p.loaiphong,p.Mota,p.songtoida,p.trangthai,l.giaphong from Phong p join LPhong l on p.loaiphong=l.loaiphong where p.trangthai like '%"+text+"%'";
            }
            return (new DataProvider()).executeQuery(searchPhong);
        }
    }
}
