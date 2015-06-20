using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyCourses.Models
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }

        
        [Required]
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        [InverseProperty("Courses")]
        public virtual ApplicationUser Student { get; set; }
        
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        [InverseProperty("Users")]
        public virtual Course Course { get; set; }

        public int Grade { get; set; }
    }
}