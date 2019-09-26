using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMVC.Models
{
    public class Specie
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public ICollection<HabitatSpecie> HabitatsSpecies { get; set; }
    }
}
