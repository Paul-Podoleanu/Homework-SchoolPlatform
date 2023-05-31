using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Student
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Class? Class { get; set; }


        public string Nume { get; set; }
        public string Prenume { get; set; }


        public List<Grade> Grades { get; set; }
        public List<Absence> Absences { get; set; }
        
    }
}
