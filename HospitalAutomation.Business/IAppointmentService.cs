using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment GetById(int id);
        Appointment GetByPatientId(int id);
        void Add(Appointment appointment);
        void Delete(Appointment appointment);
        void Update(Appointment appointment);
    }
}
