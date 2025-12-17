using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjectClasses
{
    public abstract class User : IAuthenticable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual string DisplayInfo()
        {
           return "User Information";
        }

        public abstract bool Login(string username, string password);
    }

}
