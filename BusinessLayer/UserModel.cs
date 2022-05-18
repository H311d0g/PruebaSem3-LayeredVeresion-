using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class UserModel
    {
        UserConsults userConsult = new UserConsults();
        public bool LoginUser(string rut, string clave)
        {
            return userConsult.Login(rut, clave);
        }
    }
}
