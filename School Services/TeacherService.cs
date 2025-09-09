using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;
using static SchoolSystem.TeacherServiceChoice;

namespace SchoolSystem.School_Services
{
    internal class TeacherService
    {
        public TeacherService() { }
        ITeacherUpdate TSC {  get; set; }
    private readonly List <Teacher> _teachers;
                   TeacherServiceChoice teacherServiceChoice = new TeacherServiceChoice();
        public TeacherService(List <Teacher> Teachers)
        {
_teachers = Teachers;
        
        }
        public void GetTeacherById()
        {
            Console.WriteLine("Enter Teacher's ID :");
            int TID= int.Parse(Console.ReadLine());
            var SearchTeachers = _teachers.SingleOrDefault(x => x.Id == TID);
            if (SearchTeachers != null)
            {
                
                    Console.WriteLine($"The Teacher : {SearchTeachers.Name} | With ID : {SearchTeachers.Id}");
                
            }
            else Console.WriteLine("The ID is Wrong ! ");
        }
        public void GetAllTeachers()
        {

            foreach( var Teacher in _teachers )
            {
                Console.WriteLine($"The Teacher : {Teacher.Name} | With ID : {Teacher.Id}");
            }

        }
        public void UpdateTeacherDetalis()

        {

            int choice;
            Console.WriteLine("What You Want Update : \n1-Update Teacher Name \n2-Update Teacher Email \n3-Update Teacher Password ");
        choice = int.Parse(Console.ReadLine());
            switch( choice )
            {
                case 1:
                   var UTName = new TeacherServiceChoice.UpdateTeacherName(_teachers);
                    UTName.UpdateTeacher();
                    break;
                case 2:
                    var UTEmail = new TeacherServiceChoice.UpdateTeacherEmail(_teachers);
                    UTEmail.UpdateTeacher();
                    break;
                case 3:
                    var UTPassword = new TeacherServiceChoice.UpdateTeacherPassword(_teachers); 
                    UTPassword.UpdateTeacher();
                    break;
                default:
                    Console.WriteLine("Wrong Choice ");
                    break;
            }
      
        }
    
    
    }
}

