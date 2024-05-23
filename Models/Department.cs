using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

        //[NotMapped]
        //public SelectListItem depList { get; set; }
    }
}
