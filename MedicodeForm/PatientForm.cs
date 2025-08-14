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
    public partial class PatientForm : Form
    {
        private Patient editingPatient = null;


        public PatientForm(Patient patient = null)
        {
            InitializeComponent();

            if (patient != null)
            {
                editingPatient = patient;
                txtFirstName.Text = patient.FirstName;
                txtLastName.Text = patient.LastName;
                dtpDateOfBirth.Value = patient.DateOfBirth;
                txtGender.Text = patient.Gender;
                txtPassword.Text = patient.PasswordHash;
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            
            string gender = txtGender.Text.Trim().ToUpper();
            if (gender != "M" && gender != "F")
            {
                MessageBox.Show("Gender must be 'M' (Male) or 'F' (Female).");
                return;
            }

            using (var db = new MedicodeEntities())
            {
                if (editingPatient == null)
                {
                    var patient = new Patient
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        DateOfBirth = dtpDateOfBirth.Value,
                        Gender = gender, 
                        PasswordHash = txtPassword.Text.Trim()
                    };
                    db.Patients.Add(patient);
                }
                else
                {
                    var patient = db.Patients.FirstOrDefault(p => p.PatientID == editingPatient.PatientID);
                    if (patient != null)
                    {
                        patient.FirstName = txtFirstName.Text.Trim();
                        patient.LastName = txtLastName.Text.Trim();
                        patient.DateOfBirth = dtpDateOfBirth.Value;
                        patient.Gender = gender; 
                        patient.PasswordHash = txtPassword.Text.Trim();
                    }
                }
                db.SaveChanges();
            }
        MessageBox.Show("Patient saved!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
