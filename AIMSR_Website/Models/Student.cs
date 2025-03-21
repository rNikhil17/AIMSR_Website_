﻿using System.ComponentModel.DataAnnotations;

namespace AIMSR_Website.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Course { get; set; }
    }
}