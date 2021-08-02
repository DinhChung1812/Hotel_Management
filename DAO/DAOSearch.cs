using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOSearch
    {

        public DataTable searchByPrice(string fromPrice, string toPrice)
        {
            DataTable dt = new DataTable();
            string strSearchByPrice = "SELECT * FROM Room WHERE Price BETWEEN'" + fromPrice + "' and '" + toPrice + "'";
            dt = (new DataProvider()).executeQuery(strSearchByPrice);

            return dt;
        }

        public DataTable searchByTypeRoom(string TypeRoom)
        {
            DataTable dt = new DataTable();
            string strSearchByTypeRoom = "select * from Room where RoomType = '"+TypeRoom+"'";
            dt = (new DataProvider()).executeQuery(strSearchByTypeRoom);

            return dt;
        }
    }
}
