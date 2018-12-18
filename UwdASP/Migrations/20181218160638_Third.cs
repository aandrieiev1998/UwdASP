using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UwdASP.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<long>(nullable: false),
                    Token = table.Column<string>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a176f94-b837-4627-b1b9-cf352ab5600d", "AQAAAAEAACcQAAAAEEGGdu26i/AjvIvRGHotOwTFOL9ApZUljB/y0Ti5SXh76biPfflOKcVuIry0EJy8+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78f29c30-6857-476a-b1ed-c680b9705001", "AQAAAAEAACcQAAAAEM6yhNmTRxVx8jAoZmEPa+5S5Dgpacey2Pcd3h8G7qflvluJempuVFjFcXQEN8ppMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a44aeb08-aa2d-47d7-889f-684aefc18ae7", "AQAAAAEAACcQAAAAEHHLxwLwmhKTzqhGxXqN+b8XiiQuBjeilzRBAp+6g5L654nf0VzSsZT2MWigeOTuhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "edb004c6-36ef-450e-821e-b0b165dfa2b8", "AQAAAAEAACcQAAAAEP/5o9JzbOWIMKgI4eFraCQkDsiqXALc+8WW2kCGuHEdmd+gBpvL61SDsVmlynUSkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c02240f-df15-4b24-b427-c90fbb236eec", "AQAAAAEAACcQAAAAELUCwbrVOV97MmTNQLSmnCckgDDznCRO1hzaoNRivlXZPo3V6oSwFO9jb5F9TxLruQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c35a2569-312b-4098-b327-bf53e001019b", "AQAAAAEAACcQAAAAEJHhbltBOF2AMCBxdLvyowGuOsuCxWs05yCGAXSpAOBJribUaiyMrFNLi5jjJ7MWXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5b4d043-1484-4369-8bcb-e3fc201d9c94", "AQAAAAEAACcQAAAAEJEEc68UddY2rUucNDDNx+Wy1FaKc9Z1WL4P28wCsnNGtoP6utn2ZHmf8kpqtWx2Jw==" });
        }
    }
}
