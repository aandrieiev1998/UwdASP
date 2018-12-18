using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherId",
                table: "TeacherGroups");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "TeacherGroups",
                newName: "TeacherDataId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGroups_TeacherId",
                table: "TeacherGroups",
                newName: "IX_TeacherGroups_TeacherDataId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59dbff4b-ea42-4420-b1f7-5a252e71b9e6", "AQAAAAEAACcQAAAAEEljrrt+LqOnZP/mA92cNRvuDUGIXilMncZ3uOv/eEHkzRlKyWoibEE0jN2eSr88bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab7d2dc8-0c12-4241-884e-86be7287ed16", "AQAAAAEAACcQAAAAED4Q7mcwqSMJUAWCTPXZU4fDZkN1K0HkVifucmCV5kVhYU31ipiWRdnHdfdzzldTEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f059057-85f3-4891-94eb-4bc4225632f5", "AQAAAAEAACcQAAAAENDzkOxBuAohClFgOX1rQTE71yFT9LH3ECtIhR25q1SC2tqhutWmWwqOuPmZrb6kWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0abfd180-7c58-4b34-903e-6407a188d23a", "AQAAAAEAACcQAAAAEEoov+U1IgGlbcczs9kJwtwGQOo/UOCa54oGtCMuKEqHjZ4z18LVyW9Q9bAqOFIXXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93c6fb34-4bea-4a9f-a33f-937404e1ad6d", "AQAAAAEAACcQAAAAEGfwzFjnQvAM2vVZfCO4Cxgn9wra9xqOM8yLhaUwLQ2wDMAqUC7BwamWyGCDaTB1WA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d146540e-096e-4669-b486-55cb573dc752", "AQAAAAEAACcQAAAAEP3Pt0nrZEjh2RAoaF5XP7KaJM55hJ3nbI03A+EX9dKlVn8btEVcbUvV86ROg++t9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccf8f27e-946f-4462-8ed2-88ca286af079", "AQAAAAEAACcQAAAAEBZXM8+VoyEWv5JBpRuMh+ZAMdsjQl+khFZblT3v+94K4tbAVwwMFTbliILEZ4Nh5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "984aeb9a-d641-444b-bf38-7def7717c336", "AQAAAAEAACcQAAAAEIH3QXnGPoB05uwIQzjjhXF/bOXLozBU8V9EAqrjGEWx3mAdjp0WH188nTqo2W9qhQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79c21260-6dd4-4ada-872b-70248712beca", "AQAAAAEAACcQAAAAEML5VXDaeFuF89HJ1p7/qOpXJfrX/8MWQ55lBGSQfAkMFAzr2WCGCTfEATz1DpTFLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a055e74b-27db-4ec7-88e6-96bc244c6d9b", "AQAAAAEAACcQAAAAENfCUOLGjUHv1XZdLkluzVbpkGwJcfGW4BZffHiaqfxUiW6NiIUdWomKWKua7Efztg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e724c5c-e76f-4a24-be68-7b4f9a47d54c", "AQAAAAEAACcQAAAAEOSs4Xd1J9mjraeOjHugkuDwTeQNcwvuVrCv484dgBLdMDzGisqVPXGFrtafNH3onQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.RenameColumn(
                name: "TeacherDataId",
                table: "TeacherGroups",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGroups_TeacherDataId",
                table: "TeacherGroups",
                newName: "IX_TeacherGroups_TeacherId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherId",
                table: "TeacherGroups",
                column: "TeacherId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
