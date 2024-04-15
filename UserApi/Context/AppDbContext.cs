using Microsoft.EntityFrameworkCore;
using UserApi.Models; // Parte del entity framework ORM


namespace UserApi.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<User> Usuarios { get; set; } 
    }
}
