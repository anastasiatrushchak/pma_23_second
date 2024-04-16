using Microsoft.EntityFrameworkCore;

namespace Server
{
    public class DBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }

    
        public DBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=users;Username=postgres;Password=Szs200320051979");
            
        }
    }
}
