using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class editAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "appointments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time",
                table: "appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                columns: new[] { "Date", "DoctorId", "PatientId", "Time" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "appointments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                columns: new[] { "Date", "DoctorId", "PatientId" });
        }
    }
}
