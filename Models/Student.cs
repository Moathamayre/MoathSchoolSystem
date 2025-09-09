using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    internal class Student : User
    {
       public Student() { }
        public Student (int Id , string Name , string Email , string Password)
        {
            this .Id = Id;
            this .Name = Name;
            this .Email = Email;
            this .Password = Password;
            teachers = new List<Teacher>();
           
            createAt = DateTime.Now;
        }
        
        
        
        public string Subjects { get; set; }
        public List<Teacher> teachers { get; set; }
        
        public override Role role ()
        {
            return Role.Student;
        }
    }
}
