using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class BUSChangePass
    {
        public bool changePass(string user, string pass, string repass)
        {
            return (new DAOChangePass()).changePass(user, pass, repass);
        }

    }
}
