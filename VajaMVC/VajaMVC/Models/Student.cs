using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage="Ime je obvezno")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage = "Starost je obvezna")]
        [Range(18,50, ErrorMessage = "Ime je obvezno")]
        public int Age { get; set; }
    }
}