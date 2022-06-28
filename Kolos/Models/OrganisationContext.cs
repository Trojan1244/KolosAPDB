using Microsoft.EntityFrameworkCore;
using System;

namespace Kolos.Models
{
    public class OrganisationContext : DbContext
    {
        public OrganisationContext(DbContextOptions<OrganisationContext> options) : base(options)
        {

        }

        public DbSet<File> Files { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .HasKey("FileID");
            modelBuilder.Entity<File>()
                .HasOne("Team");
            modelBuilder.Entity<File>()
                .HasData(
                    new File { FileID = 1, TeamID = 1, FileName = "secrets", FileExtension = "txt", FileSize = 10},
                    new File { FileID = 2, TeamID = 2, FileName = "mysteries", FileExtension = "txt", FileSize = 15 },
                    new File { FileID = 3, TeamID = 3, FileName = "knowledge", FileExtension = "txt", FileSize = 20 }
                );

            modelBuilder.Entity<Member>()
                .HasKey("MemberID");
            modelBuilder.Entity<Member>()
                .HasData(
                    new Member { MemberID = 1, OrganizationID = 1, MemberName = "William", MemberSurname = "Blazkowich", MemberNickName = "B.J"},
                    new Member { MemberID = 2, OrganizationID = 2, MemberName = "Leonard", MemberSurname = "McGloifinn", MemberNickName = "Scott" },
                    new Member { MemberID = 3, OrganizationID = 3, MemberName = "Gordon", MemberSurname = "Glasscock", MemberNickName = "Doc" }
                );

            modelBuilder.Entity<Membership>()
                .HasKey("MemberID");
            modelBuilder.Entity<Membership>()
                .HasOne("Team");
            modelBuilder.Entity<Membership>()
                .HasOne(e => e.Team)
                .WithMany(e => e.Memberships)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Membership>()
                .HasData(
                    new Membership { MemberID = 1, TeamID = 1, MembershipDate = DateTime.Parse("12-10-1920") },
                    new Membership { MemberID = 2, TeamID = 2, MembershipDate = DateTime.Parse("04-11-1921") },
                    new Membership { MemberID = 3, TeamID = 3, MembershipDate = DateTime.Parse("09-03-1922") }
                );

            modelBuilder.Entity<Organization>()
                .HasKey("OrganizationID");
            modelBuilder.Entity<Organization>()
                .HasData(
                    new Organization { OrganizationID = 1, OrganizationName = "Boston P.D.", OrganizationDomain = "www.bostonpd.com"},
                    new Organization { OrganizationID = 2, OrganizationName = "Caistelwirm Brewery", OrganizationDomain = "www.caistelwirmbrewery.com" },
                    new Organization { OrganizationID = 3, OrganizationName = "Boston Colonial Hospital", OrganizationDomain = "www.bch.com" }
                );

            modelBuilder.Entity<Team>()
                .HasKey("TeamID");
            modelBuilder.Entity<Team>()
                .HasOne(e => e.Organization);
            modelBuilder.Entity<Team>()
                .HasData(
                    new Team { TeamID = 1, OrganizationID = 1, TeamName = "Strikers", TeamDescription = "Some description" },
                    new Team { TeamID = 2, OrganizationID = 2, TeamName = "Brandyheads", TeamDescription = "Very interesting description" },
                    new Team { TeamID = 3, OrganizationID = 3, TeamName = "Crossers", TeamDescription = "Intriguing description" }
                );
        }
    }
}
