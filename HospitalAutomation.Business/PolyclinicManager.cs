using HospitalAutomation.DataAccess;
using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public class PolyclinicManager : IPolyclinicService
    {
        IPolyclinicDal _polyclinicDal;
        public PolyclinicManager(IPolyclinicDal polyclinicDal)
        {
            _polyclinicDal = polyclinicDal;
        }
        public void Add(Polyclinic polyclinic)
        {
            _polyclinicDal.Add(polyclinic);
        }
        public void Delete(Polyclinic polyclinic)
        {
            _polyclinicDal.Delete(polyclinic);
        }
        public void Update(Polyclinic polyclinic)
        {
            _polyclinicDal.Update(polyclinic);
        }
        public Polyclinic GetById(int id)
        {
            return _polyclinicDal.GetById(id);
        }
        public List<Polyclinic> GetAll()
        {
            PolyclinicDal polyclinicDal = new PolyclinicDal();
            // İş kodları yazılır. (Örn: 'if' koşulları)
            return polyclinicDal.GetAll();
        }

    }
}
