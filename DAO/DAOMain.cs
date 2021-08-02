using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOMain
    {
        public DataTable loadRoomMain()
        {
            string sql = "select * from Phong";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable loadRoomCheckout()
        {
            string sql = "select * from Phong where TinhTrangP='check-out'";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable loadRoomOccupied()
        {
            string sql = "select * from Phong where TinhTrangP='occupied'";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable loadRoomOnQueue()
        {
            string sql = "select * from Phong where TinhTrangP='on-queue'";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong1()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '1%' ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong2()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '2%' ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong3()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '3%' ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong4()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '4%' ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong5()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '5%' ";
            return (new DataProvider()).executeQuery(sql);
        }
        public DataTable get_phong6()
        {
            string sql = "select MaPhong, TenPhong, trangthai from Phong where TenPhong like '6%' ";
            return (new DataProvider()).executeQuery(sql);
        }

    }
}
