using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;

public partial class CourseDbContext : DbContext
{
    public CourseDbContext()
    {
    }

    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseBookMapping> CourseBookMappings { get; set; }

    public virtual DbSet<StudentTable> StudentTables { get; set; }

    public virtual DbSet<Login> Login { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https:`//go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http:`//go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=EC2AMAZ-EHR6SVV;Initial Catalog=CourseDB;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("bookId");
            entity.Property(e => e.BookName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("bookName");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");
        });

        modelBuilder.Entity<CourseBookMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CourseBookMapping");
        });

        modelBuilder.Entity<StudentTable>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__StudentT__4D11D63C1EF5DACC");

            entity.ToTable("StudentTable");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("studentId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("studentName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
