using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_5_1_EF
{
    interface IDAOStudents
    {
        List<Students> ReadAllStudent();
        List<Grades> ReadAllGrades();
        void UpdateCoursesAvgGrade();
        void UpdateCoursesNumOfStudents();
        void UpdateCoursesMaxGrade();
    }
}
