using Medicode;
using System;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace MedicodeForm
{
    public partial class AppointmentForm : Form
    {
        private Appointment editingAppointment = null; // Düzenleme için
        private int? currentPatientId = null;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(int patientId)
        {
            InitializeComponent();
            currentPatientId = patientId;
        }

        public AppointmentForm(Appointment appointment)
        {
            InitializeComponent();
            editingAppointment = appointment;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            using (var db = new MedicodeEntities())
            {
                // Tüm hastalar
                comboBoxPatient.DataSource = db.Patients
                    .Select(p => new { p.PatientID, FullName = p.FirstName + " " + p.LastName })
                    .ToList();
                comboBoxPatient.DisplayMember = "FullName";
                comboBoxPatient.ValueMember = "PatientID";
                comboBoxPatient.Enabled = true;

                // Tüm doktorlar
                comboBoxDoctor.DataSource = db.Doctors
                    .Select(d => new { d.DoctorID, FullName = d.FirstName + " " + d.LastName })
                    .ToList();
                comboBoxDoctor.DisplayMember = "FullName";
                comboBoxDoctor.ValueMember = "DoctorID";
                comboBoxDoctor.Enabled = true;

                if (editingAppointment != null)
                {
                    comboBoxPatient.SelectedValue = editingAppointment.PatientID;
                    comboBoxDoctor.SelectedValue = editingAppointment.DoctorID;
                    dateTimePickerDate.Value = editingAppointment.ApptDate;
                    textBoxTime.Text = editingAppointment.ApptTime.ToString(@"hh\:mm");
                }
            }
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            int selectedPatientId = (int)comboBoxPatient.SelectedValue;
            int selectedDoctorId = (int)comboBoxDoctor.SelectedValue;

            DateTime date = dateTimePickerDate.Value.Date;
            TimeSpan time;
            if (!TimeSpan.TryParse(textBoxTime.Text, out time))
            {
                MessageBox.Show("Please enter the time as HH:mm");
                return;
            }

            
            if (currentPatientId != null && selectedPatientId != currentPatientId) {

                MessageBox.Show("You cannot book an appointment for another patient. Please select your own name.");
                return;
            }


            using (var db = new MedicodeEntities())
            {
                int? editingAppointmentID = editingAppointment?.AppointmentID;

                // 1) Doktorun o anda başka randevusu var mı?
                bool isDoctorConflict = db.Appointments.Any(a =>
                    a.DoctorID == selectedDoctorId &&
                    a.ApptDate == date &&
                    a.ApptTime == time &&
                    (editingAppointmentID == null || a.AppointmentID != editingAppointmentID)
                );

                // 2) Hastanın o anda başka randevusu var mı?
                bool isPatientConflict = db.Appointments.Any(a =>
                    a.PatientID == selectedPatientId &&
                    a.ApptDate == date &&
                    a.ApptTime == time &&
                    (editingAppointmentID == null || a.AppointmentID != editingAppointmentID)
                );

                if (isDoctorConflict)
                {
                    MessageBox.Show("This doctor already has an appointment at this time. Please choose another time!");
                    return;
                }
                if (isPatientConflict)
                {
                    MessageBox.Show("This patient already has an appointment at this time. Please choose another time!");
                    return;
                }

                if (editingAppointment == null)
                {
                    // Yeni randevu ekle
                    var appointment = new Appointment
                    {
                        DoctorID = selectedDoctorId,
                        PatientID = selectedPatientId,
                        ApptDate = date,
                        ApptTime = time,
                        Status = "Active"
                    };
                    db.Appointments.Add(appointment);
                }
                else
                {
                    // Randevu düzenle
                    var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == editingAppointment.AppointmentID);
                    if (appointment != null)
                    {
                        appointment.DoctorID = selectedDoctorId;
                        appointment.PatientID = selectedPatientId;
                        appointment.ApptDate = date;
                        appointment.ApptTime = time;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Appointment saved!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
