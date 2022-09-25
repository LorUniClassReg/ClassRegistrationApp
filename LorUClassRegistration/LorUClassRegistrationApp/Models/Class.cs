using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Class
    {
        [Key]
        public int classId { get; set; }
        [ForeignKey("deptId")]
        public int deptFk { get; set; }
        [ForeignKey("classId")]
        public int? preReqs { get; set; }
        [ForeignKey("storedId")]
        public int storedFk { get; set; }
        [Required]
        public int level { get; set; }          //100, 200....
        [Required]
        public int section { get; set; }        //ie. if more than one of the same course are running: 001, 002, 003...
        [Required]
        public string courseTitle { get; set; }
        [Required]
        public double creditHours { get; set; }
        [Required]
        public string classDays { get; set; }
        [Required]
        public TimeSpan classTime { get; set; }
    }
}
