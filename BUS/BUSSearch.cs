using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSSearch
    {
        public DataTable searchByPrice(string fromPrice, string toPrice)
        {
            DataTable dt = new DataTable();

            return dt = (new DAOSearch()).searchByPrice(fromPrice, toPrice);
        }

        public DataTable searchByTypeRoom(string TypeRoom)
        {
            DataTable dt = new DataTable();

            return dt = (new DAOSearch()).searchByTypeRoom(TypeRoom);
        }


    }
}
