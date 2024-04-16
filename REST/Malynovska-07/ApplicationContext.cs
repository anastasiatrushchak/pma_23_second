
using Microsoft.EntityFrameworkCore;

namespace UserApi.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Credentials> Credentials { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=12345678;database=usersApi;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
            optionsBuilder.UseLazyLoadingProxies(); //підвязуємо креденшиали коли діставємо юзера
        }
    }
}
