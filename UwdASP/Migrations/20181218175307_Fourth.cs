using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Teachers_TeacherDataId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_Teachers_TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "TeachersData");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_UserId",
                table: "TeachersData",
                newName: "IX_TeachersData_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeachersData",
                table: "TeachersData",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_TeachersData_TeacherDataId",
                table: "Marks",
                column: "TeacherDataId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId",
                principalTable: "TeachersData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersData_AspNetUsers_UserId",
                table: "TeachersData",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_TeachersData_TeacherDataId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroups_TeachersData_TeacherDataId",
                table: "TeacherGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersData_AspNetUsers_UserId",
                table: "TeachersData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeachersData",
                table: "TeachersData");

            migrationBuilder.RenameTable(
                name: "TeachersData",
                newName: "Teachers");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersData_UserId",
                table: "Teachers",
                newName: "IX_Teachers_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7149631-6c98-420f-a7b8-c75dd8657a57", "AQAAAAEAACcQAAAAEBAfFVE7j/j3wme/uiRpTyFXiZEIWpT+hy46TEIW7c7WsS550oVrgwp5UNL9yBVo1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb05fcc5-4640-43c2-a7f7-c446113d2394", "AQAAAAEAACcQAAAAEChlpLzBHPOyYF61325iv6P3g/CfMNpmVwBIF9XuG8gyIQObW9k4YWkBBWPhfTtR5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "783c066a-0c7f-4c4b-8965-1a71617b0811", "AQAAAAEAACcQAAAAEKlqJf5oVP5DGGmN7Q1+9KQs5v3wMo1W9X+4SZ22U7g9BSBDZ0p5dnj9RLroOa8LlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f18b3d8-80bf-4961-a332-48cfedab3164", "AQAAAAEAACcQAAAAEKOBdHJmduYVBh8nq0rh/Z5RJ5SSI4rgAhluZN22i09rCMnqFiSSPvGR++FThePdVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "954b87bd-f24b-4317-a2f3-2750a11229d0", "AQAAAAEAACcQAAAAEPcBBQqkASkc5fsWV/4uSpVwVspSpT4J9uPlvZIs7Nn8+v+6vmrvjw7sVbeNP5AU/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7826c0ca-2920-4255-a040-c119df6e8bfd", "AQAAAAEAACcQAAAAEL12dp83DRNoRSSCySnjTxzaf7DWkhixk4pavuueuh2ldH2ME6nntJdPssebKN5uDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23b0c9cb-4aef-4abd-8702-6182cbc4632e", "AQAAAAEAACcQAAAAEEJIGnW711vSEU6JsRSENnxARBpBRfd27v/DrMKo+8LfpgdLY1Q2wrrE9nhNaUCPFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04066f21-8d64-4fb0-9837-50eba596e807", "AQAAAAEAACcQAAAAENC/bGAyAizOPwJ9nfxOEFXE8/TCGTON/6a73iwd13SW6xxSM+h0+F13jbfJYn/mLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c32c664b-1f73-4751-8751-d6483f000460", "AQAAAAEAACcQAAAAEGS+j/lftHnvo5AkgL7kc+vg2LSftea6jldV/mbq0SWLgjJnyPI3Qbq7PCHGAhEHdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4dcd843b-67a6-4b9b-b141-aa12f1091da1", "AQAAAAEAACcQAAAAENBWcTq2zgCia6EXzogzoUv4FZzKAKPlB69iVptFqUl02UhK/6YyQpl3VjO26MD5Ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5df8590-87e7-4727-b478-00f6a3092106", "AQAAAAEAACcQAAAAENBoJITJCEicMYs8DbVCTpfNco8n/4kFRyIa8qpuGemkLYq1pTvvl7AxT7fgw9KkWw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Teachers_TeacherDataId",
                table: "Marks",
                column: "TeacherDataId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroups_Teachers_TeacherDataId",
                table: "TeacherGroups",
                column: "TeacherDataId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
