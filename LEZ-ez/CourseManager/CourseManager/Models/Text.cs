using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class Text
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
    }
}