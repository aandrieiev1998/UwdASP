using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a19a142c-9189-4eb0-a913-1b12a6db2960", "AQAAAAEAACcQAAAAEOOpPswo6zXXiFDEMwQspnDww6Snr9zfpos1vhE4/G3pIC+n5oju8r0QZmPaRG8NIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c620f2a-3497-4bfc-ad7f-51a48d192929", "AQAAAAEAACcQAAAAEOfJh3OtkYh+/HYBMVe7dTvAfd6Z0Sb0WauQGf398R0Y15m2Ug2/u2yZW6DpGYNDzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0aa62eb9-a7b3-4b0a-a2ae-258a3d0ce3a7", "AQAAAAEAACcQAAAAEHFUDzwelRuLSbRdr7tUHEO8foPCziKbpLKcjybCbMq1zUL8VB0arh1Ec6GwAQ3vMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf6f2d7a-69c3-447d-9b26-f226b2b96b9b", "AQAAAAEAACcQAAAAEAlNggkL1SdpH69qfJ17Aj9FER2O+nU5K02G8gXptvqD4uX0WhAz5UrnfbThgeSYOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "6a176f94-b837-4627-b1b9-cf352ab5600d", "mkowalska@gmail.com", "Matylda", "Kowalska", "MKOWALSKA@GMAIL.COM", "MKOWALSKA", "AQAAAAEAACcQAAAAEEGGdu26i/AjvIvRGHotOwTFOL9ApZUljB/y0Ti5SXh76biPfflOKcVuIry0EJy8+w==", "+48656534642", "mkowalska", "Student" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "78f29c30-6857-476a-b1ed-c680b9705001", "awawrzyniak@gmail.com", "Antonina", "Wawrzyniak", "AWAWRZYNIAK@GMAIL.COM", "AWAWRZYNIAK", "AQAAAAEAACcQAAAAEM6yhNmTRxVx8jAoZmEPa+5S5Dgpacey2Pcd3h8G7qflvluJempuVFjFcXQEN8ppMw==", "+4865653464", "awawrzyniak", "Student" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "a44aeb08-aa2d-47d7-889f-684aefc18ae7", "skarpiński@gmail.com", "Szymon", "Karpiński", "SKARPIŃSKI@GMAIL.COM", "SKARPIŃSKI", "AQAAAAEAACcQAAAAEHHLxwLwmhKTzqhGxXqN+b8XiiQuBjeilzRBAp+6g5L654nf0VzSsZT2MWigeOTuhA==", "+4865653465", "skarpiński", "Student" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { 9L, 0, "7c02240f-df15-4b24-b427-c90fbb236eec", "krychlicki@gmail.com", false, "Kicior", "Rychlicki", false, null, "KRYCHLICKI@GMAIL.COM", "KRYCHLICKI", "AQAAAAEAACcQAAAAELUCwbrVOV97MmTNQLSmnCckgDDznCRO1hzaoNRivlXZPo3V6oSwFO9jb5F9TxLruQ==", "+486546546542", false, null, false, "krychlicki", "Teacher" },
                    { 8L, 0, "edb004c6-36ef-450e-821e-b0b165dfa2b8", "kpawłowska@gmail.com", false, "Kinga", "Pawłowska", false, null, "KPAWŁOWSKA@GMAIL.COM", "KPAWŁOWSKA", "AQAAAAEAACcQAAAAEP/5o9JzbOWIMKgI4eFraCQkDsiqXALc+8WW2kCGuHEdmd+gBpvL61SDsVmlynUSkg==", "+4865653466", false, null, false, "kpawłowska", "Student" },
                    { 11L, 0, "a5b4d043-1484-4369-8bcb-e3fc201d9c94", "mkacperski@gmail.com", false, "Maciej", "Kacperski", false, null, "MKACPERSKI@GMAIL.COM", "MKACPERSKI", "AQAAAAEAACcQAAAAEJEEc68UddY2rUucNDDNx+Wy1FaKc9Z1WL4P28wCsnNGtoP6utn2ZHmf8kpqtWx2Jw==", "+489541543785", false, null, false, "mkacperski", "Teacher" },
                    { 10L, 0, "c35a2569-312b-4098-b327-bf53e001019b", "aniewiamodmski@gmail.com", false, "Adam", "Niewiamodmski", false, null, "ANIEWIADOMSKI@GMAIL.COM", "ANIEWIADOMSKI", "AQAAAAEAACcQAAAAEJHhbltBOF2AMCBxdLvyowGuOsuCxWs05yCGAXSpAOBJribUaiyMrFNLi5jjJ7MWXw==", "+486542546443", false, null, false, "aniewiamodmski", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "Semester" },
                values: new object[,]
                {
                    { 5L, "Programowanie", 4 },
                    { 4L, "Programowanie", 5 },
                    { 3L, "Programowanie", 6 }
                });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TeacherDataId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "Comment", "Date", "LessonId", "MarkType", "StudentDataId", "TeacherDataId", "Value" },
                values: new object[,]
                {
                    { 7L, "No niestety", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 9, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 8L, "Regular", 3L, 3L, 3f },
                    { 6L, "Idealnie", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 9, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 5L, "Regular", 2L, 3L, 5f }
                });

            migrationBuilder.UpdateData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 2L,
                column: "GroupId",
                value: 2L);

            migrationBuilder.InsertData(
                table: "StudentsData",
                columns: new[] { "Id", "Balance", "BankAccountNumber", "GroupId", "Index", "Semester", "SpecializationId", "StudyBeginningDate", "StudyType", "UserId" },
                values: new object[] { 7L, 2400f, 123456789, 1L, 29287, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 7L });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "Comment", "Date", "LessonId", "MarkType", "StudentDataId", "TeacherDataId", "Value" },
                values: new object[] { 5L, "Idealnie", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 9, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 3L, "Regular", 7L, 3L, 5f });

            migrationBuilder.UpdateData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 4L,
                column: "GroupId",
                value: 3L);

            migrationBuilder.InsertData(
                table: "StudentsData",
                columns: new[] { "Id", "Balance", "BankAccountNumber", "GroupId", "Index", "Semester", "SpecializationId", "StudyBeginningDate", "StudyType", "UserId" },
                values: new object[,]
                {
                    { 5L, 1337f, 123456789, 3L, 29285, 7, 2L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 5L },
                    { 6L, 9999f, 123456789, 4L, 29286, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 6L },
                    { 8L, 5000f, 123456789, 1L, 29288, 7, 1L, new DateTime(2015, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stationary", 8L }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UserId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UserId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UserId",
                value: 11L);

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "Comment", "Date", "LessonId", "MarkType", "StudentDataId", "TeacherDataId", "Value" },
                values: new object[,]
                {
                    { 4L, "Wystarczy", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 9, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 5L, "Regular", 6L, 3L, 3.5f },
                    { 8L, "Idealnie", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 9, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 6L, "Regular", 6L, 2L, 5f },
                    { 3L, "Elegancko", new DateTimeOffset(new DateTime(2018, 11, 10, 13, 5, 2, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 3L, "Regular", 8L, 2L, 4.5f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a4feb01-d3e9-4946-b06e-e9bde9a69c69", "AQAAAAEAACcQAAAAEH5tGQxoUEBR2nq9k62PycCSMmyenJMrTkafB8upla0ILEoOSlO+X3bGBVN4hdf3wQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "308aac2a-e14c-4c7a-8ebc-4e64c5c0a304", "AQAAAAEAACcQAAAAEHucvZuEKuK2vFIPngmc/7DYm2F7aK9PtTTC1sweRXQa7oVR8Cpis7AnCyP1p/Jjtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "51174aeb-4746-4efb-8ca5-6349e0dfebde", "AQAAAAEAACcQAAAAEMOXpi61fXOutj7G7c5aSLmzm/ovp0KUyAt76uGkdByFf19FHlkXiAhSwiT+hHZrng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0986510c-673b-4351-8579-8e12eaa2ca46", "AQAAAAEAACcQAAAAEBzxWjbAXQX/+wumPhCkcmkUJjrTVOLiW1tTdsIImmZxX0+tH/fibGrp0yqdW/DGNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "44c9df02-1ba2-46dc-8bc0-51ac1accfcd7", "krychlicki@gmail.com", "Kicior", "Rychlicki", "KRYCHLICKI@GMAIL.COM", "KRYCHLICKI", "AQAAAAEAACcQAAAAEMCwHTknufNkxSPgUxnmRtdNR8ei+wf0xKELSkjn6is3CpuPQJ4G2HwOLmrFn4+grQ==", "+486546546542", "krychlicki", "Teacher" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "351a1aa8-078f-4d24-bd55-250cd7833f63", "aniewiamodmski@gmail.com", "Adam", "Niewiamodmski", "ANIEWIADOMSKI@GMAIL.COM", "ANIEWIADOMSKI", "AQAAAAEAACcQAAAAECKucyNLnabqWmTdzxqiKb6UGLGtrxr/OKwlKoTCrL9/h975hpPNWp4OTbNipcC7Wg==", "+486542546443", "aniewiamodmski", "Teacher" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "UserName", "UserType" },
                values: new object[] { "dfddd781-c307-4409-aba4-2d5f92643cc2", "mkacperski@gmail.com", "Maciej", "Kacperski", "MKACPERSKI@GMAIL.COM", "MKACPERSKI", "AQAAAAEAACcQAAAAEEuO86l3DkIwJOy+XuYCZxOsKLUCAQx/Ov5Mgqq54ohl7ZjFJtJUDUFp8p69XkJKgw==", "+489541543785", "mkacperski", "Teacher" });

            migrationBuilder.UpdateData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TeacherDataId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 2L,
                column: "GroupId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "StudentsData",
                keyColumn: "Id",
                keyValue: 4L,
                column: "GroupId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UserId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UserId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UserId",
                value: 7L);
        }
    }
}
