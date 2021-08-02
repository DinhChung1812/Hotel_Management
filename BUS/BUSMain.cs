using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSMain
    {
        public DataTable loadRoomMain()
        {
            return (new DAOMain()).loadRoomMain();
        }
        public DataTable loadRoomCheckout()
        {
            return (new DAOMain()).loadRoomCheckout();
        }
        public DataTable loadRoomOccupied()
        {
            return (new DAOMain()).loadRoomOccupied();
        }
        public DataTable loadRoomOnQueue()
        {
            return (new DAOMain()).loadRoomOnQueue();
        }
        public DataTable get_phong1()
        {
            return (new DAOMain()).get_phong1();
        }
        public DataTable get_phong2()
        {
            return (new DAOMain()).get_phong2();
        }
        public DataTable get_phong3()
        {
            return (new DAOMain()).get_phong3();
        }
        public DataTable get_phong4()
        {
            return (new DAOMain()).get_phong4();
        }
        public DataTable get_phong5()
        {
            return (new DAOMain()).get_phong5();
        }
        public DataTable get_phong6()
        {
            return (new DAOMain()).get_phong6();
        }




    }
}
