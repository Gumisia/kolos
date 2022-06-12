using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplicationK.Models
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<MusicLabel> MusicLabels { get; set; }
        public virtual DbSet<Musican> Musicans { get; set; }
        public virtual DbSet<MusicanTrack> MusicanTracks { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.IdAlbum)
                    .HasName("Album_pk");

                entity.ToTable("Album");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdMusicLabelNavigation)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.IdMusicLabel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MusicLabel_Album");
            });

            modelBuilder.Entity<MusicLabel>(entity =>
            {
                entity.HasKey(e => e.IdMusicLabel)
                    .HasName("MusicLabel_pk");

                entity.ToTable("MusicLabel");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Musican>(entity =>
            {
                entity.HasKey(e => e.IdMusican)
                    .HasName("Musican_pk");

                entity.ToTable("Musican");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(20);
            });

            modelBuilder.Entity<MusicanTrack>(entity =>
            {
                entity.HasKey(e => new { e.IdTrack, e.IdMusican })
                    .HasName("Musican_Track_pk");

                entity.ToTable("Musican_Track");

                entity.HasOne(d => d.IdMusicanNavigation)
                    .WithMany(p => p.MusicanTracks)
                    .HasForeignKey(d => d.IdMusican)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Musican_Musican_Track");

                entity.HasOne(d => d.IdTrackNavigation)
                    .WithMany(p => p.MusicanTracks)
                    .HasForeignKey(d => d.IdTrack)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Track_Musican_Track");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.HasKey(e => e.IdTrack)
                    .HasName("Track_pk");

                entity.ToTable("Track");

                entity.Property(e => e.TrackName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdMusicAlbumNavigation)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.IdMusicAlbum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Album_Track");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
