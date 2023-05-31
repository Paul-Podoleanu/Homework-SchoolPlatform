using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class Grade
    {
        public int Id { get; set; }


        public Student? Student { get; set; }
        public Subject? Subject { get; set; }


        public int Value { get; set; }


    }
}
