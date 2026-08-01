namespace Hospital_Management_System.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Specialization { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();

        //public int page { get; set; } = 1;
    }
}
