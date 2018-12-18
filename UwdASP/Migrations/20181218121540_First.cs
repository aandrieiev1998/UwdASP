using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UwdASP.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserType = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Semester = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LessonId = table.Column<long>(nullable: false),
                    GroupId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsData",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<long>(nullable: false),
                    GroupId = table.Column<long>(nullable: false),
                    SpecializationId = table.Column<long>(nullable: false),
                    StudyType = table.Column<string>(nullable: false),
                    StudyBeginningDate = table.Column<DateTime>(nullable: false),
                    Semester = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    Balance = table.Column<float>(nullable: false),
                    BankAccountNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsData_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsData_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsData_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherGroups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TeacherId = table.Column<long>(nullable: false),
                    TeacherDataId = table.Column<long>(nullable: true),
                    GroupId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherGroups_Teachers_TeacherDataId",
                        column: x => x.TeacherDataId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LessonId = table.Column<long>(nullable: false),
                    TeacherDataId = table.Column<long>(nullable: false),
                    StudentDataId = table.Column<long>(nullable: false),
                    Value = table.Column<float>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    MarkType = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_StudentsData_StudentDataId",
                        column: x => x.StudentDataId,
                        principalTable: "StudentsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_Teachers_TeacherDataId",
                        column: x => x.TeacherDataId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presences",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    StudentId = table.Column<long>(nullable: false),
                    LessonId = table.Column<long>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presences_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presences_StudentsData_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentsData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { 7L, 0, "dfddd781-c307-4409-aba4-2d5f92643cc2", "mkacperski@gmail.com", false, "Maciej", "Kacperski", false, null, "MKACPERSKI@GMAIL.COM", "MKACPERSKI", "AQAAAAEAACcQAAAAEEuO86l3DkIwJOy+XuYCZxOsKLUCAQx/Ov5Mgqq54ohl7ZjFJtJUDUFp8p69XkJKgw==", "+489541543785", false, null, false, "mkacperski", "Teacher" },
                    { 5L, 0, "44c9df02-1ba2-46dc-8bc0-51ac1accfcd7", "krychlicki@gmail.com", false, "Kicior", "Rychlicki", false, null, "KRYCHLICKI@GMAIL.COM", "KRYCHLICKI", "AQAAAAEAACcQAAAAEMCwHTknufNkxSPgUxnmRtdNR8ei+wf0xKELSkjn6is3CpuPQJ4G2HwOLmrFn4+grQ==", "+486546546542", false, null, false, "krychlicki", "Teacher" },
                    { 4L, 0, "0986510c-673b-4351-8579-8e12eaa2ca46", "srazovyi@gmail.com", false, "Serhii", "Razovyi", false, null, "SRAZOVYI@GMAIL.COM", "SRAZOVYI", "AQAAAAEAACcQAAAAEBzxWjbAXQX/+wumPhCkcmkUJjrTVOLiW1tTdsIImmZxX0+tH/fibGrp0yqdW/DGNg==", "+486565346521", false, null, false, "srazovyi", "Student" },
                    { 3L, 0, "51174aeb-4746-4efb-8ca5-6349e0dfebde", "mmorrison@gmail.com", false, "Mykhailo", "Morrison", false, null, "MMORRISON@GMAIL.COM", "MMORRISON", "AQAAAAEAACcQAAAAEMOXpi61fXOutj7G7c5aSLmzm/ovp0KUyAt76uGkdByFf19FHlkXiAhSwiT+hHZrng==", "+4856666666", false, null, false, "mmorrison", "Student" },
                    { 2L, 0, "308aac2a-e14c-4c7a-8ebc-4e64c5c0a304", "dszewczenko@mail.ru", false, "Dmytro", "Szewczenko", false, null, "DSZEWCZENKO@MAIL.RU", "DSZEWCZENKO", "AQAAAAEAACcQAAAAEHucvZuEKuK2vFIPngmc/7DYm2F7aK9PtTTC1sweRXQa7oVR8Cpis7AnCyP1p/Jjtg==", "+4856433666", false, null, false, "dszewczenko", "Student" },
                    { 1L, 0, "0a4feb01-d3e9-4946-b06e-e9bde9a69c69", "aandrieiev@gmail.com", false, "Andrieiev", "Andrieiev", false, null, "AANDRIEIEV@GMAIL.COM", "AANDRIEIEV", "AQAAAAEAACcQAAAAEH5tGQxoUEBR2nq9k62PycCSMmyenJMrTkafB8upla0ILEoOSlO+X3bGBVN4hdf3wQ==", "+48537018321", false, null, false, "aandrieiev", "Student" },
                    { 6L, 0, "351a1aa8-078f-4d24-bd55-250cd7833f63", "aniewiamodmski@gmail.com", false, "Adam", "Niewiamodmski", false, null, "ANIEWIADOMSKI@GMAIL.COM", "ANIEWIADOMSKI", "AQAAAAEAACcQAAAAECKucyNLnabqWmTdzxqiKb6UGLGtrxr/OKwlKoTCrL9/h975hpPNWp4OTbNipcC7Wg==", "+486542546443", false, null, false, "aniewiamodmski", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "Semester" },
                values: new object[,]
                {
                    { 1L, "Programowanie Gr.1", 7 },
                    { 2L, "Sieci komputerowe Gr. 2", 7 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7L, "Infrastruktura sieci" },
                    { 8L, "Bazy danych" },
                    { 5L, "Programowanie C++" },
                    { 4L, "Programowanie Java" },
                    { 3L, "Literatura" },
                    { 2L, "Fizyka" },
                    { 1L, "Matematyka" },
                    { 6L, "Programowanie Python" },
                    { 9L, "English" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Programowanie i bazy danych" },
                    { 2L, "Sieci komputerowe" },
                    { 3L, "Fizioterapia" },
                    { 4L, "Zarządzanie" }
                });

            migrationBuilder.InsertData(
                table: "StudentsData",
                columns: new[] { "Id", "Balance", "BankAccountNumber", "GroupId", "Index", "Semester", "SpecializationId", "StudyBeginningDate", "StudyType", "UserId" },
                values: new object[,]
                {
                    { 1L, 1500f, 123456789, 1L, 29282, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 1L },
                    { 2L, 1650f, 123456789, 1L, 29283, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 2L },
                    { 3L, -1300f, 123456789, 1L, 29284, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 3L },
                    { 4L, 1337f, 123456789, 2L, 29285, 7, 2L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 4L }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1L, 5L },
                    { 2L, 6L },
                    { 3L, 7L }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "Comment", "Date", "LessonId", "MarkType", "StudentDataId", "TeacherDataId", "Value" },
                values: new object[,]
                {
                    { 2L, "Elegancko", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 7, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 7L, "Regular", 1L, 2L, 4.5f },
                    { 1L, "Bardzo dobrze", new DateTimeOffset(new DateTime(2018, 11, 9, 12, 34, 42, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 4L, "Regular", 1L, 3L, 5f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marks_LessonId",
                table: "Marks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_StudentDataId",
                table: "Marks",
                column: "StudentDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_TeacherDataId",
                table: "Marks",
                column: "TeacherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Presences_LessonId",
                table: "Presences",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Presences_StudentId",
                table: "Presences",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_GroupId",
                table: "Schedules",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_LessonId",
                table: "Schedules",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsData_GroupId",
                table: "StudentsData",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsData_SpecializationId",
                table: "StudentsData",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsData_UserId",
                table: "StudentsData",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGroups_GroupId",
                table: "TeacherGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGroups_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Presences");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TeacherGroups");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "StudentsData");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
