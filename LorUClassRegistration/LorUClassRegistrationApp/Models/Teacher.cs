using LorUClassRegistrationApp.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Teacher
    {
        [Key]
        public int teacherId { get; set; }
        //public int storedId { get; set; }
        public HumanBeing TeacherInstance { get; set; }
        [Required]
        public Department Dept { get; set; }
        public string role { get; set; } = "Professor";//ie. 'professor', 'chairperson', 'adjunct'
        public int classQty { get; set; }
        public DateTime dateStarted { get; set; } = DateTime.Now;
        public int yearsWorked { get; set; }
        public List<Class> classList { get; set; }

        public string DeptToString(Department Dept)
        {
            Dictionary<Department, string> deptDict = new Dictionary<Department, string>()
        {
            {Department.None, "N/A"},
            {Department.Computer_Science, "Computer Science"},
            {Department.Art, "Art"},
            {Department.Music, "Music"},
            {Department.Philosophy, "Philosophy"},
        };

            if (deptDict.ContainsKey(Dept))
            {
                return deptDict[Dept];
            }
            throw new DeptNotFound();
        }
    }
}
