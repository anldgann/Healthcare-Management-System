using Medicode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicodeForm
{
    public partial class Medicode : Form
    {
        public Medicode()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Burada ID ve şifre ile giriş yapıyorsun
            string id = txtUsername.Text.Trim();  // txtUsername textbox'ı artık User ID olarak kullanılacak
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new MedicodeEntities())
            {
                // Doctor girişi için kontrol
                if (role == "Doctor")
                {
                    if (int.TryParse(id, out int doctorId))
                    {
                        // DoctorID ve LastName ile giriş (örnek amaçlı)
                        var doctor = db.Doctors.FirstOrDefault(d => d.DoctorID == doctorId && d.LastName == password);
                        if (doctor != null)
                        {
                            this.Hide();
                            DoctorDashboard dashboard = new DoctorDashboard(doctor);
                            dashboard.ShowDialog();
                            this.Show();
                            return;
                        }
                    }
                }
                // Patient girişi için kontrol
                else if (role == "Patient")
                {
                    if (int.TryParse(id, out int patientId))
                    {
                        // PatientID ve PasswordHash ile giriş (örnek amaçlı)
                        var patient = db.Patients.FirstOrDefault(p => p.PatientID == patientId && p.PasswordHash == password);
                        if (patient != null)
                        {
                            this.Hide();
                            PatientDashboard dashboard = new PatientDashboard(patient);
                            dashboard.ShowDialog();
                            this.Show();
                            return;
                        }
                    }
                }
                // Admin girişi için kontrol
                else if (role == "Admin")
                {
                    if (int.TryParse(id, out int adminId))
                    {
                        // Admin için DoctorID, LastName ve Specialization == "Admin" ile giriş
                        var admin = db.Admins.FirstOrDefault(a => a.AdminID == adminId && a.Password == password);
                        if (admin != null)
                        {
                            this.Hide();
                            AdminDashboard dashboard = new AdminDashboard(admin);
                            dashboard.ShowDialog();
                            this.Show();
                            return;
                        }
                    }
                }
            }

            // Giriş başarısız ise İngilizce mesaj
            MessageBox.Show("Invalid user ID, password or role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
