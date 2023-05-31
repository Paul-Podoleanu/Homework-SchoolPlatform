using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public Class? Class { get; set; }

        public string Name { get; set; }


        public List<Teacher> Teachers { get; set; }
        public List<Course> Courses { get; set; }
    }
}
