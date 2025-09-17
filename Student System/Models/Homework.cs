using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    internal class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

      
        [Required,Unicode(false)]
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } 
        public int CourseId { get; init; }
        public Course Course { get; set; }


    }
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
}
