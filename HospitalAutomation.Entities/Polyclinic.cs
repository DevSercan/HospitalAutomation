using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Entities
{
    public class Polyclinic : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
