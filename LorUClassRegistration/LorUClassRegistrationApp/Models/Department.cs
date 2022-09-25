using System.ComponentModel.DataAnnotations;

namespace LorUClassRegistrationApp.Models
{
    public class Department
    {
        [Key]
        public int deptId { get; set; }
        [Required]
        public string departmentName { get; set; }
    }
}
