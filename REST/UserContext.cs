using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UsersApi.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Data> Data { get; set; }
        public UserContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=12345678;database=usersApi3;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
            optionsBuilder.UseLazyLoadingProxies(); 
        }
    }
}
