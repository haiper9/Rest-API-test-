using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
  
        public class CitiesContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public CitiesContext(DbContextOptions<CitiesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            
        }

    }
    }

