using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public class AppointmentDal : IAppointmentDal
    {
        List<Appointment> _appointments;
        public AppointmentDal()
        { // Constructor
            _appointments = new List<Appointment>();
        }

        public void Add(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void Delete(Appointment appointment)
        {
            _appointments.Remove(appointment);
        }

        public List<Appointment> GetAll()
        {
            return _appointments;
        }

        public Appointment GetById(int id)
        {
            return _appointments.Where(a => a.Id == id).FirstOrDefault(); // Id değeri eşleşen ilk sonucu döndürür.
        }

        public Appointment GetByPatientId(int id)
        {
            return _appointments.FirstOrDefault(a => a.PatientId == id); // patientId değeri eşleşen ilk hasta randevusunu döndürür.
        }

        public void Update(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
