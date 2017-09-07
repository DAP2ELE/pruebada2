using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities.Model
{
    class Pet
    {
        public Guid Id { get; set;}
        public String Name { get; set; }
        public int Age { get; set; }
        public String Size { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public Collar AssignedCollar { get; set; }


    }
}
