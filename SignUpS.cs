using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;

namespace SchoolSystem.Services
{
    interface ISignUp
    {
        public void SignUp();
    }
    internal class SignUpS
    {

        public class SignUpT : ISignUp
        {
        
            
            public void SignUp()
            {
                Console.WriteLine("Enter Teacher Name : ");
                string Tname = Console.ReadLine();
                Console.WriteLine("Enter Teacher Email : ");
                string Temail = Console.ReadLine();
                var CheckEmail = SchoolData.Teachers.FirstOrDefault(x => x.Email == Temail);
                if (CheckEmail != null)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Have A Account on this Email !");
                    Console.ResetColor();
                }
                else
                {

                    Console.WriteLine("Enter Teacher ID :");
                    int Tid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Password :");
                    string TPassword = Console.ReadLine();

                    Teacher teacher = new Teacher(Tid, Tname, Temail, TPassword);
                    SchoolData.Teachers.Add(teacher);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Teacher Account Has Been Made !");
                    Console.ResetColor();
                }
            }
        }
        public class SignUpStd : ISignUp
        {

            public void SignUp()
            {
                Console.WriteLine("Enter Student Name : ");
                string Sname = Console.ReadLine();
                Console.WriteLine("Enter Student Email : ");
                string Semail = Console.ReadLine();
                var CheckFromEmail = SchoolData.Students.FirstOrDefault(x => x.Email == Semail);
                if (CheckFromEmail != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Have A Account On this Email !");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Enter Student ID :");
                    int Sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Password :");
                    string SPassword = Console.ReadLine();
                    Student student = new Student(Sid, Sname, Semail, SPassword);
                    SchoolData.Students.Add(student);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student  Account Has Been Made !");
                    Console.ResetColor();

                }
            }

        }
        public class SignUpP : ISignUp
        {
            public void SignUp()
            {
                Console.WriteLine("Enter Parent Name : ");
                string Pname = Console.ReadLine();
                Console.WriteLine("Enter Parent Email : ");
                string Pemail = Console.ReadLine();
                var CheckFromEmail = SchoolData.Parents.FirstOrDefault(x => x.Email == Pemail);
                if (CheckFromEmail != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Have a Account On This Email ");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Enter Parant ID :");
                    int Pid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter The Password :");
                    string PPassword = Console.ReadLine();
                    Parent parent = new Parent(Pid, Pname, Pemail, PPassword);
                    SchoolData.Parents.Add(parent);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parent Account Has Been Made !");
                    Console.ResetColor();

                }

            
            }

        
        }


    }
}
