using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicode;
using System.Windows.Forms.DataVisualization.Charting; 

namespace MedicodeForm
{
    public partial class AdminDashboard : Form
    {
        private Admin currentAdmin;
        public AdminDashboard(Admin admin)
        {
            InitializeComponent();
            currentAdmin = admin;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();
            LoadAppointments();
            LoadTreatments();
            FillAppointmentsChart();
        }

        private void LoadDoctors()
        {
            using (var db = new MedicodeEntities())
            {
                var doctors = db.Doctors.Select(d => new
                {
                    d.DoctorID,
                    d.FirstName,
                    d.LastName,
                    d.Specialization 
                }).ToList();
                dataGridViewDoctors.DataSource = doctors;
            }
        }
        private void LoadPatients()
        {
            using (var db = new MedicodeEntities())
            {
                var patients = db.Patients.Select(p => new
                {
                    p.PatientID,
                    p.FirstName,
                    p.LastName,
                    p.DateOfBirth,
                    p.Gender
                }).ToList();
                dataGridViewPatients.DataSource = patients;
            }
        }
        private void LoadAppointments()
        {
            using (var db = new MedicodeEntities())
            {
                var appointments = db.Appointments.Select(a => new
                {
                    a.AppointmentID,
                    Doctor = a.Doctor.FirstName + " " + a.Doctor.LastName,
                    Patient = a.Patient.FirstName + " " + a.Patient.LastName,
                    a.ApptDate,
                    a.ApptTime,
                    a.Status
                }).ToList();
                dataGridViewAppointments.DataSource = appointments;
            }
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm form = new DoctorForm(); 
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDoctors(); 
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dataGridViewDoctors.SelectedRows[0].Cells["DoctorID"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        var doctor = db.Doctors.FirstOrDefault(d => d.DoctorID == doctorId);
                        if (doctor != null)
                        {
                            db.Doctors.Remove(doctor);
                            db.SaveChanges();
                            MessageBox.Show("Doctor deleted!");
                        }
                    }
                    LoadDoctors(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
        }


        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count > 0)
            {
                int doctorId = Convert.ToInt32(dataGridViewDoctors.SelectedRows[0].Cells["DoctorID"].Value);
                using (var db = new MedicodeEntities())
                {
                    var doctor = db.Doctors.FirstOrDefault(d => d.DoctorID == doctorId);
                    if (doctor != null)
                    {
                        DoctorForm form = new DoctorForm(doctor); 
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            
                            LoadDoctors();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to edit.");
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientForm form = new PatientForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPatients(); 
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["PatientID"].Value);
                using (var db = new MedicodeEntities())
                {
                    var patient = db.Patients.FirstOrDefault(p => p.PatientID == patientId);
                    if (patient != null)
                    {
                        PatientForm form = new PatientForm(patient);
                        if (form.ShowDialog() == DialogResult.OK)
                            LoadPatients();
                    }
                }
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["PatientID"].Value);
                var result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        var patient = db.Patients.FirstOrDefault(p => p.PatientID == patientId);
                        if (patient != null)
                        {
                            db.Patients.Remove(patient);
                            db.SaveChanges();
                            MessageBox.Show("Patient deleted!");
                            LoadPatients();
                        }
                    }
                }
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAppointments();
            }
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                using (var db = new MedicodeEntities())
                {
                    var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == appointmentId);
                    if (appointment != null)
                    {
                        AppointmentForm form = new AppointmentForm(appointment);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadAppointments();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.");
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this appointment and all related data (treatments & bills)?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        
                        var treatments = db.Treatments.Where(t => t.AppointmentID == appointmentId).ToList();

                        foreach (var treatment in treatments)
                        {
                            
                            var bills = db.Bills.Where(b => b.TreatmentID == treatment.TreatmentID).ToList();
                            foreach (var bill in bills)
                            {
                                db.Bills.Remove(bill);
                            }

                            
                            var prescriptions = db.Prescriptions.Where(p => p.AppointmentID == appointmentId).ToList();
                            foreach (var pres in prescriptions)
                            {
                                db.Prescriptions.Remove(pres);
                            }

                            
                            db.Treatments.Remove(treatment);
                        }

                        
                        var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == appointmentId);
                        if (appointment != null)
                        {
                            db.Appointments.Remove(appointment);
                        }

                        db.SaveChanges();
                        MessageBox.Show("Appointment and related data deleted!");
                    }
                    LoadAppointments(); 
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }



        private void dataGridViewBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            TreatmentForm form = new TreatmentForm(); 
            if (form.ShowDialog() == DialogResult.OK)
                LoadTreatments();
        }

        private void LoadTreatments()
        {
            using (var db = new MedicodeEntities())
            {
                var treatments = (from t in db.Treatments
                                  join a in db.Appointments on t.AppointmentID equals a.AppointmentID
                                  join d in db.Doctors on a.DoctorID equals d.DoctorID
                                  join p in db.Patients on a.PatientID equals p.PatientID
                                  select new
                                  {
                                      t.TreatmentID,
                                      t.AppointmentID,
                                      DoctorName = d.FirstName + " " + d.LastName,
                                      PatientName = p.FirstName + " " + p.LastName,
                                      t.TreatmentType,
                                      t.Cost,
                                      t.TreatmentDate
                                  }).ToList();

                dataGridViewTreatments.DataSource = treatments;
            }
        }


        private void btnEditTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatments.SelectedRows.Count > 0)
            {
                int treatmentId = Convert.ToInt32(dataGridViewTreatments.SelectedRows[0].Cells["TreatmentID"].Value);
                using (var db = new MedicodeEntities())
                {
                    var treatment = db.Treatments.FirstOrDefault(t => t.TreatmentID == treatmentId);
                    if (treatment != null)
                    {
                        TreatmentForm form = new TreatmentForm(treatment); 
                        if (form.ShowDialog() == DialogResult.OK)
                            LoadTreatments();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a treatment to edit.");
            }
        }

        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatments.SelectedRows.Count > 0)
            {
                int treatmentId = Convert.ToInt32(dataGridViewTreatments.SelectedRows[0].Cells["TreatmentID"].Value);
                var result = MessageBox.Show("Are you sure you want to delete this treatment (and its bill)?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        // Önce bill sil (varsa)
                        var bill = db.Bills.FirstOrDefault(b => b.TreatmentID == treatmentId);
                        if (bill != null)
                            db.Bills.Remove(bill);

                        var treatment = db.Treatments.FirstOrDefault(t => t.TreatmentID == treatmentId);
                        if (treatment != null)
                            db.Treatments.Remove(treatment);

                        db.SaveChanges();
                        MessageBox.Show("Treatment deleted!");
                    }
                    LoadTreatments();
                }
            }
            else
            {
                MessageBox.Show("Please select a treatment to delete.");
            }
        }

        private void dataGridViewTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillAppointmentsChart()
        {
            using (var db = new MedicodeEntities())
            {
                
                var data = db.Appointments
                    .GroupBy(a => a.Doctor.FirstName + " " + a.Doctor.LastName)
                    .Select(g => new
                    {
                        DoctorName = g.Key,
                        AppointmentCount = g.Count()
                    })
                    .OrderByDescending(x => x.AppointmentCount)
                    .ToList();

                chartAppointments.Series.Clear();
                chartAppointments.Titles.Clear();
                chartAppointments.Titles.Add("Appointments by Doctor");

                Series series = new Series("Appointments");
                series.ChartType = SeriesChartType.Column; 

                foreach (var item in data)
                {
                    series.Points.AddXY(item.DoctorName, item.AppointmentCount);
                }

                chartAppointments.Series.Add(series);
                chartAppointments.ChartAreas[0].AxisX.Title = "Doctor";
                chartAppointments.ChartAreas[0].AxisY.Title = "Appointment Count";
            }
        }

        private void dataGridViewTreatments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
