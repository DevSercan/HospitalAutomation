using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Business
{
    public interface IPolyclinicService
    {
        List<Polyclinic> GetAll();
        Polyclinic GetById(int id);
        void Add(Polyclinic polyclinic);
        void Delete(Polyclinic polyclinic);
        void Update(Polyclinic polyclinic);
    }
}
