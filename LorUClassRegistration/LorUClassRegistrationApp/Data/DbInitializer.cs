using Microsoft.EntityFrameworkCore;
using LorUClassRegistrationApp.Models;
using LorUClassRegistrationApp.Enums;



namespace LorUClassRegistrationApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var humes = new HumanBeing[]
            {
                new HumanBeing{bannerId = 20000001, password="Socrat3sWasRight", legalName="Aeon Skoble", actualName="Skobskies", gender="Male", photo="N/A", email="", phone="", isStudent=false, isTeacher=true, isAdmin=true, isHyperAdmin=false, isLor=false},
                new HumanBeing{bannerId = 40000001, password="M@keMistakes!", legalName="Miss Frizzle", actualName="", gender="Femme", photo="N/A", email="frizz@LorU.Edu", phone="123 867 5309", isStudent=false, isTeacher=false, isAdmin=true, isHyperAdmin=false, isLor=false},
                new HumanBeing{bannerId = 60000001, password="SwimmingInGold", legalName="Scrooge", actualName="", gender="Goose", photo="N/A", email="Too Old for Email", phone="5", isStudent=false, isTeacher=false, isAdmin=true, isHyperAdmin=true, isLor=false},
                new HumanBeing{bannerId = 00000001, password="WhoaD00d", legalName="Ethan Plue", actualName="Wizard", gender="Male", photo="N/A", email="eplue420@gmail.com", phone="1234567890", isStudent=true, isTeacher=false, isAdmin=false, isHyperAdmin=false, isLor=false},
                new HumanBeing{bannerId = 20000002, password="ProbablyAFinalFantasyCharacter", legalName="Axyl", actualName="", gender="Non Binary", photo="N/A", email="buster@sword.io", phone="", isStudent=false, isTeacher=true, isAdmin=false, isHyperAdmin=false, isLor=false},
                new HumanBeing{bannerId = 88888888, password="LookMomI'mDoingIt!", legalName="Lorelai", actualName="Lor or Laura", gender="Female", photo="N/A", email="lorelailyons@protonmail.com", phone="7207556843", isStudent=true, isTeacher=true, isAdmin=true, isHyperAdmin=true, isLor=true},
            };

            context.HumanBeings.AddRange(humes);
            context.SaveChanges();

            var teachers = new Teacher[]
            {
                new Teacher{TeacherInstance=context.HumanBeings.Find(57),Dept=Department.Philosophy, role="Chair of Philosophy", classQty=6, dateStarted=DateTime.Parse("1998-09-01"),yearsWorked=24},
                new Teacher{TeacherInstance=context.HumanBeings.Find(61),Dept=Department.Philosophy, role="Professor", classQty=7, dateStarted=DateTime.Parse("2013-09-01"),yearsWorked=9},
                new Teacher{TeacherInstance=context.HumanBeings.Find(62),Dept=Department.Music, role="Adjunct", classQty=3, dateStarted=DateTime.Parse("2020-09-01"),yearsWorked=2}
            };

            context.Teachers.AddRange(teachers);
            context.SaveChanges();

            var courses = new Class[]
            {
                new Class{Dept=Department.Philosophy, TeacherInstance=context.Teachers.Find(5), level=101, section = 001, courseTitle="Foundations of Logical Reasoning", creditHours=3.00, classDays=Days.MWF, classTime=TimeSpan.Parse("09:30")},
                new Class{Dept=Department.Philosophy, TeacherInstance=context.Teachers.Find(6), level=101, section = 002, courseTitle="Foundations of Logical Reasoning", creditHours=3.00, classDays=Days.TTr, classTime=TimeSpan.Parse("09:30")},
                new Class{Dept=Department.Philosophy, TeacherInstance=context.Teachers.Find(6), level=201, section = 001, courseTitle="World Philosophy", creditHours=3.00, classDays=Days.MWF, classTime=TimeSpan.Parse("09:30")},
                new Class{Dept=Department.Philosophy, TeacherInstance=context.Teachers.Find(5), level=401, section = 001, courseTitle="Plato and Aristotle", creditHours=3.00, classDays=Days.TTr, classTime=TimeSpan.Parse("09:30")},
                new Class{Dept=Department.Music, TeacherInstance=context.Teachers.Find(5), level=301, section = 001, courseTitle="Philosophy of Music", creditHours=3.00, classDays=Days.F, classTime=TimeSpan.Parse("14:30")},
                new Class{Dept=Department.Computer_Science, TeacherInstance=context.Teachers.Find(6), level=101, section = 001, courseTitle="Introduction to Programming", creditHours=4.00, classDays=Days.MW, classTime=TimeSpan.Parse("12:00")},
                new Class{Dept=Department.Computer_Science, TeacherInstance=context.Teachers.Find(6), level=101, section = 002, courseTitle="Introduction to Programming - Lab", creditHours=0.00, classDays=Days.F, classTime=TimeSpan.Parse("12:00")},
                new Class{Dept=Department.Philosophy, TeacherInstance=context.Teachers.Find(7), level=101, section = 003, courseTitle="Foundations of Logical Reasoning", creditHours=3.00, classDays=Days.MF, classTime=TimeSpan.Parse("11:30")},
            };

            context.Classes.AddRange(courses);
            context.SaveChanges();

            var admins = new Admin[]
            {
                new Admin{AdminInstance=context.HumanBeings.Find(58), role="Financial Aid", dateStarted=DateTime.Parse("2013-09-01"),yearsWorked=9},
                new Admin{AdminInstance=context.HumanBeings.Find(59), role="Dean", dateStarted=DateTime.Parse("2013-09-01"),yearsWorked=9},
                new Admin{AdminInstance=context.HumanBeings.Find(62), role="Owner/Admin", dateStarted=DateTime.Parse("1900-09-01"),yearsWorked=122}
            };

            context.Admins.AddRange(admins);
            context.SaveChanges();


            var students = new Student[]
            {
                new Student{StudentInstance=context.HumanBeings.Find(60), major="Philosophy", minor="Criminal Justice", semestersCompleted=6, dateStarted=DateTime.Parse("2019-09-01"), projectedGraduation=DateTime.Parse("2023-5-01"), creditsCompleted=108},
                new Student{StudentInstance=context.HumanBeings.Find(62),major="Music", minor="Philosophy and Computer Science", semestersCompleted=69, dateStarted=DateTime.Parse("1990-09-12"), projectedGraduation=DateTime.Parse("2420-4-20"), creditsCompleted=100000000}
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
        internal static void Initialize(object context)
        {
            throw new NotImplementedException();
        }
    }
}