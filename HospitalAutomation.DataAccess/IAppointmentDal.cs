using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
        Appointment GetByPatientId(int id);
    }
}
