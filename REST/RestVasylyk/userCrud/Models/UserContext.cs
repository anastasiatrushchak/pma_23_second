using Microsoft.EntityFrameworkCore;

namespace userCrud.Models;

public class UserContext:DbContext
{
    public DbSet<User> Users { get; set;}
    public DbSet<Message> Messages { get; set;}
    
    public UserContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "server=localhost;user=root;password=12345678;database=users;";

        optionsBuilder.UseMySql(connection,
            ServerVersion.AutoDetect(connection));
        optionsBuilder.UseLazyLoadingProxies();
    }
}