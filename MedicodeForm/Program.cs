using Medicode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicodeForm
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UpdateExpiredAppointments();
            Application.Run(new Medicode());
        }
    
            static void UpdateExpiredAppointments()
        {
            using (var db = new MedicodeEntities())
            {
                var expiredAppointments = db.Appointments
                    .Where(a => a.ApptDate < DateTime.Today && a.Status == "Active")
                    .ToList();

                foreach (var appt in expiredAppointments)
                    appt.Status = "Expired"; 

                db.SaveChanges();
            }
        }
    }
}
