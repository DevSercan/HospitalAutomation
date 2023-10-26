using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public class PatientDal : IPatientDal
    {
        List<Patient> _patients;
        public PatientDal() // Constructor
        {
            _patients = new List<Patient>
            {
                new Patient {Id=1, FirstName="Sercan", LastName="Bayrak", PhoneNumber="(+90) 553 123 4567", Email="sercanbayrak@hotmail.com", Password="123456", NationalId="10987654321"}
            };
        }

        public void Add(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void Delete(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAll()
        {
            return _patients;
        }

        public Patient GetById(int id)
        {
            return _patients.Where(p => p.Id == id).FirstOrDefault(); // Id değeri eşleşen ilk sonucu döndürür.
        }

        public void Update(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
