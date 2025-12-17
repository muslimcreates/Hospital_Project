using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProjectClasses
{
    public class Hospital_System
    {
        public List<Patient> Patients { get; private set; } = new();
        public List<Doctor> Doctors { get; private set; } = new();
        public List<Appointment> Appointments { get; private set; } = new();

        public void AddPatient(Patient p) => Patients.Add(p);
        public void AddDoctor(Doctor d) => Doctors.Add(d);
        public void AddAppointment(Appointment a) => Appointments.Add(a);
    }

}
