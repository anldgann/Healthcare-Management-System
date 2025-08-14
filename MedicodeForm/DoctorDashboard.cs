using Medicode;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MedicodeForm
{
    public partial class DoctorDashboard : Form
    {
        private Doctor currentDoctor;

        public DoctorDashboard(Doctor doctor)
        {
            InitializeComponent();
            currentDoctor = doctor;
            this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.dataGridViewAppointments_SelectionChanged);
            btnAddAppointment.Click += btnAddAppointment_Click;
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, Dr. {currentDoctor.FirstName} {currentDoctor.LastName}";

            using (var db = new MedicodeEntities())
            {
                var appointments = db.Appointments
                    .Where(a => a.DoctorID == currentDoctor.DoctorID)
                    .Select(a => new
                    {
                        a.AppointmentID,
                        PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                        a.ApptDate,
                        a.ApptTime,
                        a.Status,
                        a.PatientID
                    })
                    .ToList();

                dataGridViewAppointments.DataSource = appointments;

                if (dataGridViewAppointments.Columns["PatientID"] != null)
                    dataGridViewAppointments.Columns["PatientID"].Visible = false;


                DateTime today = DateTime.Today;
                DateTime weekLater = today.AddDays(7);

                var upcomingCount = db.Appointments
                    .Where(a => a.DoctorID == currentDoctor.DoctorID
                                && a.ApptDate >= today
                                && a.ApptDate <= weekLater)
                    .Count();

                lblWeeklyAppointments.Text = $"Upcoming Appointments (This Week): {upcomingCount}";
            }
        }



        private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
        {
            LoadPrescriptionsForSelectedAppointment();
        }

        
        private void LoadPrescriptionsForSelectedAppointment()
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int selectedAppointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                using (var db = new MedicodeEntities())
                {
                    var prescriptions = db.Prescriptions
                        .Where(p => p.AppointmentID == selectedAppointmentId)
                        .Select(p => new
                        {
                            p.PrescriptionID,
                            p.Medication,
                            p.Dosage,
                            p.Notes,
                            p.DateIssued
                        })
                        .ToList();

                    dataGridViewPrescriptions.DataSource = prescriptions;
                }
            }
            else
            {
                dataGridViewPrescriptions.DataSource = null;
            }
        }


        // Randevu sil
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this appointment? Prescriptions will also be deleted.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        // Önce bu appointment'a bağlı prescription'ları sil
                        var prescriptions = db.Prescriptions.Where(p => p.AppointmentID == appointmentId).ToList();
                        foreach (var pres in prescriptions)
                        {
                            db.Prescriptions.Remove(pres);
                        }

                        // Sonra appointment'ı sil
                        var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == appointmentId);
                        if (appointment != null)
                        {
                            db.Appointments.Remove(appointment);
                            db.SaveChanges();
                            MessageBox.Show("Appointment and its prescriptions deleted!");
                        }
                    }
                    DoctorDashboard_Load(null, null); 
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        
        private void btnPrescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                int doctorId = currentDoctor.DoctorID;
                int patientId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["PatientID"].Value);

                var form = new PrescriptionForm(appointmentId, doctorId, patientId);
                form.ShowDialog();
                
                LoadPrescriptionsForSelectedAppointment();
            }
            else
            {
                MessageBox.Show("Please select an appointment to write a prescription.");
            }
        }

        
        private void dataGridViewAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.Rows[e.RowIndex].Cells["AppointmentID"].Value);

                using (var db = new MedicodeEntities())
                {
                    var appointment = db.Appointments
                        .Where(a => a.AppointmentID == appointmentId)
                        .Select(a => new
                        {
                            a.AppointmentID,
                            PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                            a.ApptDate,
                            a.ApptTime,
                            a.Status
                        })
                        .FirstOrDefault();

                    if (appointment != null)
                    {
                        string message = $"Appointment ID: {appointment.AppointmentID}\n" +
                                         $"Patient Name: {appointment.PatientName}\n" +
                                         $"Date: {appointment.ApptDate:dd.MM.yyyy}\n" +
                                         $"Time: {appointment.ApptTime}\n" +
                                         $"Status: {appointment.Status}";

                        MessageBox.Show(message, "Appointment Details");
                    }
                }
            }
        }

        
        private void dataGridViewPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrescriptions.SelectedRows.Count > 0)
            {
                int prescriptionId = Convert.ToInt32(dataGridViewPrescriptions.SelectedRows[0].Cells["PrescriptionID"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this prescription?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        var prescription = db.Prescriptions.FirstOrDefault(p => p.PrescriptionID == prescriptionId);
                        if (prescription != null)
                        {
                            db.Prescriptions.Remove(prescription);
                            db.SaveChanges();
                            MessageBox.Show("Prescription deleted!");
                        }
                    }
                        
                    LoadPrescriptionsForSelectedAppointment();
                }
            }
            else
            {
                MessageBox.Show("Please select a prescription to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                DoctorDashboard_Load(null, null);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

    }
}
