using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    internal class Parent : User
    {
        public Parent() { }
        public Parent(int Id, string Name, string Email, string Password) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            createAt = DateTime.Now;
            students = new List<Student>();
        }


        public List<Student> students { get; set; }
        public override Role role()
        {
            return Role.Parent;
        }
    }
}
