using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrescriptionProjectAssignment.Migrations
{
    public partial class TestData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "yeLGPLOABLSIQ/aFHEjCPjKuyNuMQJUH4K+9LCY3QfE=");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "B3k1YrDkGP/wZPJ+lfFOuXuFIMXSfI4vm9zhimZjPjg=");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 2, 13, 50, 14, 358, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 2, 13, 50, 14, 360, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "XS9im50aMHuFO4aD02k3WZ7ompsRByvsQdhAeivkTgo=");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "phillip.andersen1999@gmail.com", "NgKirHYLzgL4dz+WwnHmCTLOreQ6rxR+90/y7zKXAic=" });

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "EcJ6waGTnXfzIo8hEUNNFerRzSsGNTFXAcEIEwH0GVE=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "9zcBGItxl1LI8EAQ4SFMNzBnnYBxz+Ce60p12Vn68Qc=");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 3, 13, 50, 14, 360, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 3, 13, 50, 14, 360, DateTimeKind.Local).AddTicks(9208));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Password",
                value: "sHivySA9EJzKVHUJhmZe9KTqKwmv6+y+0tGlkbG0ctg=");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "Patient2@ergrim.com", "VVZuEevhIVijUWenXEeGvPoiIHqGhBAPEx4hKO+HDr0=" });

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
    }
}
