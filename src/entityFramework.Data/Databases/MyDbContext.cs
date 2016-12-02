using entityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.Entity.Extensions;

namespace entityFramework.Data.Databases
{
    public class MyDbContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }

        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                const string connectionString =
                    "server=localhost;userid=pluralsight;pwd=test;port=3306;database=entityframework;sslmode=none;";
                optionsBuilder.UseMySQL(connectionString);
            }
        }
    }
}