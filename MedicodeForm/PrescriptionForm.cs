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
    public partial class PrescriptionForm : Form
    {
        private int appointmentId;
        private int doctorId;
        private int patientId;

        public PrescriptionForm(int appointmentId, int doctorId, int patientId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            this.doctorId = doctorId;
            this.patientId = patientId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string medication = txtMedication.Text.Trim();
            string dosage = txtDosage.Text.Trim();
            string notes = txtNotes.Text.Trim();
            DateTime dateIssued = dtpDateIssued.Value;

            // Basit doğrulama
            if (string.IsNullOrWhiteSpace(medication))
            {
                MessageBox.Show("Medication name cannot be empty.");
                return;
            }

            using (var db = new MedicodeEntities())
            {
                var prescription = new Prescription
                {
                    
                    DoctorID = doctorId,
                    PatientID = patientId,
                    DateIssued = dateIssued,
                    Medication = medication,
                    Dosage = dosage,
                    Notes = notes,
                    AppointmentID = appointmentId
                };
                db.Prescriptions.Add(prescription);
                db.SaveChanges();
                MessageBox.Show("Prescription saved successfully!");
                this.Close();
            }
        }

        private void txtMedication_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
