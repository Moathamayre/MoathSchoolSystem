using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    internal class Manager:User
    {
    public Manager ()
        {
            Students = new List<Student>();
Teachers = new List<Teacher>();

        }
    
        public List <Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public override Role role ()
        {
            return Role.Manager;
        }
    }
}
