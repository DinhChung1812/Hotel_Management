using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSRom
    {
        public bool addRoom(string MaPhong, string TenPhong, string LoaiPhong, string Mota, string Songtoida, string trangthai)
        {
            return (new DAORoom()).addRoom(MaPhong,TenPhong,LoaiPhong,Mota,Songtoida,trangthai);
        }

        public bool UpdateRoom(string MaPhong, string TenPhong, string LoaiPhong, string Mota, string Songtoida, string trangthai)
        {
            return (new DAORoom()).UpdateRoom(MaPhong, TenPhong, LoaiPhong, Mota, Songtoida, trangthai);
        }

        public bool DeleteRoom(string Maphong)
        {
            return (new DAORoom()).DeleteRoom(Maphong);
        }
        public DataTable loadRoom()
        {
            return (new DAORoom()).loadRoom();
        }

        public DataTable searchRoom(int n,string text)
        {
            return (new DAORoom()).searchRoom(n, text);
        }
    }
}
