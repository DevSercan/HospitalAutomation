using HospitalAutomation.DataAccess;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }
        public void Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
        }
        public void Delete(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
        }
        public void Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
        }
        public Doctor GetById(int id)
        {
            return _doctorDal.GetById(id);
        }
        public List<Doctor> GetByPolyclinicId(int id)
        {
            return _doctorDal.GetByPolyclinicId(id);
        }
        public List<Doctor> GetAll()
        {
            DoctorDal doctorDal = new DoctorDal();
            // İş kodları yazılır. (Örn: 'if' koşulları)
            return doctorDal.GetAll();
        }
    }
}
