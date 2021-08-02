using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSLoadGrid
    {
        public DataTable loadGrid()
        {
            DataTable dt = new DataTable();
            dt = (new DAOLoadGrid()).loadGrid();
            return dt;
        }

        public DataTable loadGridInfoAcc()
        {
            DataTable dt = new DataTable();
            dt = (new DAOLoadGrid()).loadGridInfoAcc();
            return dt;
        }
    }
}
