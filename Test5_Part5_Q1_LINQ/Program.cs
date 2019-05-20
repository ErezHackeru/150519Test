using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_5_1_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAOStudents dAOStudents = new DAOStudets();
            List<Students> students = dAOStudents.ReadAllStudent();
            students.ForEach(s => Console.WriteLine($"customer id {s.ID}" +
                    $" Name {s.First_Name} {s.Last_Name}, Address {s.Address}, age {s.Age}"));
            Console.WriteLine();
            List<Grades> grades = dAOStudents.ReadAllGrades();

            dAOStudents.UpdateCoursesAvgGrade();
        }
    }
}
