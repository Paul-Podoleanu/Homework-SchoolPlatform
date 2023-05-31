using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
   
    public class StudentGardeAverage
    {
        public Student student { get; set; }
        public float GradeAverage { get; set; }

        public StudentGardeAverage(Student student, float gradeAverage)
        {
            this.student = student;
            this.GradeAverage = gradeAverage;
        }
        public StudentGardeAverage()
        {
            student = new Student();
            GradeAverage = 0;
        }

        public StudentGardeAverage(Student student)
        {
            this.student = student;
            GradeAverage = computeGradeAverage();
        }

        float computeGradeAverage()
        {
            float sum = 0;
            foreach (Grade grade in student.Grades)
            {
                sum += grade.Value;
            }
            return sum / student.Grades.Count;
        }
    }
}
