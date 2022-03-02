using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrescriptionProjectAssignment.Migrations
{
    public partial class TestData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "Password",
                value: "08fRnmfM1EF0vv1XadNjY9Lq3oXcMwkMAjTZxBPe9pE=");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "RNrTUetwFrZLMx51Hm6BW5h67udQrhKonQdv464EGjI=");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "igilO4o+YjhTZsNXoSvCP7VxzFSEV8GRVqysWsYyjoo=");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 1, 11, 3, 58, 385, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2022, 4, 1, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "8bMzVQEBgcuhpLGvRc0Dkm9iTU0dsqMWuVOPJrBj8sk=");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "exA65Jcj/uk66Fork2RONfMfriHx/b4Bep6sH1547aY=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "MRquQUi6vMwKXikV6V6ypugICs3iTidc6sFYkVWJEfY=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "a+Fb6sjnEbb0TD3zWFUldu3zaE2bNouFuiTeWaO7xck=");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(9426));
        }
    }
}
