using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMapping
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AnimalIdent { get; set; } // New property
        public DateTime DateofBirth { get; set; } // New property
    }
}
