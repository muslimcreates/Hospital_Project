using HospitalProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
        public partial class DoctorDashboard : Form
        {
            private Hospital_System system;
            private HospitalProjectClasses.Doctor doctor;

            public DoctorDashboard(HospitalProjectClasses.Doctor doctor)
            {
                InitializeComponent();
                this.doctor = doctor;
                system = new Hospital_System();
        }

            private void btnViewInfo_Click(object sender, EventArgs e)
            {
                MessageBox.Show(doctor.DisplayInfo());
            }

            private void btnViewAppointments_Click(object sender, EventArgs e)
            {
                listBoxAppointments.Items.Clear();

                var myAppointments = system.Appointments
                                           .Where(a => a.Doctor.Username == doctor.Username)
                                           .ToList();

                if (myAppointments.Count == 0)
                {
                    listBoxAppointments.Items.Add("No appointments found.");
                    return;
                }

                foreach (var app in myAppointments)
                {
                    listBoxAppointments.Items.Add(
                        $"{app.Time} - Patient: {app.Patient.Username}"
                    );
                }
            }
        }
    }


