using LorUClassRegistrationApp.Enums;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorUClassRegistrationApp.Models
{
    public class Class
    {
        [Key]
        public int classId { get; set; }
        [Required]
        public Department Dept { get; set; }
        public int? preReqId { get; set; }
        public Class? PreReqs { get; set; }
        public int storedId { get; set; }
        public HumanBeing Teacher { get; set; }
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

        public string DeptToString(Department Dept)
        {
            Dictionary<Department, string> deptDict = new Dictionary<Department, string>()
        {
            {Department.None, "N/A"},
            {Department.Computer_Science, "COMP"},
            {Department.Art, "ARTS"},
            {Department.Music, "MUSC"},
            {Department.Philosophy, "PHIL"},
        };

            if (deptDict.ContainsKey(Dept))
            {
                return deptDict[Dept];
            }
            throw new DeptNotFound();
        }
    }
}
