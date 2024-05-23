namespace SchoolManagment.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CHR { get; set; }
        public virtual ICollection<Registration>? Registrations { get; set; }
    }
}
