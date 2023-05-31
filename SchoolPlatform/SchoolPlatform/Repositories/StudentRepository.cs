using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlatform.Model;

namespace SchoolPlatform.Repositories
{
    public class StudentRepository : RepositoryBase<Student>
    {
        public StudentRepository(SchoolContext context) : base(context)
        {
        }
    }
}
