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

    public partial class BillsForm : Form
    {
        private int _patientId;
        public BillsForm()
        {
            InitializeComponent();
        }

        public BillsForm(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            using (var db = new MedicodeEntities())
            {
                var bills = (from a in db.Appointments
                             join t in db.Treatments on a.AppointmentID equals t.AppointmentID
                             join d in db.Doctors on a.DoctorID equals d.DoctorID 
                             where a.PatientID == _patientId
                             select new
                             {
                                 AppointmentDate = a.ApptDate,
                                 DoctorName = d.FirstName + " " + d.LastName, 
                                 TreatmentType = t.TreatmentType,
                                 TreatmentDate = t.TreatmentDate,
                                 Cost = t.Cost
                             }).ToList();

                dataGridViewBills.DataSource = bills;
                lblTotalCost.Text = "Total: " + bills.Sum(b => b.Cost).ToString("C");
            }
        }

    }
}
