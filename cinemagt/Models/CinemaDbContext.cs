using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace cinemagt.Models
{
    public class CinemaDbContext: DbContext
    {
        public DbSet<Functions> Functions { get; set; }
        public DbSet<movies> movies { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<sales> sales { get; set; }
        public DbSet<salesdetail> salesdetail { get; set; }

        public DbSet<tickets> tickets { get; set; }

        public CinemaDbContext():base("name=cinemaConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


    }
}
