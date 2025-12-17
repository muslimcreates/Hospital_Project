using System.Numerics;

namespace Hospital_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string role = comborole.SelectedItem.ToString();
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (role == "Admin")
            {
                var admin = new HospitalProjectClasses.Admin();
                if (admin.Login(user, pass) == true)
                {
                    new AdminDashboard(admin).Show();
                    this.Hide();
                }
            }
            else if (role == "Doctor")
            {
                var doctor = new HospitalProjectClasses.Doctor { Username = "doc1", Password = "1111", Specialty = "Cardiology" };
                if (doctor.Login(user, pass))
                {
                    new DoctorDashboard(doctor).Show();
                }
            }
            else if (role == "Patient")
            {
                var patient = new HospitalProjectClasses.Patient { Username = "pat1", Password = "2222", Condition = "Flu" };
                if (patient.Login(user, pass))
                {
                    new PatientDashboard(patient).Show();
                }
            }
        }
    }
}
