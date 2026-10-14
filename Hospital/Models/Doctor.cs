namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization {  get; set; }
        public string ImgUrl{get; set; }
        public ICollection<Appointment> appointments { get; set; } = new List<Appointment>();
    }
}
