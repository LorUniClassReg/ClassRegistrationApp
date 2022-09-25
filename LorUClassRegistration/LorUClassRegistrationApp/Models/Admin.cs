using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }
        [ForeignKey("storedId")]
        public int storedFk { get; set; }
        public string role { get; set; } = "Administrator";
        public DateTime dateStarted { get; set; } = DateTime.Now;
        public int yearsWorked { get; set; }
    }
}
