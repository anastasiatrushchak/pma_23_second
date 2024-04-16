using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class AuthorSongContext : DbContext
    {
        public AuthorSongContext(DbContextOptions<AuthorSongContext> options) : base(options) { }

        public DbSet<AuthorSong> AuthorsSongs { get; set; } = null;
    }
}
