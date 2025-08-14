using System;
using Medicode;
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
    public partial class PatientDashboard : Form
    {
        private Patient currentPatient;
        private int currentPatientId;

        public PatientDashboard(Patient patient)
        {
            InitializeComponent();
            currentPatient = patient;
        }

        public PatientDashboard(int patientId)
        {
            InitializeComponent();
            currentPatientId = patientId;
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {currentPatient.FirstName} {currentPatient.LastName}";
            lblPrescription.Text = $"Prescriptions for {currentPatient.FirstName} {currentPatient.LastName}";

            using (var db = new MedicodeEntities())
            {
                var appointments = db.Appointments
                    .Where(a => a.PatientID == currentPatient.PatientID)
                    .Select(a => new
                    {
                        a.AppointmentID,
                        DoctorName = a.Doctor.FirstName + " " + a.Doctor.LastName,
                        a.ApptDate,
                        a.ApptTime,
                        a.Status
                    })
                    .ToList();

                dataGridViewAppointments.DataSource = appointments;
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
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                using (var db = new MedicodeEntities())
                {
                    var prescriptions = db.Prescriptions
                        .Where(p => p.AppointmentID == appointmentId)
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

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            
            int patientId = currentPatient.PatientID;

            var form = new AppointmentForm(patientId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                
                LoadAppointments();
            }
        }

        private void LoadAppointments()
        {
            using (var db = new MedicodeEntities())
            {
                var appointments = db.Appointments
                    .Where(a => a.PatientID == currentPatient.PatientID)
                    .Select(a => new
                    {
                        a.AppointmentID,
                        DoctorName = a.Doctor.FirstName + " " + a.Doctor.LastName,
                        a.ApptDate,
                        a.ApptTime,
                        a.Status
                    })
                    .ToList();

                dataGridViewAppointments.DataSource = appointments;
            }
            LoadPrescriptionsForSelectedAppointment(); 
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value);

                var result = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MedicodeEntities())
                    {
                        var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == appointmentId);
                        if (appointment != null)
                        {
                            
                            var prescriptions = db.Prescriptions.Where(p => p.AppointmentID == appointmentId).ToList();
                            db.Prescriptions.RemoveRange(prescriptions);

                            
                            var treatments = db.Treatments.Where(t => t.AppointmentID == appointmentId).ToList();

                            
                            foreach (var treatment in treatments)
                            {
                                var bills = db.Bills.Where(b => b.TreatmentID == treatment.TreatmentID).ToList();
                                db.Bills.RemoveRange(bills);
                            }

                            
                            db.Treatments.RemoveRange(treatments);

                            
                            db.Appointments.Remove(appointment);

                            db.SaveChanges();
                            MessageBox.Show("Appointment canceled!");
                        }
                    }
                    LoadAppointments(); 
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.");
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBills_Click(object sender, EventArgs e)
        {
            var billsForm = new BillsForm(currentPatient.PatientID); 
            billsForm.ShowDialog();
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
