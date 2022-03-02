using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PrescriptionProjectAssignment.Migrations
{
    public partial class TestData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Instructions = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Street = table.Column<string>(type: "text", nullable: true),
                    CityInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_CityInfos_CityInfoId",
                        column: x => x.CityInfoId,
                        principalTable: "CityInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientJournals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientJournals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientJournals_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pharmacies_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JournalLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LastAccess = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PatientJournalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalLogs_PatientJournals_PatientJournalId",
                        column: x => x.PatientJournalId,
                        principalTable: "PatientJournals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PatientJournalId = table.Column<int>(type: "integer", nullable: false),
                    MedicineId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_PatientJournals_PatientJournalId",
                        column: x => x.PatientJournalId,
                        principalTable: "PatientJournals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pharmaceuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    PharmacyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmaceuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pharmaceuts_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CityInfos",
                columns: new[] { "Id", "City", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Taastrup", "2630" },
                    { 2, "Nordhavn", "2100" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "lukas@ergrim.com", "Lukas", "Stoltz-Andersen", "+G1M5GvKwY7BqKJ5vGfJ3F3u6GzBbDM/Ni5CRq3eqwk=" },
                    { 2, "sumit@ergrim.com", "Sumit", "Sumit", "p9GbbCUoo6SIIrrF5zZ59ddp/epYkPoelGcHRHhQVx8=" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Amount", "ExpirationDate", "Instructions", "Name" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 3, 31, 16, 40, 0, 989, DateTimeKind.Local).AddTicks(8268), "Take one daily", "Aspirin" },
                    { 2, 2, new DateTime(2022, 3, 31, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(3004), "Take one daily", "Cialis" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "Patient1@ergrim.com", "Patient1", "Panda", "QbXqudtBjOXbB3n6SzxBX2KyN4sTVyVvGqD36XGcQsw=" },
                    { 2, "Patient2@ergrim.com", "Patient2", "Ko", "xs8g00J3WbV7jUkDzUtdaKWGJIxjNgqbbAwBQfpTQ68=" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityInfoId", "Street" },
                values: new object[,]
                {
                    { 1, 1, "Tornehegnet" },
                    { 2, 1, "Brunellevej" },
                    { 3, 2, "Ringkøbinggade" }
                });

            migrationBuilder.InsertData(
                table: "PatientJournals",
                columns: new[] { "Id", "PatientId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pharmacies",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Pharmacy Nordhavn" },
                    { 2, 2, "Pharmarcy Taastrup" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedAt", "DoctorId", "MedicineId", "Name", "PatientJournalId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 1, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(3599), 1, 1, null, 1 },
                    { 2, new DateTime(2022, 3, 1, 16, 40, 0, 991, DateTimeKind.Local).AddTicks(4196), 2, 2, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pharmaceuts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "PharmacyId" },
                values: new object[,]
                {
                    { 1, "phil@ergrim.com", "Phillip", "Andersen", "UffT7TwPrlyvLohiREVZsExOGf/Cgr7YX9FwiivE7yU=", 1 },
                    { 2, "seb@erflot.com", "Sebastian", "Hansen", "dWN5CBoKRyPPoWH8gmTbInvPTFiceOAgbizNheKgazQ=", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityInfoId",
                table: "Addresses",
                column: "CityInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalLogs_PatientJournalId",
                table: "JournalLogs",
                column: "PatientJournalId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientJournals_PatientId",
                table: "PatientJournals",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmaceuts_PharmacyId",
                table: "Pharmaceuts",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacies_AddressId",
                table: "Pharmacies",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicineId",
                table: "Prescriptions",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientJournalId",
                table: "Prescriptions",
                column: "PatientJournalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalLogs");

            migrationBuilder.DropTable(
                name: "Pharmaceuts");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "PatientJournals");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "CityInfos");
        }
    }
}
