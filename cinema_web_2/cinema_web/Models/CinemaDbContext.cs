using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace cinema_web.Models
{
    public partial class CinemaDbContext : DbContext
    {
        public CinemaDbContext()
        {
        }

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Screening> Screenings { get; set; }
        public virtual DbSet<ScreeningFilm> ScreeningFilms { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-PGPTJU6K\\SQLEXPRESS;Database=CinemaDb;Integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Accounts_Roles");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.IsFilming).HasColumnName("IsFilming").HasColumnType("bit");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Director).HasMaxLength(50);

                entity.Property(e => e.FilmName).HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Thmb).HasMaxLength(255);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleDes).HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<ScreeningFilm>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.ScreeningId })
                    .HasName("PK__Screenin__BA6E6CDA48480B40");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.ScreeningId).HasColumnName("ScreeningID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.ScreeningFilms)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Screening__FilmI__6383C8BA");

                entity.HasOne(d => d.Screening)
                    .WithMany(p => p.ScreeningFilms)
                    .HasForeignKey(d => d.ScreeningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Screening__Scree__6477ECF3");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.FilmName).HasMaxLength(50);

                entity.Property(e => e.ScreeningDate).HasColumnType("date");

                entity.Property(e => e.SeatNumber).HasMaxLength(10);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Tickets_Accounts");

                entity.HasOne(d => d.Screening)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ScreeningId)
                    .HasConstraintName("FK_Tickets_Screenings");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
