using SchoolManagment.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.ViewModels
{
    public class Ceritifcs
    {
        [Required]
        public int SerachId { get; set; } 
        public Student? Student { get; set; }
        public List<Registration>? Registration { get; set; }
    }
}
