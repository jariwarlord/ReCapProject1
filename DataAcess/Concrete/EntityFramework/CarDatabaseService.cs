using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAcess.Concrete.EntityFramework
{
    public class CarDatabaseService:DbContext
    {
        public DbSet<CarDatabaseService> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarDatabase;Trusted_Connection=true");

        }

    }
}
