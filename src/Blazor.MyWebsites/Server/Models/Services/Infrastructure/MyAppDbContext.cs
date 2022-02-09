using Blazor.MyWebsites.Shared.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor.PersonalWebSites.Server.Models.Services.Infrastructure
{
    public partial class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<CompetenzaPersonale> CompetenzePersonali { get; set; }
        public virtual DbSet<CompetenzaTecnica> CompetenzeTecniche { get; set; }
        public virtual DbSet<CorsoOnline> CorsiOnline { get; set; }
        public virtual DbSet<EsperienzaProfessionale> EsperienzeProfessionali { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompetenzaPersonale>(entity =>
            {
                entity.ToTable("CompetenzePersonali");
                entity.HasKey(table => table.Id);
            });

            modelBuilder.Entity<CompetenzaTecnica>(entity =>
            {
                entity.ToTable("CompetenzeTecniche");
                entity.HasKey(table => table.Id);
            });

            modelBuilder.Entity<CorsoOnline>(entity =>
            {
                entity.ToTable("CorsiOnline");
                entity.HasKey(table => table.Id);
            });

            modelBuilder.Entity<EsperienzaProfessionale>(entity =>
            {
                entity.ToTable("EsperienzeProfessionali");
                entity.HasKey(table => table.Id);
            });
        }
    }
}