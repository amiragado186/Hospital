using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    [PrimaryKey(nameof(Date),nameof(DoctorId),nameof(PatientId),nameof(Time))]
    public class Appointment
    {
        
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId {  get; set; }
        public Patient Patient { get; set; }
    }
}
