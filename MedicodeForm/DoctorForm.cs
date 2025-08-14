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
    public partial class DoctorForm : Form
    {
        private Doctor editingDoctor = null; // Düzenleme için kullanılacak doktor nesnesi

        public DoctorForm()
        {
            InitializeComponent();
        }

        public DoctorForm(Doctor doctor) : this()
        {
            editingDoctor = doctor;
            if (doctor != null)
            {
                txtFirstName.Text = doctor.FirstName;
                txtLastName.Text = doctor.LastName;
                txtSpecialization.Text = doctor.Specialization;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new MedicodeEntities())
            {
                if (editingDoctor == null)
                {
                    // YENİ DOKTOR EKLEME
                    var doctor = new Doctor
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        Specialization = txtSpecialization.Text.Trim()
                    };
                    db.Doctors.Add(doctor);
                }
                else
                {
                    // DÜZENLEME (EDIT)
                    var doctor = db.Doctors.FirstOrDefault(d => d.DoctorID == editingDoctor.DoctorID);
                    if (doctor != null)
                    {
                        doctor.FirstName = txtFirstName.Text.Trim();
                        doctor.LastName = txtLastName.Text.Trim();
                        doctor.Specialization = txtSpecialization.Text.Trim();
                    }
                }
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
