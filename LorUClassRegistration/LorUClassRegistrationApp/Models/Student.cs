﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        [ForeignKey("storedId")]
        public int storedFk { get; set; }
        public string major { get; set; } = "undeclared";
        public string minor { get; set; }
        public int semestersCompleted { get; set; }
        public DateTime dateStarted { get; set; } = DateTime.Now;
        public DateTime projectedGraduation { get; set; }
        public int maxCredits { get; set; } = 18;
        public int creditsCompleted { get; set; }
    }
}
