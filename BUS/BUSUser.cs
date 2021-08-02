using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUSUser
    {
        public bool checkUser(string account, string pass)
        {
            //cung k xu li database ow day
            //Ma goi sang tang DAO
            return (new DAOUser()).checkUser(account, pass);
        }
        public string checkQuyen(string user, string pass)
        {
            return (new DAOUser()).checkQuyen(user, pass);
        }


    }
}
