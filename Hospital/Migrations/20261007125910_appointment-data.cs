using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class appointmentdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into appointments (Date, DoctorId, PatientId) values ('2027-08-30 12:00:00', 1, 4); insert into appointments (Date, DoctorId, PatientId) values ('2027-10-24 21:00:00', 1, 7); insert into appointments (Date, DoctorId, PatientId) values ('2025-08-11 04:00:00', 5, 8); insert into appointments (Date, DoctorId, PatientId) values ('2026-04-11 10:00:00', 3, 10); insert into appointments (Date, DoctorId, PatientId) values ('2027-12-24 16:00:00', 6, 6); insert into appointments (Date, DoctorId, PatientId) values ('2025-12-07 18:00:00', 6, 12); insert into appointments (Date, DoctorId, PatientId) values ('2026-09-29 21:00:00', 6, 7); insert into appointments (Date, DoctorId, PatientId) values ('2025-10-04 02:00:00', 1, 4); insert into appointments (Date, DoctorId, PatientId) values ('2025-12-29 11:00:00', 1, 9); insert into appointments (Date, DoctorId, PatientId) values ('2026-02-07 18:00:00', 2, 6); insert into appointments (Date, DoctorId, PatientId) values ('2026-12-22 20:00:00', 1, 8); insert into appointments (Date, DoctorId, PatientId) values ('2027-03-09 14:00:00', 4, 6); ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from appointments");
        }
    }
}
