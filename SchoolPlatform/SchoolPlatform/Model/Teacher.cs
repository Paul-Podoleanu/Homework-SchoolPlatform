using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public User User { get; set; }

        //Clasa la care este diriginte (daca este cazul)
        [DisplayFormat(NullDisplayText = "Nu este diriginte")]
        public Class? Class { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }


        bool IsClassTeacher { get; set; }
        public List<Class> Classes { get; set; }
        public List<Subject> Subjects { get; set; }

    }
}
