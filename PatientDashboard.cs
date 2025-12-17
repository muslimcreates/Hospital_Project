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
        public partial class PatientDashboard : Form
        {
            private Hospital_System system;
            private HospitalProjectClasses.Patient patient;

            public PatientDashboard(HospitalProjectClasses.Patient patient)
            {
                InitializeComponent();
                this.patient = patient;
                system = new Hospital_System();
        }

            private void PatientDashboard_Load(object sender, EventArgs e)
            {
                // Load doctors into ComboBox
                comboBoxDoctors.DataSource = system.Doctors;
                comboBoxDoctors.DisplayMember = "Username";
            }

            private void btnViewInfo_Click(object sender, EventArgs e)
            {
                MessageBox.Show(patient.DisplayInfo());
            }

            private void btnMakeAppointment_Click(object sender, EventArgs e)
            {
                Doctor selectedDoctor = comboBoxDoctors.SelectedItem as Doctor;

                if (selectedDoctor == null)
                {
                    MessageBox.Show("Please select a doctor.");
                    return;
                }

                Appointment appointment = new Appointment
                {
                    Patient = patient,
                    Doctor = selectedDoctor,
                    Time = dateTimePicker1.Value
                };

                system.AddAppointment(appointment);
                MessageBox.Show("Appointment successfully created.");
            }
        }
    }


