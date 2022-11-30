using SaintMarysUniversity.Models;

namespace SaintMarysUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",ANumber="A00123456",EnrollmentDate=DateTime.Parse("2021-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",ANumber="A00123457",EnrollmentDate=DateTime.Parse("2022-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",ANumber="A00123458",EnrollmentDate=DateTime.Parse("2020-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",ANumber="A00123459",EnrollmentDate=DateTime.Parse("2021-09-01")},
            new Student{FirstName="Yan",LastName="Li",ANumber="A00123460",EnrollmentDate=DateTime.Parse("2022-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",ANumber="A00123461",EnrollmentDate=DateTime.Parse("2022-09-01")},
            new Student{FirstName="Laura",LastName="Norman",ANumber="A00123462",EnrollmentDate=DateTime.Parse("2022-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",ANumber="A00123463",EnrollmentDate=DateTime.Parse("2020-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,CourseNumber=5511,CRN=11027},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,CourseNumber=5512,CRN=11028},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,CourseNumber=5513,CRN=11029},
            new Course{CourseID=1045,Title="Calculus",Credits=4,CourseNumber=5514,CRN=11030},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,CourseNumber=5515,CRN=11031},
            new Course{CourseID=2021,Title="Composition",Credits=3,CourseNumber=5516,CRN=11032},
            new Course{CourseID=2042,Title="Literature",Credits=4,CourseNumber=5517,CRN=11033}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
