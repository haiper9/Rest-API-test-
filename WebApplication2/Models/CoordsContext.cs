using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
  
        public class CoordsContext : DbContext
    {
       public DbSet<Coords> coords { get; set; }
        public CoordsContext(DbContextOptions<CoordsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
    }

