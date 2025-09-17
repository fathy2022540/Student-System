using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data
{
    internal class AppDbContext : DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost;Integrated Security=True;DataBase= Student System;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<StudentCourse>().HasKey(c => new { c.StudentId,c.CourseId });

            modelBuilder.Entity<Homework>()
                .HasOne(h => h.Student)
                .WithMany(s => s.Homework)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
            modelBuilder.Entity<Homework>()
                .HasOne(h => h.Course)
                .WithMany(c => c.homeworks)
                .HasForeignKey(h => h.CourseId);
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Course)
                .WithMany(c => c.resources)
                .HasForeignKey(r => r.CourseId);

        }

    }
}
