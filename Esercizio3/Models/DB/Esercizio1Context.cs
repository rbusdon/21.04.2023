using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Esercizio3.Models.DB;

public partial class Esercizio1Context : DbContext
{
    public Esercizio1Context()
    {
    }

    public Esercizio1Context(DbContextOptions<Esercizio1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<Artwork> Artworks { get; set; }

    public virtual DbSet<Charcater> Charcaters { get; set; }

    public virtual DbSet<Museum> Museums { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Esercizio1; User Id=admin; Password=admin; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>(entity =>
        {
            entity.HasKey(e => e.IdArtist).HasName("PK__ARTIST__FB56A910C00D5928");

            entity.ToTable("ARTIST");

            entity.Property(e => e.IdArtist)
                .ValueGeneratedNever()
                .HasColumnName("Id_Artist");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Artwork>(entity =>
        {
            entity.HasKey(e => e.IdArtwork).HasName("PK__ARTWORK__36F32885CD63E055");

            entity.ToTable("ARTWORK");

            entity.Property(e => e.IdArtwork)
                .ValueGeneratedNever()
                .HasColumnName("ID_Artwork");
            entity.Property(e => e.IdArtist).HasColumnName("ID_Artist");
            entity.Property(e => e.IdCharacter).HasColumnName("ID_Character");
            entity.Property(e => e.IdMuseum).HasColumnName("ID_Museum");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdArtistNavigation).WithMany(p => p.Artworks)
                .HasForeignKey(d => d.IdArtist)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ARTWORK__ID_Arti__440B1D61");

            entity.HasOne(d => d.IdCharacterNavigation).WithMany(p => p.Artworks)
                .HasForeignKey(d => d.IdCharacter)
                .HasConstraintName("FK__ARTWORK__ID_Char__44FF419A");

            entity.HasOne(d => d.IdMuseumNavigation).WithMany(p => p.Artworks)
                .HasForeignKey(d => d.IdMuseum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ARTWORK__ID_Muse__4316F928");
        });

        modelBuilder.Entity<Charcater>(entity =>
        {
            entity.HasKey(e => e.IdCharacter).HasName("PK__CHARCATE__DFFB2D56336DEC5F");

            entity.ToTable("CHARCATER");

            entity.Property(e => e.IdCharacter)
                .ValueGeneratedNever()
                .HasColumnName("ID_Character");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Museum>(entity =>
        {
            entity.HasKey(e => e.IdMuseum).HasName("PK__MUSEUM__84BA0522D78E9BCF");

            entity.ToTable("MUSEUM");

            entity.Property(e => e.IdMuseum)
                .ValueGeneratedNever()
                .HasColumnName("Id_Museum");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.MuseumName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
