using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Netcore3TestApp.Models
{
    public partial class CorecruidContext : DbContext
    {
        public CorecruidContext()
        {
        }

        public CorecruidContext(DbContextOptions<CorecruidContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employees1 { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

               
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.ToTable("Employees");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.RollNo).IsRequired();

                entity.Property(e => e.StudentName).IsRequired();
            });
            //modelBuilder.Entity<Department>(entity =>
            //{
            //    entity.Property(e => e.Department_Id).IsRequired();
            //    entity.Property(e => e.Id).UseIdentityColumn(1, 1).IsRequired();
            //});

                OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
