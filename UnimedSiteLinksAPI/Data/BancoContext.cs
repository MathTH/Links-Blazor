using Microsoft.EntityFrameworkCore;
using UnimedSiteLinksAPI.ConfigurationDB;
using UnimedSiteLinksAPI.Moldes;

namespace UnimedSiteLinksAPI.Data
{
    public class BancoContext :DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<UnimedLinksModel> Sites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UnimedLinksConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
