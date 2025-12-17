using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjectClasses
{
    public class Admin : User
    {
        public string Username = "admin";
        public string Password = "1234";
        public override bool Login(string username, string password)
        {
            if(Username == username && Password == password)
            {
                return true;
            }
            return false;
        }

        public override string DisplayInfo()
        {
            return $"Admin: {Username}";
        }

        public string ViewSystemReport(Hospital_System system)
        {
            return
                $"Total Patients: {system.Patients.Count}\n" +
                $"Total Doctors: {system.Doctors.Count}\n" +
                $"Total Appointments: {system.Appointments.Count}";
        }
    }

}
