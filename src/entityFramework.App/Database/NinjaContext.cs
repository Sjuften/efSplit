using entityFramework.App.Entities;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.Entity.Extensions;

namespace entityFramework.App.Database
{
    public class NinjaContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> NinjaEquipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString =
                "server=localhost;userid=pluralsight;pwd=test;port=3306;database=EntityFramework;sslmode=none;";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}