using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Models;

namespace UserManagementAPI.Data
{
    public class UserDbContext : DbContext
    {
        // Constructor que pasa las opciones al Db context
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options) { }

        // Define la tabla 'Users' en la base de datos
        public DbSet<User> Users { get; set; }
    }
}
