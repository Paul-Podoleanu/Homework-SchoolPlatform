using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlatform.Model;

namespace SchoolPlatform.Repositories
{
    public class CourseRepository : RepositoryBase<Course>
    {
        public CourseRepository(SchoolContext schoolContext) : base(schoolContext)
        {
        }
    }
}
