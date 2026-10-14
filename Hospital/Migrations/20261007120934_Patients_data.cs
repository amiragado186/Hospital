using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class Patients_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Patients (Name, DateofBirth, Gender) values ('Amira Atef', '11/8/2024', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Omar Ibraheem', '1/21/1952', 'M'); insert into Patients (Name, DateofBirth, Gender) values ('Ali Amar', '1/9/1983', 'M'); insert into Patients (Name, DateofBirth, Gender) values ('Ghaidaa mohamed', '12/1/1996', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Aseel Gado', '6/27/2002', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Omran Omara', '1/26/1989', 'M'); insert into Patients (Name, DateofBirth, Gender) values ('Hussein Ali', '6/21/1986', 'M'); insert into Patients (Name, DateofBirth, Gender) values ('Farida Abosereaa', '10/9/2005', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Ola Bahy', '7/7/1992', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Bahy Ahmed', '3/4/1973', 'M'); insert into Patients (Name, DateofBirth, Gender) values ('Mena Ahmed', '9/21/1965', 'F'); insert into Patients (Name, DateofBirth, Gender) values ('Aml Barakat', '5/7/1955', 'F'); ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Patients");
        }
    }
}
