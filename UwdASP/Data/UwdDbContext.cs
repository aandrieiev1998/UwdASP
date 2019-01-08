using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UwdASP.Data.Models;
using UwdASP.Data.Models.Bookkeepings;
using UwdASP.Data.Models.Marks;

namespace UwdASP.Data
{
    public class UwdDbContext : IdentityDbContext<User, IdentityRole<long>, long>
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<StudentData> StudentsData { get; set; }
        public DbSet<TeacherData> TeachersData { get; set; }
        public DbSet<TeacherGroup> TeacherGroups { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Bookkeeping> Bookkeepings { get; set; }
             
        public UwdDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<User>()
                .Property(u => u.UserType)
                .HasConversion(
                    v => v.ToString(),
                    v => (UserType)Enum.Parse(typeof(UserType), v));

            modelBuilder
                .Entity<Mark>()
                .Property(m => m.MarkType)
                .HasConversion(
                    v => v.ToString(),
                    v => (MarkType)Enum.Parse(typeof(MarkType), v));

            modelBuilder
                .Entity<StudentData>()
                .Property(sd => sd.StudyType)
                .HasConversion(
                    v => v.ToString(),
                    v => (StudyType)Enum.Parse(typeof(StudyType), v));

            modelBuilder.Seed();
        }
    }
}
