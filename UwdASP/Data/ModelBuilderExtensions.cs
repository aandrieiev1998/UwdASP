using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UwdASP.Data.Models;

namespace UwdASP.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // TODO: добавить данные для расписаний (schedules), присутствий (presneces) и групп преподов (teacher-groups)

            #region Users

            modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = 1L,
                    FirstName = "Andrieiev",
                    LastName = "Andrieiev",
                    UserName = "aandrieiev",
                    UserType = UserType.Student,
                    Email = "aandrieiev@gmail.com",
                    NormalizedEmail = "AANDRIEIEV@GMAIL.COM",
                    NormalizedUserName = "AANDRIEIEV",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+48537018321"
                },
                new User
                {
                    Id = 2L,
                    FirstName = "Dmytro",
                    LastName = "Szewczenko",
                    UserType = UserType.Student,
                    UserName = "dszewczenko",
                    NormalizedUserName = "DSZEWCZENKO",
                    Email = "dszewczenko@mail.ru",
                    NormalizedEmail = "DSZEWCZENKO@MAIL.RU",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+4856433666"
                },
                new User
                {
                    Id = 3L,
                    FirstName = "Mykhailo",
                    LastName = "Morrison",
                    UserType = UserType.Student,
                    UserName = "mmorrison",
                    NormalizedUserName = "MMORRISON",
                    Email = "mmorrison@gmail.com",
                    NormalizedEmail = "MMORRISON@GMAIL.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+4856666666"
                },
                new User
                {
                    Id = 4L,
                    FirstName = "Serhii",
                    LastName = "Razovyi",
                    UserType = UserType.Student,
                    UserName = "srazovyi",
                    NormalizedUserName = "SRAZOVYI",
                    Email = "srazovyi@gmail.com",
                    NormalizedEmail = "SRAZOVYI@GMAIL.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+486565346521"
                },
                 new User
                 {
                     Id = 5L,
                     FirstName = "Matylda",
                     LastName = "Kowalska",
                     UserType = UserType.Student,
                     UserName = "mkowalska",
                     NormalizedUserName = "MKOWALSKA",
                     Email = "mkowalska@gmail.com",
                     NormalizedEmail = "MKOWALSKA@GMAIL.COM",
                     PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                     PhoneNumber = "+48656534642"
                 },
                  new User
                  {
                      Id = 6L,
                      FirstName = "Antonina",
                      LastName = "Wawrzyniak",
                      UserType = UserType.Student,
                      UserName = "awawrzyniak",
                      NormalizedUserName = "AWAWRZYNIAK",
                      Email = "awawrzyniak@gmail.com",
                      NormalizedEmail = "AWAWRZYNIAK@GMAIL.COM",
                      PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                      PhoneNumber = "+4865653464"
                  },
                  new User
                  {
                      Id = 7L,
                      FirstName = "Szymon",
                      LastName = "Karpiński",
                      UserType = UserType.Student,
                      UserName = "skarpiński",
                      NormalizedUserName = "SKARPIŃSKI",
                      Email = "skarpiński@gmail.com",
                      NormalizedEmail = "SKARPIŃSKI@GMAIL.COM",
                      PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                      PhoneNumber = "+4865653465"
                  },
                  new User
                  {
                      Id = 8L,
                      FirstName = "Kinga",
                      LastName = "Pawłowska",
                      UserType = UserType.Student,
                      UserName = "kpawłowska",
                      NormalizedUserName = "KPAWŁOWSKA",
                      Email = "kpawłowska@gmail.com",
                      NormalizedEmail = "KPAWŁOWSKA@GMAIL.COM",
                      PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                      PhoneNumber = "+4865653466"
                  },
                new User
                {
                    Id = 9L,
                    FirstName = "Kicior",
                    LastName = "Rychlicki",
                    UserType = UserType.Teacher,
                    UserName = "krychlicki",
                    NormalizedUserName = "KRYCHLICKI",
                    Email = "krychlicki@gmail.com",
                    NormalizedEmail = "KRYCHLICKI@GMAIL.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+486546546542"
                },
                new User
                {
                    Id = 10L,
                    FirstName = "Adam",
                    LastName = "Niewiamodmski",
                    UserType = UserType.Teacher,
                    UserName = "aniewiamodmski",
                    NormalizedUserName = "ANIEWIADOMSKI",
                    Email = "aniewiamodmski@gmail.com",
                    NormalizedEmail = "ANIEWIADOMSKI@GMAIL.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+486542546443"
                },
                new User
                {
                    Id = 11L,
                    FirstName = "Maciej",
                    LastName = "Kacperski",
                    UserType = UserType.Teacher,
                    UserName = "mkacperski",
                    NormalizedUserName = "MKACPERSKI",
                    Email = "mkacperski@gmail.com",
                    NormalizedEmail = "MKACPERSKI@GMAIL.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                    PhoneNumber = "+489541543785"
                });

            #endregion

            #region Groups

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    Id = 1L,
                    Semester = 7,
                    Name = "Programowanie Gr.1"
                },
                new Group
                {
                    Id = 2L,
                    Semester = 7,
                    Name = "Sieci komputerowe Gr. 2"
                },
                new Group
                {
                    Id = 3L,
                    Semester = 6,
                    Name = "Programowanie"
                },
                new Group
                {
                    Id = 4L,
                    Semester = 5,
                    Name = "Programowanie"
                },
                 new Group
                 {
                     Id = 5L,
                     Semester = 4,
                     Name = "Programowanie"
                 }
                );

            #endregion

            #region Specializations

            modelBuilder.Entity<Specialization>().HasData(
                new Specialization
                {
                    Id = 1L,
                    Name = "Programowanie i bazy danych"
                },
                new Specialization
                {
                    Id = 2L,
                    Name = "Sieci komputerowe"
                },
                new Specialization
                {
                    Id = 3L,
                    Name = "Fizioterapia"
                },
                new Specialization
                {
                    Id = 4L,
                    Name = "Zarządzanie"
                }
                );

            #endregion

            #region Students

            modelBuilder.Entity<StudentData>().HasData(
                new StudentData
                {
                    Id = 1L,
                    UserId = 1L,
                    SpecializationId = 1L,
                    Semester = 7,
                    GroupId = 1L,
                    Balance = 1500.0f,
                    BankAccountNumber = 123456789,
                    Index = 29282,
                    StudyBeginningDate = DateTime.Parse("01-10-2015")
                },
                new StudentData
                {
                    Id = 2L,
                    UserId = 2L,
                    SpecializationId = 1L,
                    Semester = 7,
                    GroupId = 2L,
                    Balance = 1650.0f,
                    BankAccountNumber = 123456789,
                    Index = 29283,
                    StudyBeginningDate = DateTime.Parse("01-10-2015")
                },
                new StudentData
                {
                    Id = 3L,
                    UserId = 3L,
                    SpecializationId = 1L,
                    Semester = 7,
                    GroupId = 1L,
                    Balance = -1300.0f,
                    BankAccountNumber = 123456789,
                    Index = 29284,
                    StudyBeginningDate = DateTime.Parse("01-10-2015")
                },
                new StudentData
                {
                    Id = 4L,
                    UserId = 4L,
                    SpecializationId = 2L,
                    Semester = 7,
                    GroupId = 3L,
                    Balance = 1337.0f,
                    BankAccountNumber = 123456789,
                    Index = 29285,
                    StudyBeginningDate = DateTime.Parse("01-10-2015")
                },
                 new StudentData
                 {
                     Id = 5L,
                     UserId = 5L,
                     SpecializationId = 2L,
                     Semester = 7,
                     GroupId = 3L,
                     Balance = 1337.0f,
                     BankAccountNumber = 123456789,
                     Index = 29285,
                     StudyBeginningDate = DateTime.Parse("01-10-2015")
                 },
                 new StudentData
                 {
                     Id = 6L,
                     UserId = 6L,
                     SpecializationId = 1L,
                     Semester = 7,
                     GroupId = 4L,
                     Balance = 9999.0f,
                     BankAccountNumber = 123456789,
                     Index = 29286,
                     StudyBeginningDate = DateTime.Parse("01-10-2015")
                 },
                 new StudentData
                 {
                     Id = 7L,
                     UserId = 7L,
                     SpecializationId = 1L,
                     Semester = 7,
                     GroupId = 1L,
                     Balance = 2400.0f,
                     BankAccountNumber = 123456789,
                     Index = 29287,
                     StudyBeginningDate = DateTime.Parse("01-10-2015")
                 },
                 new StudentData
                 {
                     Id = 8L,
                     UserId = 8L,
                     SpecializationId = 1L,
                     Semester = 7,
                     GroupId = 1L,
                     Balance = 5000.0f,
                     BankAccountNumber = 123456789,
                     Index = 29288,
                     StudyBeginningDate = DateTime.Parse("01-10-2015")
                 }
                );

            #endregion

            #region Teachers

            modelBuilder.Entity<TeacherData>().HasData(
                new TeacherData
                {
                    Id = 1L,
                    UserId = 9L
                },
                new TeacherData
                {
                    Id = 2L,
                    UserId = 10L
                },
                new TeacherData
                {
                    Id = 3L,
                    UserId = 11L
                });

            #endregion

            #region Lessons

            modelBuilder.Entity<Lesson>().HasData(
                new Lesson
                {
                    Id = 1L,
                    Name = "Matematyka"
                }, new Lesson
                {
                    Id = 2L,
                    Name = "Fizyka"
                }, new Lesson
                {
                    Id = 3L,
                    Name = "Literatura"
                }, new Lesson
                {
                    Id = 4L,
                    Name = "Programowanie Java"
                }, new Lesson
                {
                    Id = 5L,
                    Name = "Programowanie C++"
                }, new Lesson
                {
                    Id = 6L,
                    Name = "Programowanie Python"
                }, new Lesson
                {
                    Id = 7L,
                    Name = "Infrastruktura sieci"
                }, new Lesson
                {
                    Id = 8L,
                    Name = "Bazy danych"
                }, new Lesson
                {
                    Id = 9L,
                    Name = "English"
                });

            #endregion

            #region Marks

            modelBuilder.Entity<Mark>().HasData(
                new Mark
                {
                    Id = 1L,
                    LessonId = 4L,
                    TeacherDataId = 1L,
                    StudentDataId = 1L,
                    Value = 5.0f,
                    Date = DateTime.Parse("2018-11-09T12:34:42"),
                    MarkType = MarkType.Regular,
                    Comment = "Bardzo dobrze"
                },
                new Mark
                {
                    Id = 2L,
                    LessonId = 7L,
                    TeacherDataId = 2L,
                    StudentDataId = 1L,
                    Value = 4.5f,
                    Date = DateTime.Parse("2018-11-10T13:05:07"),
                    MarkType = MarkType.Regular,
                    Comment = "Elegancko"
                },
                new Mark
                {
                    Id = 3L,
                    LessonId = 3L,
                    TeacherDataId = 2L,
                    StudentDataId = 8L,
                    Value = 4.5f,
                    Date = DateTime.Parse("2018-11-10T13:05:02"),
                    MarkType = MarkType.Regular,
                    Comment = "Elegancko"
                },
                new Mark
                {
                    Id = 4L,
                    LessonId = 5L,
                    TeacherDataId = 3L,
                    StudentDataId = 6L,
                    Value = 3.5f,
                    Date = DateTime.Parse("2018-11-10T13:05:09"),
                    MarkType = MarkType.Regular,
                    Comment = "Wystarczy"
                }, new Mark
                {
                    Id = 5L,
                    LessonId = 3L,
                    TeacherDataId = 3L,
                    StudentDataId = 7L,
                    Value = 5.0f,
                    Date = DateTime.Parse("2018-11-10T13:05:09"),
                    MarkType = MarkType.Regular,
                    Comment = "Idealnie"
                }, new Mark
                {
                    Id = 6L,
                    LessonId = 5L,
                    TeacherDataId = 3L,
                    StudentDataId = 2L,
                    Value = 5.0f,
                    Date = DateTime.Parse("2018-11-10T13:05:09"),
                    MarkType = MarkType.Regular,
                    Comment = "Idealnie"
                }, new Mark
                {
                    Id = 7L,
                    LessonId = 8L,
                    TeacherDataId = 3L,
                    StudentDataId = 3L,
                    Value = 3.0f,
                    Date = DateTime.Parse("2018-11-10T13:05:09"),
                    MarkType = MarkType.Regular,
                    Comment = "No niestety"
                }, new Mark
                {
                    Id = 8L,
                    LessonId = 6L,
                    TeacherDataId = 2L,
                    StudentDataId = 6L,
                    Value = 5.0f,
                    Date = DateTime.Parse("2018-11-10T13:05:09"),
                    MarkType = MarkType.Regular,
                    Comment = "Idealnie"
                });

            #endregion

            #region TeacherGroups

            modelBuilder.Entity<TeacherGroup>().HasData(
                new TeacherGroup
                {
                    Id = 1L,
                    GroupId = 1L,
                    TeacherDataId = 3L
                },
                new TeacherGroup
                {
                    Id = 2L,
                    GroupId = 2L,
                    TeacherDataId = 1L
                },
                new TeacherGroup
                {
                    Id = 3L,
                    GroupId = 3L,
                    TeacherDataId = 3L
                });

            #endregion

        }
    }
}