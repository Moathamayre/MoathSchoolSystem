using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    internal class Teacher : User
    {
        public Teacher() { }
    public Teacher(int Id, string Name, string Email, string Password) 
        {
            this .Id = Id;  
            this .Name = Name;
            this .Email = Email;
            this .Password = Password;
            students = new List<Student>();
            createAt = DateTime.Now;
        }
        public double EnterMarks { get; set; }


    List<Student> students;
    
    public override Role role ()
        {
            return Role.Teacher;
        }
    }
}
