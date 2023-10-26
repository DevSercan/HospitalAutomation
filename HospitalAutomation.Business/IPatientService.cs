using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        Patient GetById(int id);
        void Add(Patient patient);
        void Delete(Patient patient);
        void Update(Patient patient);
    }
}
