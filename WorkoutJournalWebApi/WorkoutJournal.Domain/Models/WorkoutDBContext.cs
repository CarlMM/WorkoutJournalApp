using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WorkoutJournal.Domain.Models
{
    public partial class WorkoutDBContext : DbContext
    {
        public WorkoutDBContext()
        {
        }

        public WorkoutDBContext(DbContextOptions<WorkoutDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<Muscle> Muscles { get; set; }
        public virtual DbSet<Routine> Routines { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Weekday> Weekdays { get; set; }
        public virtual DbSet<WorkoutExercise> WorkoutExercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WorkoutDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.ToTable("Exercise");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Muscle)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.MuscleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exercise_Muscle");
            });

            modelBuilder.Entity<Muscle>(entity =>
            {
                entity.ToTable("Muscle");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Routine>(entity =>
            {
                entity.ToTable("Routine");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Hobby).IsUnicode(false);

                entity.Property(e => e.ProfileImage).IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Weekday>(entity =>
            {
                entity.ToTable("Weekday");

                entity.Property(e => e.Dayname)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkoutExercise>(entity =>
            {
                entity.ToTable("WorkoutExercise");

                entity.HasOne(d => d.Exercise)
                    .WithMany(p => p.WorkoutExercises)
                    .HasForeignKey(d => d.ExerciseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkoutExercise_Exercise");

                entity.HasOne(d => d.Routine)
                    .WithMany(p => p.WorkoutExercises)
                    .HasForeignKey(d => d.RoutineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkoutExercise_Routine");

                entity.HasOne(d => d.Weekday)
                    .WithMany(p => p.WorkoutExercises)
                    .HasForeignKey(d => d.WeekdayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkoutExercise_Weekday");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
