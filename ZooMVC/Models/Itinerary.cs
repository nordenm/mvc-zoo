using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMVC.Models
{
    public class Itinerary
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Duration { get; set; }
        public int Length { get; set; }
        public int Visitors { get; set; }
        public ICollection<Habitat> Habitats { get; set; }
    }
}
