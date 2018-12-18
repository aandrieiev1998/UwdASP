using Microsoft.EntityFrameworkCore.Migrations;

namespace UwdASP.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TeacherGroups",
                columns: new[] { "Id", "GroupId", "TeacherDataId" },
                values: new object[,]
                {
                    { 1L, 1L, 3L },
                    { 2L, 2L, 1L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeacherGroups",
                keyColumn: "Id",
                keyValue: 2L);

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
        }
    }
}
