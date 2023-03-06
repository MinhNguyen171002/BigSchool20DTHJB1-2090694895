using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace WebApplication1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LectureID { get; set; }
        [Required]
        [StringLength(250)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public Category category { get; set; }
        [Required]
        public byte categoryID { get; set; }
    }
}