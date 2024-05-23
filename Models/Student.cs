namespace SchoolManagment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BOD { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department?    Department { get; set; }
        public virtual ICollection<Registration>? Registrations { get; set; }
        public string Status { get; set; }
    }
}
