using Intillegio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intillegio.Data.Data
{
    public class IntillegioContext : IdentityDbContext<IntillegioUser>
    {
        public IntillegioContext(DbContextOptions<IntillegioContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProjectFeatures> ProjectFeatures { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IntillegioUser>().ToTable("User");
            builder.Entity<IntillegioUser>().Property(u => u.PasswordHash).HasMaxLength(500);

            builder.Entity<ProjectFeatures>()
                .HasKey(pf => new {pf.ProjectId, pf.FeatureId});

            builder.Entity<ProjectFeatures>()
                .HasOne(p => p.Project)
                .WithMany(f => f.Features)
                .HasForeignKey(pf => pf.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ProjectFeatures>()
                .HasOne(f => f.Feature)
                .WithMany(p => p.Projects)
                .HasForeignKey(f => f.FeatureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
