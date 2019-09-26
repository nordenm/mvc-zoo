using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMVC.Models
{
    public class HabitatSpecie
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public int HabitatId { get; set; }
        public Habitat Habitat { get; set; }
        public int SpieceId { get; set; }
        public Specie Specie { get; set; }
    }
}
