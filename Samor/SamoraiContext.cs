using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Samor;

namespace EntityFramework
{
    public class SamoraiContext:DbContext
    {
        public DbSet<Samorai> Samorais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-N6J36V3",
                InitialCatalog = "Samorai",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(connection.ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamoraiBattle>().HasKey(battle => new {battle.BattleId, battle.SamoraiId});
            modelBuilder.Entity<Samorai>().Property(samorai => samorai.Name).IsRequired().HasMaxLength(50)
                .HasColumnName("SamoraiName");
            modelBuilder.Entity<Samorai>().ToTable("Samories");
            modelBuilder.Entity<Clan>().ToTable("Clans");
            modelBuilder.Entity<Quote>().ToTable("Quotes");
            modelBuilder.Entity<SamoraiBattle>().ToTable("SamoraiBattles");
        }
    }
    
}