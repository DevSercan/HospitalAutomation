using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int DoctorId { get; set; }
        public int PolyclinicId { get; set; }
        public int PatientId { get; set; }
    }
}
