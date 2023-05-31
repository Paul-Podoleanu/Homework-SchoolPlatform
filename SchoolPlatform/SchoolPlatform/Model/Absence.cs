using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Absence
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
    }
}
