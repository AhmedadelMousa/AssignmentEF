using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
      
        public DateOnly HiringDate { get; set; }
    }
}
