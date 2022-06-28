using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Models
{
    public class KolosContext : DbContext
    {
        public KolosContext(DbContextOptions<KolosContext> options) : base(options)
        {
           
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MusicianTrack> MusiciansTracks { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicianTrack>(entity =>
            {
                entity.HasKey(e => e.IdMusician)
                    .HasName("IdMusician");

                entity.HasKey(e => e.IdMusician)
                    .HasName("IdTrack");

                entity.ToTable("Musician_Track");
            });
        }
    }
}
