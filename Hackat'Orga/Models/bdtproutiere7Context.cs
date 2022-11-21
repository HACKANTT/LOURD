using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hackat_Orga.Models
{
    public partial class bdtproutiere7Context : DbContext
    {
        public bdtproutiere7Context()
        {
        }

        public bdtproutiere7Context(DbContextOptions<bdtproutiere7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Hackaton> Hackatons { get; set; } = null!;
        public virtual DbSet<Inscription> Inscriptions { get; set; } = null!;
        public virtual DbSet<Inscrit> Inscrits { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.4.1;port=3306;user=sqltproutiere;password=savary;database=bdtproutiere7;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.15-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("doctrine_migration_versions");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("execution_time");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.ToTable("evenements");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateEvent).HasColumnName("date_event");

                entity.Property(e => e.Duree)
                    .HasColumnType("time")
                    .HasColumnName("duree");

                entity.Property(e => e.Heure)
                    .HasColumnType("time")
                    .HasColumnName("heure");

                entity.Property(e => e.Libelle)
                    .HasMaxLength(255)
                    .HasColumnName("libelle");

                entity.Property(e => e.Salle)
                    .HasMaxLength(255)
                    .HasColumnName("salle");
            });

            modelBuilder.Entity<Hackaton>(entity =>
            {
                entity.ToTable("hackatons");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Cp)
                    .HasMaxLength(5)
                    .HasColumnName("cp");

                entity.Property(e => e.DateDebut).HasColumnName("date_debut");

                entity.Property(e => e.DateFin).HasColumnName("date_fin");

                entity.Property(e => e.DateLimite).HasColumnName("date_limite");

                entity.Property(e => e.Description)
                    .HasMaxLength(600)
                    .HasColumnName("description");

                entity.Property(e => e.HeureDebut)
                    .HasColumnType("time")
                    .HasColumnName("heure_debut");

                entity.Property(e => e.HeureFin)
                    .HasColumnType("time")
                    .HasColumnName("heure_fin");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nb_places");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue");

                entity.Property(e => e.Theme)
                    .HasMaxLength(100)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.ToTable("inscription");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IdUId, "IDX_5E90F6D66F858F92");

                entity.HasIndex(e => e.IdHId, "IDX_5E90F6D6CDF600D0");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateInscription).HasColumnName("date_inscription");

                entity.Property(e => e.IdHId)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_h_id");

                entity.Property(e => e.IdUId)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_u_id");

                entity.Property(e => e.NumInscription)
                    .HasMaxLength(255)
                    .HasColumnName("num_inscription");

                entity.HasOne(d => d.IdH)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdHId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_5E90F6D6CDF600D0");

                entity.HasOne(d => d.IdU)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdUId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_5E90F6D66F858F92");
            });

            modelBuilder.Entity<Inscrit>(entity =>
            {
                entity.ToTable("inscrits");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateurs");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DateNaissance).HasColumnName("date_naissance");

                entity.Property(e => e.LienPortfolio)
                    .HasMaxLength(255)
                    .HasColumnName("lien_portfolio");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
