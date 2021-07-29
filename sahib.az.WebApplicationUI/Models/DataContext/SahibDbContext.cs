using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sahib.az.WebApplicationUI.Models.Entity;
using sahib.az.WebApplicationUI.Models.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sahib.az.WebApplicationUI.Models.DataContext
{
    public class SahibDbContext :
        IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public SahibDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<PerfumeType> Types { get; set; }

        public DbSet<Perfume> Perfumes { get; set; }

        public DbSet<Logo> Logos { get; set; }

        // Identity

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        public DbSet<AppUserLogin> UserLogins { get; set; }
        public DbSet<AppUserClaim> UserClaims { get; set; }
        public DbSet<AppRoleClaim> RoleClaims { get; set; }
        public DbSet<AppUserToken> UserTokens { get; set; }

        // Identity

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Brand>()
                   .Property(cd => cd.CreatedDate)
                   .HasDefaultValueSql("DATEADD(HOUR, 4, GETUTCDATE())");

            builder.Entity<PerfumeType>()
                  .Property(cd => cd.CreatedDate)
                  .HasDefaultValueSql("DATEADD(HOUR, 4, GETUTCDATE())");

            builder.Entity<Perfume>()
                   .Property(cd => cd.CreatedDate)
                   .HasDefaultValueSql("DATEADD(HOUR, 4, GETUTCDATE())");

            builder.Entity<Logo>()
                   .Property(cd => cd.CreatedDate)
                   .HasDefaultValueSql("DATEADD(HOUR, 4, GETUTCDATE())");

            builder.Entity<AppUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });

            builder.Entity<AppUser>()
                   .HasIndex(u => u.UserName)
                   .IsUnique();

            builder.Entity<AppRole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });

            builder.Entity<AppUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");
            });

            builder.Entity<AppUserLogin>(e =>
            {
                e.ToTable("UserLogins", "Membership");
            });

            builder.Entity<AppUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });

            builder.Entity<AppRoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");
            });

            builder.Entity<AppUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });
        }
    }
}
