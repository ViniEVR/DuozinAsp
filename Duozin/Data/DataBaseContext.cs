using Duozin.Models;
using Duozin.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Duozin.Data
{
    public class DataBaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbSet<MidModel> MidModels {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MidConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=Duozin; Integrated Security = true",p=>p.EnableRetryOnFailure(
                maxRetryCount: 10, 
                maxRetryDelay: TimeSpan.FromSeconds(5), 
                errorNumbersToAdd: null).MigrationsHistoryTable("Duozin_ef"));
        }
    }
}