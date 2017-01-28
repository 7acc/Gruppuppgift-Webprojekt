using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL
{
    public class Webb4Context : DbContext
    {

        public Webb4Context() : base("Webb4ContextV2")
        {
            
        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<AppartmentPhoto> Photos { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<HousingType> HousingTypes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
