using Duozin.Models;
using Microsoft.EntityFrameworkCore;

namespace Duozin.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<FighterModel> Fighters { get; set; }
    }
}