using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DataAccess
{
    public class ApplicationDbContext:DbContext

    {
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
