using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TeacherGroups",
                columns: new[] { "Id", "GroupId", "TeacherDataId" },
                values: new object[] { 3L, 3L, 3L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91bb6608-35e2-4fe7-8ee9-7b04595a8679", "AQAAAAEAACcQAAAAEMzfWDDgicie/czmPyvwniMPVMHtbsWGDlpOxUoOyshQbY2HX9k3oLUsetQJHNJD6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "983b2b38-9928-47ac-a79a-1cec35efc052", "AQAAAAEAACcQAAAAEBw+XGcgYRw131/iiGPMV2rgyNOtoB35OB36UtwQRuhy+mReSX8smo6Wl/B//BPC9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57752716-f768-4852-90ea-9d7596e8543c", "AQAAAAEAACcQAAAAEBw9tNdYEUmcYHDauhppYoQmCEmVnbRiBrv8jSjw+lehzJdRb501Vkn+pE3vCFVoTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78aaf13e-507e-49be-8808-a26eb796dce2", "AQAAAAEAACcQAAAAECA9SuNMGZGH4GUhoB5Vs5JhYBI+LaXkXPc15bJw6mpPMGjpMGKWVSQ1pLYx9ffNGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a8d9e7c-a861-4768-b87a-ed9c144c1a59", "AQAAAAEAACcQAAAAEAdvOz93Z9fMQOvYUT9yC00626yMS5xrTyHMXSNiXY6fh9CQs6fz+SO80k6vJcAaog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f88ce2aa-3ca6-48b9-99ec-e2a2972580ef", "AQAAAAEAACcQAAAAEJSdtZRd4Knx5Wvm+3Dcer2CsYeuY46CwPIAjRKWXZzjqJEmBT2d5Nz0qLzf2juQBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e169d72a-6178-4d24-aaf9-26bf1d94ea5b", "AQAAAAEAACcQAAAAEOBWVeO0E9f2eyQJ/XZm6otElVnFQEqwy65HDifaBmAaanFqco1LG9jdurhxmhG9Mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fe8c3be-dc5b-4a81-a6cd-46ac534e5006", "AQAAAAEAACcQAAAAEP7BBTajBMZc8HrGQHZjxUesPi9j9KbAKxDGgYOSO0i+IL27ItR7qzK5S9x7UOrcxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7533d188-30e3-440c-9636-043b081b408b", "AQAAAAEAACcQAAAAEJo8gQbk8i4P2B6VXzrG2G9uDxhgfr7UTkHbijlqrhQ7c8jl4DQTnU/NU5h5gpBiyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c931bff-8f48-4c67-b368-ad4226c3b54a", "AQAAAAEAACcQAAAAEJyRhZUxvPN7oBr7mz8RWE594GJRVc/HWkKD0YCKQ2TNWqOEWUo5ST0WKsGRjvTBKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca7c9786-c58a-4e88-9ff7-9a437ac8cbbb", "AQAAAAEAACcQAAAAEE0ueFGhJGpDGYcpHhY+4HUbyhGepm133brhrCNUGexc7nsrE99dQ6FQW7ev+qRL8g==" });
        }
    }
}
