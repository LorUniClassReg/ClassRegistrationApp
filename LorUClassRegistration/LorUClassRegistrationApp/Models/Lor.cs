using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Lor //I can do anything!
    {
        [Key]
        public int lorId { get; set; }
        public int storedId { get; set; }
        public HumanBeing LorInTheFlesh { get; set; }
    }
}
