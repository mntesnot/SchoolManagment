namespace SchoolManagment.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Grade { get; set; }
        public string Status { get; set; }
    }
}
