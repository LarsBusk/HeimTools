
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace NoraJitterTool.Model
{
    public partial class NoraJitterData : DbContext
    {
        public virtual DbSet<Delays> Delays { get; set; }
        public virtual DbSet<TestSetup> TestSetup { get; set; }
        public virtual DbSet<TestSystem> TestSystem { get; set; }

        protected readonly IConfiguration Configuration ;

        public NoraJitterData(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("JitterServer"));

    }
}
