using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace BUS
{
    public class BUSRegister
    {
        public bool registerAccount(string name, string user, string pass, string address, string dob, string email, string phone)
        {
            return (new DAORegister().registerAccount(name, user, pass, address, dob, email, phone));
        }
    }
}
