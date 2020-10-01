using Microsoft.EntityFrameworkCore;
using Plants.Models;

namespace Plants.Backend
{
    public class Datastore : DbContext
    {
        public Datastore(DbContextOptions<Datastore> options)
            : base(options)
        {
        }

        public DbSet<PlantModel> Plants { get; set; }
    }
}



