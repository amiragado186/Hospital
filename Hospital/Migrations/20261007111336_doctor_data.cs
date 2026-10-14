using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class doctor_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctors (Name, Specialization) values ('Ali Ahmed', 'Oncology'); insert into Doctors (Name, Specialization) values ('Mohammed Eid', 'Cardiology'); insert into Doctors (Name, Specialization) values ('Ahmed Hassan', 'Orthopedics'); insert into Doctors (Name, Specialization) values ('Omar Ali', 'Cardiology'); insert into Doctors (Name, Specialization) values ('Ahmed Hassan', 'Orthopedics'); insert into Doctors (Name, Specialization) values ('Omar Ali', 'Oncology'); ");
            migrationBuilder.Sql("insert into Doctors (ImgUrl) values ('doctor1.jpg'); insert into Doctors (ImgUrl) values ('doctor2.jpg'); insert into Doctors (ImgUrl) values ('doctor3.jpg'); insert into Doctors (ImgUrl) values ('doctor4.jpg'); insert into Doctors (ImgUrl) values ('doctor5.jpg'); insert into Doctors (ImgUrl) values ('doctor6.jpg'); ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Doctors");
        }
    }
}
