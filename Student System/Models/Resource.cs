using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [MaxLength(50), Unicode(true)]
        public string Name { get; set; }

        [Unicode(false)]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } 


    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
