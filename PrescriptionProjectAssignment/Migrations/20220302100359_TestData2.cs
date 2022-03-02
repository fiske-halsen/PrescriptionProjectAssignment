using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PrescriptionProjectAssignment.Migrations
{
    public partial class TestData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Pharmaceuts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Patients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Doctors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

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
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(8170), "Test" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(9426), "Test" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Doctor" },
                    { 2, "Pharmaceut" },
                    { 3, "Patient" }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "RNrTUetwFrZLMx51Hm6BW5h67udQrhKonQdv464EGjI=", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "igilO4o+YjhTZsNXoSvCP7VxzFSEV8GRVqysWsYyjoo=", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "8bMzVQEBgcuhpLGvRc0Dkm9iTU0dsqMWuVOPJrBj8sk=", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "exA65Jcj/uk66Fork2RONfMfriHx/b4Bep6sH1547aY=", 3 });

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "MRquQUi6vMwKXikV6V6ypugICs3iTidc6sFYkVWJEfY=", 2 });

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "RoleId" },
                values: new object[] { "a+Fb6sjnEbb0TD3zWFUldu3zaE2bNouFuiTeWaO7xck=", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Pharmaceuts_RoleId",
                table: "Pharmaceuts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoleId",
                table: "Patients",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_RoleId",
                table: "Doctors",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Role_RoleId",
                table: "Doctors",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Role_RoleId",
                table: "Patients",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmaceuts_Role_RoleId",
                table: "Pharmaceuts",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Role_RoleId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Role_RoleId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Pharmaceuts_Role_RoleId",
                table: "Pharmaceuts");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Pharmaceuts_RoleId",
                table: "Pharmaceuts");

            migrationBuilder.DropIndex(
                name: "IX_Patients_RoleId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_RoleId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Pharmaceuts");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "+G1M5GvKwY7BqKJ5vGfJ3F3u6GzBbDM/Ni5CRq3eqwk=");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "p9GbbCUoo6SIIrrF5zZ59ddp/epYkPoelGcHRHhQVx8=");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2022, 3, 31, 16, 40, 0, 989, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2022, 3, 31, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "QbXqudtBjOXbB3n6SzxBX2KyN4sTVyVvGqD36XGcQsw=");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "xs8g00J3WbV7jUkDzUtdaKWGJIxjNgqbbAwBQfpTQ68=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "UffT7TwPrlyvLohiREVZsExOGf/Cgr7YX9FwiivE7yU=");

            migrationBuilder.UpdateData(
                table: "Pharmaceuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "dWN5CBoKRyPPoWH8gmTbInvPTFiceOAgbizNheKgazQ=");

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 3, 1, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(3599), null });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 3, 1, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(4196), null });
        }
    }
}
