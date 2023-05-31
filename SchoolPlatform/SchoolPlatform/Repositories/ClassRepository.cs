using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPlatform.Model;

namespace SchoolPlatform.Repositories
{
    public class ClassRepository : RepositoryBase<Class>
    {
        public ClassRepository(SchoolContext context) : base(context)
        {
        }
    }
}
