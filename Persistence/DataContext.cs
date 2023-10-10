using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser> // classes
    {
        public DataContext(DbContextOptions options) : base(options) // constructor
        {
        }

        public DbSet<Activity> Activities { get; set; } // the activities is going to represent the table name inside the database when it get created
    }
}