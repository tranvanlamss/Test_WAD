using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test_WAD.Models
{
    public class ClassRoom
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Input ClassroomName")]
        public string Classroom { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}