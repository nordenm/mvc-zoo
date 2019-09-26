using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMVC.Models
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Itinerary> Itinerary { get; set; }
        public virtual DbSet<Habitat> Habitat { get; set; }
        public virtual DbSet<HabitatSpecie> HabitatSpecie { get; set; }
        public virtual DbSet<Specie> Specie { get; set; }
    }
}
