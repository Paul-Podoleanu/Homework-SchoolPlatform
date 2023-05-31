using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlatform.Model;

namespace SchoolPlatform.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>
    {
        public SubjectRepository(SchoolContext schoolContext) : base(schoolContext)
        {
        }
    }
}
