using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAO
{
    public class DAORegister
    {
        public bool registerAccount(string name, string user, string pass, string address, string dob, string email, string phone)
        {
            string str = "insert into Account(Name, UserName, [Password], [Address], DOB, Email, Phone) values ('" + name+"','"+user+"','"+pass+"','"+address+"','"+dob+"','"+email+"','"+phone+"')";
            if ((new DataProvider()).executeNonQuery(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
