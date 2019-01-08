using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "StudentDataId",
                table: "Bookkeepings",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5dd92276-d6ce-48a3-bbc2-b317868bdafa", "AQAAAAEAACcQAAAAEO906CT2VkfXXxXwHbRBaydV8tlbx3vpFRlmoIxQT/SoPn1BYewzRQc5bT3osytOAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0574dd66-f508-47a9-9376-572332c628d3", "AQAAAAEAACcQAAAAEM9F7dNioo9oE5OjN6Z4WGN2A8WIrOH4KpIEKoR52pMJuZi3h4PdgmJa5OpX9XI4Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc3bfa53-252a-4d9f-9a3c-1c8e876d6140", "AQAAAAEAACcQAAAAEHbEiBPEyX6tNC23aiFCJLRIwsp8xH825NU4iGu8UmeLzk29ctsrISuwjpcEUAGOzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1df31fc-e131-4165-a991-99c041c35d32", "AQAAAAEAACcQAAAAEL01sYRqSYt4IerYmtfzrfdftlOnoq9P5XbYqvGYQvjkryn/0dsr1DY+MdSTKii7lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f19ba912-c2e0-4998-893d-6a06dc079105", "AQAAAAEAACcQAAAAECdWYPSNM3fJR9MEYV0LPBUJVy7XiDAAYDj93jjU0+Ht68chD/9+SEgkyczaPJUtrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a33296a-8fac-4c07-9ae6-b549feab8596", "AQAAAAEAACcQAAAAEM/pEpx6TpDKaINNfwWpT2y69v3Lp50z3E1xUV9gD3KR5+XUPVBiUoQbcXUrcDOH5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "197e2c73-15c5-4ec9-8bae-55636ddf2321", "AQAAAAEAACcQAAAAEFtYGJoKWZeUhV3BocVdgXY7srCETvdqwHataBcJsW+zALoKCCPtnLUwXPTZD+j3Xg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fd3d0fb-2667-4ce9-ba61-8e4863d06758", "AQAAAAEAACcQAAAAEBskC6QsahUncnWTxUkkxYlih7GS4toK/XXF1u6N5m7LhvcKs3AyIW+FOfPnP231MA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d87456cc-560a-44fd-b6af-e19327072284", "AQAAAAEAACcQAAAAEEMwAVJRnhFa410w2zdF1v5bf+NBf6kjADgY0PZM+sNdtydjkRGJIcmXXieUl19aDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fe16665-5690-4bf8-ac4c-6bca99201374", "AQAAAAEAACcQAAAAEGbDczBbfZzPXgW29FIdDPlgOQZ56CnIedl4k+3gNeZUyM04YzDwzzEywS9d5uxZcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58a6aaee-afa3-4de2-9be4-b3a83bb10364", "AQAAAAEAACcQAAAAEHHoDVO/Tf8Z8VDwPvBK3igTG+XoplS2IkwxyoN4FJ4/QC0qzUH8NVpBu3l8O0tuxg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookkeepings_StudentDataId",
                table: "Bookkeepings",
                column: "StudentDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookkeepings_StudentsData_StudentDataId",
                table: "Bookkeepings",
                column: "StudentDataId",
                principalTable: "StudentsData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookkeepings_StudentsData_StudentDataId",
                table: "Bookkeepings");

            migrationBuilder.DropIndex(
                name: "IX_Bookkeepings_StudentDataId",
                table: "Bookkeepings");

            migrationBuilder.DropColumn(
                name: "StudentDataId",
                table: "Bookkeepings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "664b507a-ab6f-453d-bf79-9d2efb2b7294", "AQAAAAEAACcQAAAAEH3y8G9q1l8Efn1aP5/87nlC5uaVehoE5JsgwCGzzcayInYLfuIiXUHKlwmja6RGfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2aa33985-d052-41d4-bf67-71afd966adb2", "AQAAAAEAACcQAAAAENTWqGqzszpSEeYZfd2PQqCQ2uzqRTAeMI+77sA0RNrbqytGHboepwuFG41bsC86aA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15d0a9a1-04da-46c8-a965-308722281f57", "AQAAAAEAACcQAAAAEBkEPecILn37yKU3f/BYRd+936IWLQC2jT6Oep3XwcauQyhAdO9/EFei+G1mDyBFKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fdb1749-fe25-470b-89a0-c929acecba56", "AQAAAAEAACcQAAAAEDRQykTEA5ukxvkRKoPzi2lurbv/0jb6pdfdFMlA2zwEgm1V7c60T0kwicKOgWQyUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c668cb5-8192-42bc-9d1e-64824535ffbd", "AQAAAAEAACcQAAAAEKS1Y8RX5T6kf6Fm368RwIL+TVjFS0O/wgcN/CVMQ1lY98/TxHyrXl1rd526AeM4/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4486a93b-171d-42a7-b11e-440f7a9c98f2", "AQAAAAEAACcQAAAAEMvI8KirFYgV7uCyjrvf8wUIgEVXbaOSuT8EiS3969ODz/wOftyH6HgRBpIQnfXRHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff125f86-f272-4798-ab21-2ec372387686", "AQAAAAEAACcQAAAAEBdP4rE1Lq0EPl5ajEu7fuKDP0s9tCGOPNEm/H1yirFH8rF4pPZz3Cay/lnZJ8/wvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bea1ebe2-35d9-4a10-baa3-58f9fe5d4453", "AQAAAAEAACcQAAAAEMvREZAznse1zFke3Js/AN7jrFOXLnEE5037dc2J7p3fPAD55oaE5u9QEx4mKcG3hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3c4e540-2c07-4ce1-bb66-415f2a92aa52", "AQAAAAEAACcQAAAAEEoDkefTbDP6lqp6ljsK4MKORF4GZLkTSn1NzX4/zV2PiWhRHcvysyQ7kPdTB+nPWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "751345bf-3977-40e7-91c0-1fe2ebfb16c1", "AQAAAAEAACcQAAAAEIeODvRBd3j6+Wfk7UW+bN9WptX3yMsXU0EHzN9N6HjSt6UlsvQj+oJAi1mFT8yKEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96f3168b-ea1f-4803-861c-da572d68fc96", "AQAAAAEAACcQAAAAENGqXzeKVM5Y9QVUPuuKgFtxsvNxJbnT9rTKpCtitOPKHLb2XqvyzUL/tS4T1wCafQ==" });
        }
    }
}
