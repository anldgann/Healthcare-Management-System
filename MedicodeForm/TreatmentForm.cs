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
    public partial class TreatmentForm : Form
    {
        private Treatment editingTreatment = null;

        public TreatmentForm()
        {
            InitializeComponent();
            LoadAppointments();
        }
        public TreatmentForm(Treatment treatment)
        {
            InitializeComponent();
            LoadAppointments();
            editingTreatment = treatment;
            if (editingTreatment != null)
            {
                comboBoxAppointmentID.SelectedValue = editingTreatment.AppointmentID;
                txtTreatmentType.Text = editingTreatment.TreatmentType;
                txtCost.Text = editingTreatment.Cost.ToString();
                dateTimePickerTreatmentDate.Value = editingTreatment.TreatmentDate;
            }
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAppointmentID.SelectedItem == null)
            {
                MessageBox.Show("Please select an appointment!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTreatmentType.Text) || string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int appointmentId = (int)comboBoxAppointmentID.SelectedValue;
            string treatmentType = txtTreatmentType.Text.Trim();
            decimal cost;
            if (!decimal.TryParse(txtCost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid cost!");
                return;
            }
            DateTime treatmentDate = dateTimePickerTreatmentDate.Value;

            using (var db = new MedicodeEntities())
            {
                if (editingTreatment == null)
                {
                    try
                    {
                        
                        Treatment newTreatment = new Treatment
                        {
                            AppointmentID = appointmentId,
                            TreatmentType = treatmentType,
                            Cost = cost,
                            TreatmentDate = treatmentDate
                        };
                        db.Treatments.Add(newTreatment);
                        db.SaveChanges();
                        MessageBox.Show("Treatment added!");
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("A treatment has already been added for this appointment. You cannot add another treatment for the same appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message);
                        return;
                    }
                }
                else
                {
                    
                    var treat = db.Treatments.FirstOrDefault(t => t.TreatmentID == editingTreatment.TreatmentID);
                    if (treat != null)
                    {
                        treat.AppointmentID = appointmentId;
                        treat.TreatmentType = treatmentType;
                        treat.Cost = cost;
                        treat.TreatmentDate = treatmentDate;
                        db.SaveChanges();
                        MessageBox.Show("Treatment updated!");
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void LoadAppointments()
        {
            using (var db = new MedicodeEntities())
            {
                
                var appts = db.Appointments
                    .Select(a => new
                    {
                        a.AppointmentID,
                        DoctorFirstName = a.Doctor.FirstName,
                        DoctorLastName = a.Doctor.LastName,
                        PatientFirstName = a.Patient.FirstName,
                        PatientLastName = a.Patient.LastName,
                        ApptDate = a.ApptDate
                    })
                    .ToList(); 

                
                var displayList = appts.Select(a => new
                {
                    a.AppointmentID,
                    DisplayText = a.AppointmentID + " - " +
                                  a.DoctorFirstName + " " + a.DoctorLastName + " - " +
                                  a.PatientFirstName + " " + a.PatientLastName +
                                  " (" + a.ApptDate.ToShortDateString() + ")"
                }).ToList();

                comboBoxAppointmentID.DataSource = displayList;
                comboBoxAppointmentID.DisplayMember = "DisplayText";
                comboBoxAppointmentID.ValueMember = "AppointmentID";
            }
        }



    }
}
