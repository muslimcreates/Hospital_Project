using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjectClasses
{
    public class Doctor : User
    {
        public string Specialty { get; set; }

        public override bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public override string DisplayInfo()
        {
            return $"Doctor: {Username}\nSpecialty: {Specialty}";
        }
    }

}
