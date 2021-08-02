using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAOLoadGrid
    {
        public DataTable loadGrid()
        {
            DataTable dt = new DataTable();
            string strSelect = "select * from Room";
            dt = (new DataProvider()).executeQuery(strSelect);
            return dt;
        }

        public DataTable loadGridInfoAcc()
        {
            DataTable dt = new DataTable();
            string strSelect = "select i.Name,i.Dob,i.Address,i.NumPhone,i.CardID,i.AccountID from InfoAccount i join Account a on i.AccountID=a.AccountID where a.Type=3";
            dt = (new DataProvider()).executeQuery(strSelect);
            return dt;
        }
    }
}
