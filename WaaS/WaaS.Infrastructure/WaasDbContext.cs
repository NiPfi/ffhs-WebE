using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WaaS.Business.Entities;
using WaaS.Business.Interfaces;

namespace WaaS.Infrastructure
{
  public sealed class WaasDbContext : IdentityDbContext
  {
    public DbSet<ScrapeJob> ScrapeJobs { get; set; }

    public WaasDbContext(DbContextOptions options) : base(options)
    {
      Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<ScrapeJob>().ToTable("ScrapeJob");

      base.OnModelCreating(builder);
    }
  }
}
