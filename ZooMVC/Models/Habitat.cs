using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMVC.Models
{
    public class Habitat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Weather { get; set; }
        public string Vegetation { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
        public ICollection<HabitatSpecie> HabitatsSpecies { get; set; }
    }
}
