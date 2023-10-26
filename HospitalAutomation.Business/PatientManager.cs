using HospitalAutomation.DataAccess;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;
        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }
        public void Add(Patient patient)
        {
            _patientDal.Add(patient);
        }
        public void Delete(Patient patient)
        {
            _patientDal.Delete(patient);
        }
        public void Update(Patient patient)
        {
            _patientDal.Update(patient);
        }
        public Patient GetById(int id)
        {
            return _patientDal.GetById(id);
        }
        public List<Patient> GetAll()
        {
            PatientDal patientDal = new PatientDal();
            // İş kodları yazılır. (Örn: 'if' koşulları)
            return patientDal.GetAll();
        }
    }
}
