using System.Transactions;
using SchoolSystem.Models;
using SchoolSystem.School_Services;
using SchoolSystem.Services;
using SchoolSystem.SignUpAndSignIn;

namespace SchoolSystem
{
    internal class Program
    {
        public static void InterFace()
        {
            int choice;
            Console.WriteLine("==================================");
            Console.WriteLine("     Welcome To Moath School      ");
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What services do you want?");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            while (true)
            { 
                Console.WriteLine(" 1-Sign In \n 2-Sign Up \n 3-Student Service \n 4-Teacher Service \n 5-Exit");
            Console.ResetColor();
            Console.WriteLine("==================================");
            Console.WriteLine("Enter Your Choice : ");
            choice = int.Parse(Console.ReadLine());
                if (choice == 5) break; 
                Choices(choice);
        }
        }
        public static void TypeOfUSU(string type)
        {
            SignIn signIn = new SignIn();
            if (type.ToLower() == "student")
            {
                signIn.SignInS(new Student());
            }
            else if (type.ToLower() == "teacher")
            {
                signIn.SignInT(new Teacher());
            }
            else if (type.ToLower() == "parent")
            {
                signIn.SignInP(new Parent());
            }
            else Console.WriteLine("Wrong Choice");
                    }
        public static void SignUSI(string Type)
        {
            SignUp signUp = new SignUp();
            if (Type.ToLower() == "student")
            {
                signUp.SignUpStudent();
            }
            else if (Type.ToLower() == "teacher")
            {
                signUp.SignUpTeacher();

            }
        else if(Type.ToLower() =="parent")
            {
                signUp.SignUpParent();
            }
        else Console.WriteLine("Wrong Type !");
        }

        public static void StdServ(int choice)
        {
            StudentService studentService = new StudentService();

            switch (choice)
            {
                case 1:
                    studentService.AddStudent(new Student());
                    break;
                case 2:
                    studentService.RemoveStudent(new Student());
                    break;
                case 3:
                    studentService.SearchStudent(new Student());
                    break;
                    case 4:
                    studentService.ShowAllStudent(new Student());
                    break;
                    default:
                    Console.WriteLine("Wrong Choice ! ");
                    break;
            }
        
        }
        public static void TeachServ(int choice)
        {
            TeacherService teacherS = new TeacherService();
            switch (choice)
            {
                case 1:
                    teacherS.GetTeacherById();
                    break;
                case 2:
                    teacherS.GetAllTeachers();
                    break;
                case 3:
                    teacherS.UpdateTeacherDetalis();
                    break;
                    default :
                    Console.WriteLine("Wrong Choice !");
                    break;
            }
        }
                public static void Choices(int choice)
                {
            string Type;
            int Choice;
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("What Are You : Student , Teacher , Parent \nEnter Your Type : ");
                             Type = Console.ReadLine().ToLower();
                    TypeOfUSU(Type);
                    break;
                case 2:
                    Console.WriteLine("What Are You : Student , Teacher , Parent \nEnter Your Type : ");
                    Type = Console.ReadLine();
                    SignUSI(Type);
                    break;
                case 3:
                    Console.WriteLine("What Services You Want : ");
                    Console.WriteLine("=========================");
                    Console.WriteLine("1-Add Student \n2-Remove Student\n3-Search At Student\n4-Show All Students");
                    Console.WriteLine("=========================");
                    Console.Write("Enter Your Choice : ");
                    Choice = int.Parse(Console.ReadLine());
                    StdServ(Choice);
                    break;
                    case 4:
                    Console.WriteLine("What Services You Want : ");
                    Console.WriteLine("=========================");
                    Console.WriteLine("1-Serach On Teacher \n 2-Show All Teachers \n3-Update Teacher Detalis ");
                    Console.WriteLine("=========================");
                    Console.Write("Enter Your Choice : ");
                    Choice = int.Parse(Console.ReadLine());
                    TeachServ(Choice);
                    break;


            }
        }
        static void Main(string[] args)
        {
           
            InterFace();
             

        }
    }
}
