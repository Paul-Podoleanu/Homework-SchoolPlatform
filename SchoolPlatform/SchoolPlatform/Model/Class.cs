using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Class
    {
        public int Id { get; set; }
        //Id Diriginte
        public int? Id_teacher { get; set; }


        public int YearOfStudy { get; set; }
        public string Name { get; set; }
        

        public List<Student> Students { get; set; }

    }
}
