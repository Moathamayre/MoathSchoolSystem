using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;

namespace SchoolSystem
{
    interface ITeacherUpdate
        {
            public void UpdateTeacher();
           
        }
    internal class TeacherServiceChoice
    {
    public class UpdateTeacherName:ITeacherUpdate
        {
        public readonly List<Teacher> _teachers;
            public UpdateTeacherName(List<Teacher> Teachers)
            {
                _teachers= Teachers;
            }
         public void UpdateTeacher()
            {
                Console.WriteLine("Enter The Teacher ID You Want To Change His Name :");
                   int id = int.Parse(Console.ReadLine());
                var UpdateTeacherDet = _teachers.SingleOrDefault(x => x.Id == id);
                if (UpdateTeacherDet != null)
                {
                    Console.WriteLine("Enter The New Name For Teacher : ");
                    string newName = Console.ReadLine();
                    UpdateTeacherDet.Name = newName;
                Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("The Name Has Changed !");
                    Console.ResetColor();
                }
            else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("We Dont Found This ID");
                    Console.ResetColor();
                }
            }
        }
        public class UpdateTeacherEmail : ITeacherUpdate
        {
            public readonly List<Teacher> _teachers;
            public UpdateTeacherEmail(List<Teacher> Teachers)
            {
                 _teachers = Teachers;
            }
        
        public void UpdateTeacher()
            {
                Console.WriteLine("Enter Teacher ID You Want To Change His Email : ");
                int Tid= int.Parse(Console.ReadLine()); 
                var SerTeacher = _teachers.SingleOrDefault( x => x.Id == Tid);
                if( SerTeacher != null )
                {
                    Console.WriteLine("Enter The New Email : ");
                    string Temail = Console.ReadLine();
                    SerTeacher.Email = Temail;
                    Console.BackgroundColor= ConsoleColor.Green;
                    Console.WriteLine($"The Email Has Change ! ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Enterd Wrong ID! ");
                    Console.ResetColor();
                }
            }

        }

        public class UpdateTeacherPassword : ITeacherUpdate
        {
            public readonly List<Teacher> _teachers;
            public UpdateTeacherPassword(List<Teacher> Teachers)
            {
                _teachers = Teachers;
            }
        public void UpdateTeacher()
            {
                Console.WriteLine("Enter Teacher ID You Want To Change His Password :");
                int Tid = int.Parse(Console.ReadLine());
                var SearTeacher = _teachers.SingleOrDefault ( x => x.Id == Tid);
                if( SearTeacher != null )
                {
                    Console.WriteLine("Enter The New Password : ");
                    string TPass = Console.ReadLine();
                    SearTeacher.Password = TPass;
                    Console.BackgroundColor= ConsoleColor.Green;
                    Console.WriteLine("The Password Has Been Changed Succfully !");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong ID ");
                    Console.ResetColor();
                }
            }
        
        }

    
    }
}
