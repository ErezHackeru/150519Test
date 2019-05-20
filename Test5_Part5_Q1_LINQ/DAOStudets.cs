using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_5_1_EF
{
    class DAOStudets : IDAOStudents
    {
        public List<Grades> ReadAllGrades()
        {
            List<Grades> grades = new List<Grades>();

            using (Kita1205GradesEntities gradesEntities = new Kita1205GradesEntities())
            {
                grades = (from g in gradesEntities.Grades
                          select g).ToList();
            }

            return grades;
        }

        public List<Students> ReadAllStudent()
        {
            List<Students> students = new List<Students>();

            using (Kita1205GradesEntities gradesEntities = new Kita1205GradesEntities())
            {
                students = (from s in gradesEntities.Students
                            select s).ToList();
            }

            return students;
        }

        public void UpdateCoursesAvgGrade()
        {
            int average = 0;
            List<double> avg_s = new List<double>();
            using (Kita1205GradesEntities gradesEntities = new Kita1205GradesEntities())
            {
                
                var allCoursesGrouped = (from g in gradesEntities.Grades
                                         group g by g.Course_ID).ToList();

                foreach (var CourseGroup in allCoursesGrouped)
                {
                    //starting the count of grades
                    average = 0;

                    //Console.WriteLine("Course Group: {0}", CourseGroup.Key); //Each group has a key 

                    foreach (var c in CourseGroup) // Each group has inner collection
                    {
                        //Console.WriteLine("Course Grade: {0}", c.Grades1);
                        average += (int)c.Grades1;
                    }

                    avg_s.Add(average / CourseGroup.Count());
                    //Console.WriteLine($"Average is: {average / CourseGroup.Count()}");
                    //Console.WriteLine();
                }

                List<Courses> courses = (from c in gradesEntities.Courses
                                         select c).ToList();

                for (int i = 0; i < avg_s.Count; i++)
                {
                    courses[i].Avg_Grade = (decimal)avg_s[i];
                    gradesEntities.SaveChanges();
                }
                
                gradesEntities.SaveChanges();
            }
        }

        public void UpdateCoursesMaxGrade()
        {
            int maxGrade = 0;
            List<int> maxGrades = new List<int>();
            using (Kita1205GradesEntities gradesEntities = new Kita1205GradesEntities())
            {

                var allCoursesGrouped = (from g in gradesEntities.Grades
                                         group g by g.Course_ID).ToList();

                foreach (var CourseGroup in allCoursesGrouped)
                {
                    //start with maximal grade = 0
                    maxGrade = 0;

                    foreach (var c in CourseGroup)
                    {
                        if (c.Grades1>maxGrade)
                        {
                            maxGrade = (int)c.Grades1;
                        }
                    }
                    maxGrades.Add(maxGrade);
                }

                List<Courses> courses = (from c in gradesEntities.Courses
                                         select c).ToList();

                for (int i = 0; i < maxGrades.Count; i++)
                {
                    courses[i].Highest_Grade = (int)maxGrades[i];
                    gradesEntities.SaveChanges();
                }

                gradesEntities.SaveChanges();
            }
        }

        public void UpdateCoursesNumOfStudents()
        {            
            List<int> numOfStudents = new List<int>();
            using (Kita1205GradesEntities gradesEntities = new Kita1205GradesEntities())
            {

                var allCoursesGrouped = (from g in gradesEntities.Grades
                                         group g by g.Course_ID).ToList();

                foreach (var CourseGroup in allCoursesGrouped)
                {
                    numOfStudents.Add(CourseGroup.Count());                    
                }

                List<Courses> courses = (from c in gradesEntities.Courses
                                         select c).ToList();

                for (int i = 0; i < numOfStudents.Count; i++)
                {
                    courses[i].Num_Of_Students = numOfStudents[i];
                    gradesEntities.SaveChanges();
                }

                gradesEntities.SaveChanges();
            }
        }
    }
}
