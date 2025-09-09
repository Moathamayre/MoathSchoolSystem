using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;

namespace SchoolSystem.School_Services
{
    internal class StudentService
    {

        public StudentService()
        {
            _students = SchoolData.Students;
        }
        private readonly List<Student> _students;
        public void AddStudent(Student student)
        {
            Console.WriteLine("Enter The Name Of Students You Want To Add :");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter The Email Of Students You Want To Add :");
            string studentEmail = Console.ReadLine();
            Console.WriteLine("Enter The Password Of Student You Want To Add :");
            string studentPassword = Console.ReadLine();
            Console.WriteLine("Enter The ID Of Students You Want To Add :");
            int studentID = int.Parse(Console.ReadLine());
            Student Addstd = new Student(studentID, studentName, studentEmail, studentPassword);
            _students.Add(Addstd);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student Has Been Added ");
            Console.ResetColor();


        }
        public void RemoveStudent(Student student)
        {
            Console.WriteLine("Enter The ID Of Student You Want To Remove : ");
            int SID = int.Parse(Console.ReadLine());
            var removestd = _students.FirstOrDefault(x=>x.Id == SID);
            if (removestd != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student With Id {SID} Has Been Removed");
                _students.Remove(removestd);
            }

            else Console.WriteLine("Wrong ID ! ");
        }
        public void SearchStudent(Student student)
        {
            Console.WriteLine("Enter The Name Of Student You Want To Search At :");
            string stdName = Console.ReadLine();
            var SearchStd = _students.Where(x => x.Name==stdName).ToList();
            foreach (var studentstd in SearchStd)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student With ID : {studentstd.Id} | With Name :{studentstd.Name} | With Email :{studentstd.Email} ");
            }
        }
        public void ShowAllStudent(Student student)
        {
            foreach (var studentstd in _students)
            {
                Console.WriteLine($"The Student With ID : {studentstd.Id} | With Name :{studentstd.Name} | With Email :{studentstd.Email}");
            }
        }

    }
}
