using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API.Models
{
    public partial class BettingWebsiteContext : DbContext
    {
        public BettingWebsiteContext()
        {
        }

        public BettingWebsiteContext(DbContextOptions<BettingWebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bundesliga> Bundesligas { get; set; }
        public virtual DbSet<Laliga> Laligas { get; set; }
        public virtual DbSet<Liga1> Liga1s { get; set; }
        public virtual DbSet<PremierLeague> PremierLeagues { get; set; }
        public virtual DbSet<SeriaA> SeriaAs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6EM94PP;Database=BettingWebsite;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bundesliga>(entity =>
            {
                entity.HasKey(e => e.MatchId)
                    .HasName("PK__Bundesli__9D7FCBA3180CE55F");

                entity.ToTable("Bundesliga");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("match_id");

                entity.Property(e => e.Datat)
                    .HasColumnType("datetime")
                    .HasColumnName("datat");

                entity.Property(e => e.Moneys)
                    .HasColumnType("money")
                    .HasColumnName("moneys");

                entity.Property(e => e.ScoreAway).HasColumnName("score_away");

                entity.Property(e => e.ScoreHome).HasColumnName("score_home");

                entity.Property(e => e.TeamsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("teamsName");
            });

            modelBuilder.Entity<Laliga>(entity =>
            {
                entity.HasKey(e => e.MatchId)
                    .HasName("PK__Laliga__9D7FCBA3F57EA5B1");

                entity.ToTable("Laliga");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("match_id");

                entity.Property(e => e.Datat)
                    .HasColumnType("datetime")
                    .HasColumnName("datat");

                entity.Property(e => e.Moneys)
                    .HasColumnType("money")
                    .HasColumnName("moneys");

                entity.Property(e => e.ScoreAway).HasColumnName("score_away");

                entity.Property(e => e.ScoreHome).HasColumnName("score_home");

                entity.Property(e => e.TeamsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("teamsName");
            });

            modelBuilder.Entity<Liga1>(entity =>
            {
                entity.HasKey(e => e.MatchId)
                    .HasName("PK__Liga1__9D7FCBA30D9C9658");

                entity.ToTable("Liga1");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("match_id");

                entity.Property(e => e.Datat)
                    .HasColumnType("datetime")
                    .HasColumnName("datat");

                entity.Property(e => e.Moneys)
                    .HasColumnType("money")
                    .HasColumnName("moneys");

                entity.Property(e => e.ScoreAway).HasColumnName("score_away");

                entity.Property(e => e.ScoreHome).HasColumnName("score_home");

                entity.Property(e => e.TeamsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("teamsName");
            });

            modelBuilder.Entity<PremierLeague>(entity =>
            {
                entity.HasKey(e => e.MatchId)
                    .HasName("PK__PremierL__9D7FCBA37B50C052");

                entity.ToTable("PremierLeague");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("match_id");

                entity.Property(e => e.Datat)
                    .HasColumnType("datetime")
                    .HasColumnName("datat");

                entity.Property(e => e.Moneys)
                    .HasColumnType("money")
                    .HasColumnName("moneys");

                entity.Property(e => e.ScoreAway).HasColumnName("score_away");

                entity.Property(e => e.ScoreHome).HasColumnName("score_home");

                entity.Property(e => e.TeamsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("teamsName");
            });

            modelBuilder.Entity<SeriaA>(entity =>
            {
                entity.HasKey(e => e.MatchId)
                    .HasName("PK__SeriaA__9D7FCBA34EBBC1C4");

                entity.ToTable("SeriaA");

                entity.Property(e => e.MatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("match_id");

                entity.Property(e => e.Datat)
                    .HasColumnType("datetime")
                    .HasColumnName("datat");

                entity.Property(e => e.Moneys)
                    .HasColumnType("money")
                    .HasColumnName("moneys");

                entity.Property(e => e.ScoreAway).HasColumnName("score_away");

                entity.Property(e => e.ScoreHome).HasColumnName("score_home");

                entity.Property(e => e.TeamsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("teamsName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
