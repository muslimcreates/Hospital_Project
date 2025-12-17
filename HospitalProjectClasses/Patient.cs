using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjectClasses
{
    public class Patient : User
    {
        public string Condition { get; set; }

        public override bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public override string DisplayInfo()
        {
            return $"Patient: {Username}\nCondition: {Condition}";
        }
    }

}
