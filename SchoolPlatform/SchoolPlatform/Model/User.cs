using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    //Role to identify the type of user and what mainPage to open
    public enum Role
    {
        admin, profesor, diriginte, elev
    }

    public class User
    {
        //ID to identify the user in every table
        public int Id { get; set; }


        public Role Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        public List<Grade> Grades { get; set; }
    }
}
