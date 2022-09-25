using System.ComponentModel.DataAnnotations;

namespace LorUClassRegistrationApp.Models
{
    public class HumanBeing
    {
        [Key]
        public int storedId { get; set; }
        [Required]
        public int bannerId { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string legalName { get; set; }
        public string actualName { get; set; }
        public string gender { get; set; }
        public string photo { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool isStudent { get; set; } = false;
        public bool isTeacher { get; set; } = false;
        public bool isAdmin { get; set; } = false;
        public bool isHyperAdmin { get; set; } = false;
        public bool isLor { get; set; } = false;
    }
}
