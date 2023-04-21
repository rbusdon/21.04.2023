﻿// <auto-generated />
using System;
using Esercizio3.Models.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Esercizio3.Migrations
{
    [DbContext(typeof(Esercizio1Context))]
    partial class Esercizio1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Esercizio3.Models.DB.Artist", b =>
                {
                    b.Property<int>("IdArtist")
                        .HasColumnType("int")
                        .HasColumnName("Id_Artist");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdArtist")
                        .HasName("PK__ARTIST__FB56A910C00D5928");

                    b.ToTable("ARTIST", (string)null);
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Artwork", b =>
                {
                    b.Property<int>("IdArtwork")
                        .HasColumnType("int")
                        .HasColumnName("ID_Artwork");

                    b.Property<int>("IdArtist")
                        .HasColumnType("int")
                        .HasColumnName("ID_Artist");

                    b.Property<int?>("IdCharacter")
                        .HasColumnType("int")
                        .HasColumnName("ID_Character");

                    b.Property<int>("IdMuseum")
                        .HasColumnType("int")
                        .HasColumnName("ID_Museum");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdArtwork")
                        .HasName("PK__ARTWORK__36F32885CD63E055");

                    b.HasIndex("IdArtist");

                    b.HasIndex("IdCharacter");

                    b.HasIndex("IdMuseum");

                    b.ToTable("ARTWORK", (string)null);
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Charcater", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnType("int")
                        .HasColumnName("ID_Character");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCharacter")
                        .HasName("PK__CHARCATE__DFFB2D56336DEC5F");

                    b.ToTable("CHARCATER", (string)null);
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Museum", b =>
                {
                    b.Property<int>("IdMuseum")
                        .HasColumnType("int")
                        .HasColumnName("Id_Museum");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MuseumName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMuseum")
                        .HasName("PK__MUSEUM__84BA0522D78E9BCF");

                    b.ToTable("MUSEUM", (string)null);
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Artwork", b =>
                {
                    b.HasOne("Esercizio3.Models.DB.Artist", "IdArtistNavigation")
                        .WithMany("Artworks")
                        .HasForeignKey("IdArtist")
                        .IsRequired()
                        .HasConstraintName("FK__ARTWORK__ID_Arti__440B1D61");

                    b.HasOne("Esercizio3.Models.DB.Charcater", "IdCharacterNavigation")
                        .WithMany("Artworks")
                        .HasForeignKey("IdCharacter")
                        .HasConstraintName("FK__ARTWORK__ID_Char__44FF419A");

                    b.HasOne("Esercizio3.Models.DB.Museum", "IdMuseumNavigation")
                        .WithMany("Artworks")
                        .HasForeignKey("IdMuseum")
                        .IsRequired()
                        .HasConstraintName("FK__ARTWORK__ID_Muse__4316F928");

                    b.Navigation("IdArtistNavigation");

                    b.Navigation("IdCharacterNavigation");

                    b.Navigation("IdMuseumNavigation");
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Artist", b =>
                {
                    b.Navigation("Artworks");
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Charcater", b =>
                {
                    b.Navigation("Artworks");
                });

            modelBuilder.Entity("Esercizio3.Models.DB.Museum", b =>
                {
                    b.Navigation("Artworks");
                });
#pragma warning restore 612, 618
        }
    }
}
