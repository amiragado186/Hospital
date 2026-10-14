namespace Hospital.ViewModels
{
    public class FilterVM
    {
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public int Page { get; set; } = 1;
    }
}
