using HospitalAutomation.DataAccess;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }
        public void Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
        }
        public void Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
        }
        public void Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
        }
        public Appointment GetById(int id)
        {
            return _appointmentDal.GetById(id);
        }
        public List<Appointment> GetAll()
        {
            AppointmentDal appointmentDal = new AppointmentDal();
            // İş kodları yazılır. (Örn: 'if' koşulları)
            return appointmentDal.GetAll();
        }
        public Appointment GetByPatientId(int id)
        {
            return _appointmentDal.GetByPatientId(id);
        }
    }
}
