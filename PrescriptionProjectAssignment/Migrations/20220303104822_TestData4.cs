using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrescriptionProjectAssignment.Migrations
{
    public partial class TestData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "BEzXJkCVQsdWSEDvZZ8mnx6PhsSQgdzlNwdSMzTQuAw=");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "KZ1KzHOOHBhbzwB4lLVQjNs+/xXxGliyd5kszJL7sE0=");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 2, 11, 48, 22, 51, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 2, 11, 48, 22, 54, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { "lukasbangstoltz@gmail.com", "sHivySA9EJzKVHUJhmZe9KTqKwmv6+y+0tGlkbG0ctg=" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "VVZuEevhIVijUWenXEeGvPoiIHqGhBAPEx4hKO+HDr0=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "3p58ub2hfZcx51QRXQyghIbe/knRDlkGNoysKykiflg=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "cQFTkld3Bys/8nQ55guwCxiNX5xx2/bySJ7qBLntnjU=");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 3, 11, 48, 22, 54, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 3, 11, 48, 22, 54, DateTimeKind.Local).AddTicks(3498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "0TI2OdwraMLxjx2utKrna7Wt6pgfLSKVrFo6J+ScAUA=");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "ZAZCWCLIlOURvl3w2faWHBDJuF9vMY4Hn6fqhlYPPQg=");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 1, 11, 6, 38, 689, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 1, 11, 6, 38, 693, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password" },
                values: new object[] { "Patient1@ergrim.com", "08fRnmfM1EF0vv1XadNjY9Lq3oXcMwkMAjTZxBPe9pE=" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "XsfT/VXG+0cFrJ0+ddYDxXbMrVKD6Cfo6ZtLHFBq5cI=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "xA5yLzq2WOewZe/c3lKp6T+MOL5dTFKQTbWf3soGyzw=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "fUjz00cX3uDjF7iBzxwlRvVI73Zu8K2hHXHWY5q+shQ=");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 11, 6, 38, 693, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 11, 6, 38, 693, DateTimeKind.Local).AddTicks(2785));
        }
    }
}
