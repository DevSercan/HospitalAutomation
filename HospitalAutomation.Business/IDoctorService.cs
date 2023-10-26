using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public interface IDoctorService
    {
        List<Doctor> GetAll();
        Doctor GetById(int id);
        List<Doctor> GetByPolyclinicId(int id);
        void Add(Doctor doctor);
        void Delete(Doctor doctor);
        void Update(Doctor doctor);
    }
}
