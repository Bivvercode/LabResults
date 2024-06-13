using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabResultsExercise.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabResults",
                columns: table => new
                {
                    Barcode = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClinicNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    CollectionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CollectionTime = table.Column<string>(type: "TEXT", nullable: false),
                    TestCode = table.Column<string>(type: "TEXT", nullable: false),
                    TestName = table.Column<string>(type: "TEXT", nullable: false),
                    Result = table.Column<string>(type: "TEXT", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: true),
                    ReferenceRangeLow = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReferenceRangeHigh = table.Column<decimal>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    NonSpecificReferences = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabResults", x => x.Barcode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabResults");
        }
    }
}
