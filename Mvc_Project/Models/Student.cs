using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Project.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Naam to bhr laadle")]
        public string Name { get; set; }
        [Range(20,30)]
        public int Age { get; set; }
        [Required(ErrorMessage ="Chl pta daaal apna 🔪🔪")]
        public string Address { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

    }
}