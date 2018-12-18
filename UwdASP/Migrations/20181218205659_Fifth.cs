using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.DropIndex(
                name: "IX_TeacherGroups_TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.DropColumn(
                name: "TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c2ac8fa-ae8f-4f02-ac33-59d3ea5d33e0", "AQAAAAEAACcQAAAAEK7UmAPyw6WKvjIzc30HWHEOdAXCH+TtFkE/W2scLnYlX9PNLl9kmdXKfaAuRQbijA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9220686a-f8c8-4a44-ac95-0dd8cd393e2a", "AQAAAAEAACcQAAAAEEWfocn0p/O+y3rU0eN9jHRB8FiJqyMwiIpnzTT4SEuaklIUGwrpICH1rpeKi2WDGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ee7a13c-62e1-4914-a100-dd2c29bcb3fb", "AQAAAAEAACcQAAAAELbMS2pDrk4tfYCyBf4c/LcSxKlV9II4szxD+5FKfesgjO1NQpLf2i7GXw7BITjVog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "781f6834-6102-42f2-bbc1-d193940db67c", "AQAAAAEAACcQAAAAEPoKY1vhf6Xo0M6RFcFeen+F4/9UUrAeMy8+F7qLMIebyuJZ5cq8dGqHlPgqjnrWdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd1b4055-c1ff-43a9-bb36-c2816262aebb", "AQAAAAEAACcQAAAAEKNymvgRAj/3SuRzHjzAvglwhHUQX+8+0Hg9qaRooO8dHz9ZnhPwwOZb8FSjC2ZmNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcf924ab-de9c-4d64-8f0c-aa893918250e", "AQAAAAEAACcQAAAAEBFMRpNMPwMqI3Pn1OVxHm9UduRuQWFEz0vpISZvuxeJIWDhczHBSL0BYnSqxPANww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64283055-4ab6-489d-9359-19ea82456746", "AQAAAAEAACcQAAAAEPMmVpqwyU/HHRPuGwH10weaHynhv8rbEFkjjBYpICLLsdR12Yta/xFWQVokmWgJzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5da1dc93-7ff3-4642-856c-18c9942c7443", "AQAAAAEAACcQAAAAEOMZMcVESw7cqfOcdX3e6CNne353ZtXQ3wnd5E1qoAcYLJdK2bQ3QqvyJjtzjMRFjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a56bb00-6874-45fe-9c46-c1ac63bc03f5", "AQAAAAEAACcQAAAAECiJJF3EV7uApyD+vNQqa19H/NO4AypeWgPhhZ8Dr7rhRG81BVpBivscv40lP/yD+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08b77429-d323-4395-8567-81cfb13df9cc", "AQAAAAEAACcQAAAAEJWFAJcalAC77yDjNL/HjFgLClNwiRaKo7IpLc9uy2ha7/JxdyLvGZ7bsS0N+5SgrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87ec936c-eeac-40fc-bda4-5b10e1e524de", "AQAAAAEAACcQAAAAEBjJXmTXgtOeO7Vvdt6NW5cSrKjTZLRNyUqlWxowC90nPdsor6S9IUB2RKpUcsqBug==" });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGroups_TeacherId",
                table: "TeacherGroups",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherId",
                table: "TeacherGroups",
                column: "TeacherId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherId",
                table: "TeacherGroups");

            migrationBuilder.DropIndex(
                name: "IX_TeacherGroups_TeacherId",
                table: "TeacherGroups");

            migrationBuilder.AddColumn<long>(
                name: "TeacherDataId",
                table: "TeacherGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b3a12eb-b0da-4008-b9e0-f827365d6d3c", "AQAAAAEAACcQAAAAEOpO4PBx9ow9ZDDsT3xVOYg2svRsVj/G8njElwYbLCJL4d6ax1nPhWn1Fi+hyLk+8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d74f074-6398-46bb-a09b-1fb07146bfd7", "AQAAAAEAACcQAAAAEBJqssx1OLrb4/4gBq1kjxtZH8/Mbq+a50Q1bo82v+RJVMu0XCmtptEVuBjQLInS1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f41279d-7cea-4199-825e-6f3d2beefa7e", "AQAAAAEAACcQAAAAEA+pPyof5AZJYRaIIP9QCf0/oaDzbD0jRYD98+uhGPdRC0eHgwP14Fyk3A8IzoUUXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0810ee0-dabc-40f0-a609-203db36bc0ec", "AQAAAAEAACcQAAAAEEwb4zIKv9v8zmkUtIPAZBxxWzRyQ2CG2foLQaegJfCKj/4p78St5fXKdEL3F/8Qvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ef1444a-9383-457a-8b69-46d8a13d950b", "AQAAAAEAACcQAAAAEBCDl6/9gYRwbs/xDJNod467V1h47bNRJdMcivS/FPfS2nDaBvChacEDlgtdE9Mznw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af7295a5-33a6-4913-b881-2d349bc53685", "AQAAAAEAACcQAAAAED+6LeXJgHhy4ezLDQ6fDljZpik/t9RH+PIpXtYU6ioVGZCV1Zkh6gtXnN1h4748cA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fba4230f-392e-4a96-9c97-8e3aa09db071", "AQAAAAEAACcQAAAAED5QxlorT6nwPg5VMVnr4JaY0tqx5YieZmOckrEFxu8eouRZS0GfQkDoEGhBZY1wAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ee1e9f2-f322-4da4-9c8e-60b39c3d8af8", "AQAAAAEAACcQAAAAELVdJH71v/ijJ+hqkL6/O1xzRpn0FxspYpmngqZ7TxNtJ7wYIN4V89ylDnSS2EPo+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3dfdb4b-257f-4859-95d4-485ed49b54da", "AQAAAAEAACcQAAAAELw4SQ5qym6oFyAuJdykbMBFVu2z+g5OOOr41Gcjwtd6sK+DPHUO0gbrAwoEjqqfgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8e0875b-8443-4a08-9817-e5ddf83495f4", "AQAAAAEAACcQAAAAELcvC1gGDMxQbUiQzspAL0L+cYinfvV2B/r60EVhf041tklmdO22NqcxmqN19cXWAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d13400a-5268-4ed9-8044-48b1d3ff1dcb", "AQAAAAEAACcQAAAAEODAMTTM8PsEGHaEArSJUvAw+CJ0Irzz93Ywy3/Gq6SNh+Czy0klQD5PsMF7S0BdPQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGroups_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
