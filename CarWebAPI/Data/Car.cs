using Microsoft.EntityFrameworkCore;

namespace CarWebAPI.Data
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int HorsePowerCount { get; set; }
    }

    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> context) : base(context)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}