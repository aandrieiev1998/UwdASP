using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UwdASP.Migrations
{
    public partial class Nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookkeepings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Amount = table.Column<float>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BalanceAfterTransaction = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookkeepings", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookkeepings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f234dd4-cde6-4ae2-84f7-7da4b04bd5bc", "AQAAAAEAACcQAAAAEFddn9TkuNFk/hzjf2nvOtDCz3DAsiVB0HRdEs3/rs9AHmSVvtAxL71Naa5bAARWAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "849cff39-65bd-4f33-a865-fb7e53cb92ca", "AQAAAAEAACcQAAAAEDybxpy3m6aRo+tFYOMKmOIWVg1/auucroIT5jAaSExyyL41TQ2p4tPiI+HFX+KmKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a9cfa81-1f0e-444b-a137-db819883f9ba", "AQAAAAEAACcQAAAAECcW05HbEug8KeNRQS4xN2xFcQjQ3ZjTrKFROIz963iDY0mKQ+4OX3C+qbspKt8RQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2559daeb-c8a1-4c94-a62d-07ae0ba80aec", "AQAAAAEAACcQAAAAEKrdRj8fiDl/zXDz1zL60By4uxvO8X9kldjMhL4SK1+lb2PoLEpUxf9vhcUynxAEIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68570ba8-5c84-464e-b59e-637165cbd97a", "AQAAAAEAACcQAAAAEHt/WjvbDqYIe2R/HhvR3olOskKcXAICNyekmpCzxhBcgQwMZixxJWAUDNKmu71LyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41d614fe-47e2-4036-983d-d4c983006f67", "AQAAAAEAACcQAAAAEMDWOytPlLlKsDRos+lb8c9yJ1W2C84a3203HS3aUqwYc/+zitzK7pKg8Oj0QcoXiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a40b3858-122e-441d-b838-416bad701265", "AQAAAAEAACcQAAAAEIaRzwe5uPX0tFqvoO40UwQmCS+v29o7yMOmRss3Q85hlOUI8L810oOSRaEm/gnUJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17e88f29-aa65-4e3a-8bd0-0df455699ac0", "AQAAAAEAACcQAAAAEHZ3xTx11PqjuSATMQc3JjMjqx2vXY+AiLe8PZt48yRgX8gIdck1BsG/xbbTL4vESQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "544ac57c-45f5-4094-ae1b-c2448d8d0be4", "AQAAAAEAACcQAAAAEBnVwPCX5Jt/kK2idHKRCNMOAnyG9+K9NAx+tnEFLoyLp4TU5PVyoxUksSTQN7a2Kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "97d58530-6f72-4460-ac87-0c1e9c23e174", "AQAAAAEAACcQAAAAEP3AIrlgP9HZP9ce3mGA+jT659MFCdzK5yZaYCVVx5Hxw6urKBXfF0CgamXPh+z/aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17b33b20-6ee0-4974-939f-592f504d1efb", "AQAAAAEAACcQAAAAEGF8Nz04exASuWlPQFKOhJRzgeIDm7AyHLeLjz2O6jO1/cZhS0RT7WujsnvIg5ulVw==" });
        }
    }
}
