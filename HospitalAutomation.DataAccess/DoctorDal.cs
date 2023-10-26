using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public class DoctorDal : IDoctorDal
    {
        List<Doctor> _doctors;
        public DoctorDal() // Constructor
        {
            _doctors = new List<Doctor>
            {
                new Doctor {Id=1, FirstName="Mehmet", LastName="Özkul", PolyclinicId=2, PhoneNumber="(+90) 542 456 4567", Email="mehmetozkul@hotmail.com", Password="123456", NationalId="43210987654"},
                new Doctor {Id=2, FirstName="Zeynep", LastName="Aktaş", PolyclinicId=4, PhoneNumber="(+90) 543 210 4321", Email="zeynepaktas@hotmail.com", Password="123456", NationalId="54320912345"},
                new Doctor {Id=3, FirstName="Mert", LastName="Erkan", PolyclinicId=6, PhoneNumber="(+90) 553 321 0123", Email="merterkan@hotmail.com", Password="123456", NationalId="65430987654"}
            };
        }

        public void Add(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetAll()
        {
            return _doctors;
        }

        public Doctor GetById(int id)
        {
            return _doctors.Where(d => d.Id == id).FirstOrDefault(); // Id değeri eşleşen ilk sonucu döndürür.
        }

        public List<Doctor> GetByPolyclinicId(int id)
        {
            return _doctors.Where(d => d.PolyclinicId == id).ToList(); // Id değeri eşleşen doktorları liste olarak döndürür.
        }

        public void Update(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
