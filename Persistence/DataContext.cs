using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext // classes
    {
        public DataContext(DbContextOptions options) : base(options) // constructor
        {
        }

        public DbSet<Activity> Activities { get; set; } // the activities is going to represent the table name inside the database when it get created
    }
}