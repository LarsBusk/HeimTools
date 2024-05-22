using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DexterJitterTool.Model
{
    public class DexterJitterData : DbContext
    {
        public virtual DbSet<Delays> Delays { get; set; }
        public virtual DbSet<TestSetup> TestSetup { get; set; }
        public virtual DbSet<TestSystem> TestSystem { get; set; }

        protected readonly IConfiguration Configuration ;

        public DexterJitterData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("JitterServer"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delays>();
            modelBuilder.Entity<TestSetup>();
            modelBuilder.Entity<TestSystem>();
        }

    }
}
