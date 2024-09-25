using System;

namespace SchoolHierarchy
{
    // Base class
    public class School
    {
        public string Name { get; set; }
        public string Principal { get; set; }
        public int StudentCount { get; set; }

        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"School Name: {Name}");
            Console.WriteLine($"Principal: {Principal}");
            Console.WriteLine($"Student Count: {StudentCount}");
        }
    }

    // Derived class - MiddleSchool
    public class MiddleSchool : School
    {
        public int LowestGrade { get; set; }
        public int HighestGrade { get; set; }

        public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
            : base(name, principal, studentCount)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
        }

        public void DisplayMiddleSchoolInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Lowest Grade: {LowestGrade}");
            Console.WriteLine($"Highest Grade: {HighestGrade}");
        }
    }

    // Derived class - HighSchool
    public class HighSchool : School
    {
        public string SportsFieldName { get; set; }

        public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
            : base(name, principal, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        public void DisplayHighSchoolInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Sports Field Name: {SportsFieldName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of MiddleSchool
            MiddleSchool middleSchool = new MiddleSchool("Riverdale Middle", "Ms. Johnson", 500, 6, 8);
            Console.WriteLine("Middle School Info:");
            middleSchool.DisplayMiddleSchoolInfo();

            Console.WriteLine();

            // Creating an instance of HighSchool
            HighSchool highSchool = new HighSchool("Greenwood High", "Mr. Smith", 800, "Greenwood Field");
            Console.WriteLine("High School Info:");
            highSchool.DisplayHighSchoolInfo();
        }
    }
}

