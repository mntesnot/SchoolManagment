using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagment.Models;

namespace SchoolManagment.ViewModels
{
    public class RegistratioCreatecs
    {
        public Student student { get; set; }
        public Course Course { get; set; }
        public Registration Registration { get; set; }

        public SelectListItem StuList { get; set; }
        public SelectListItem CouList { get; set; }

    }
}
