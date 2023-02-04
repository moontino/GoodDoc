using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodDocBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentAndSymptomTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppointmentSlotId",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SymptomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentPatients",
                columns: table => new
                {
                    AppointmentSlotId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentPatients", x => new { x.AppointmentSlotId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_AppointmentPatients_Appointments_AppointmentSlotId",
                        column: x => x.AppointmentSlotId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentPatients_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentSlotId",
                table: "Doctors",
                column: "AppointmentSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentPatients_PatientId",
                table: "AppointmentPatients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SymptomId",
                table: "Appointments",
                column: "SymptomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Appointments_AppointmentSlotId",
                table: "Doctors",
                column: "AppointmentSlotId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Appointments_AppointmentSlotId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "AppointmentPatients");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AppointmentSlotId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentSlotId",
                table: "Doctors");
        }
    }
}
