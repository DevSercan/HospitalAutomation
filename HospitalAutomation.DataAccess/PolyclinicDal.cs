using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public class PolyclinicDal : IPolyclinicDal
    {
        List<Polyclinic> _polyclinics;
        public PolyclinicDal() // Constructor
        {
            _polyclinics = new List<Polyclinic>
            {
                new Polyclinic {Id=1, Name="Aile Hekimliği"},
                new Polyclinic {Id=2, Name="Beyin ve Sinir Cerrahisi"},
                new Polyclinic {Id=3, Name="Cerrahi Onkolojisi"},
                new Polyclinic {Id=4, Name="Çocuk Göğüs Hastalıkları"},
                new Polyclinic {Id=5, Name="Diş Hekimliği (Genel Diş)"},
                new Polyclinic {Id=6, Name="Fiziksel Tıp ve Rehabilitasyon"},
                new Polyclinic {Id=7, Name="Genel Cerrahi"},
                new Polyclinic {Id=8, Name="İç Hastalıkları (Dahiliye)"},
                new Polyclinic {Id=9, Name="Kadın Hastalıkları ve Doğum"},
                new Polyclinic {Id=10, Name="Kalp ve Damar Cerrahisi"}
            };
        }
        public void Add(Polyclinic polyclinic)
        {
            throw new NotImplementedException();
        }

        public void Delete(Polyclinic polyclinic)
        {
            throw new NotImplementedException();
        }

        public List<Polyclinic> GetAll()
        {
            return _polyclinics;
        }

        public Polyclinic GetById(int id)
        {
            return _polyclinics.Where(p => p.Id == id).FirstOrDefault(); // Id değeri eşleşen ilk sonucu döndürür.
        }

        public void Update(Polyclinic polyclinic)
        {
            throw new NotImplementedException();
        }
    }
}
