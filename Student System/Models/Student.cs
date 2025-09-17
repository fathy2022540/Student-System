using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(100),Unicode(true)]
        public string Name { get; set; }

        [MaxLength(10),Unicode(false),]
        public string? PhoneNumber { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime RegisteredOn { get; set; }
        
        public int? Birthday { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Homework> Homework { get; set; }
    }
}
