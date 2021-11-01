using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test_WAD.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int ExamSubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        [Required(ErrorMessage = "Enter the issued date.")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Enter the issued date.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int ExamDration { get; set; }
        public int ClassRoomID { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public int FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public string Status { get; set; }
        
    }
}