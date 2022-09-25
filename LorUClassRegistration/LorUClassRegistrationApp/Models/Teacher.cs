using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Teacher
    {
        [Key]
        public int teacherId { get; set; }
        [ForeignKey("bannerId")]
        public int bannerFk { get; set; }
        [ForeignKey("deptId")]
        public int deptFk { get; set; }
        public string role { get; set; } = "Professor";//ie. 'professor', 'chairperson', 'adjunct'
        public int classQty { get; set; }
        public DateTime dateStarted { get; set; } = DateTime.Now;
        public int yearsWorked { get; set; }
    }
}
