using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;

namespace SchoolSystem.SignUpAndSignIn
{
    internal class SignIn
    {
   
        public void SignInS(Student student)
        {
            Console.WriteLine("Enter Student Email :");
            string SignInEmail =Console.ReadLine();
            string CheckFromEmail = SignInEmail.ToLower();
            var Std = SchoolData.Students.FirstOrDefault(x => x.Email == CheckFromEmail);
            if (Std != null)
            {
                Console.WriteLine("Enter Your Password : ");
                string SPass = Console.ReadLine();
                if (Std.Password == SPass)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sign In Succeful ");
                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Password");
                    Console.ResetColor();

                }

            }
            else Console.WriteLine("This Email Does Not Exist");
        }
    public void SignInT(Teacher teacher)
        {
            Console.WriteLine("Enter You Email : ");
            string SignInEmail = Console.ReadLine();
            Console.WriteLine("Enter Your ID : ");
            int TID = int.Parse(Console.ReadLine());
            var Teach = SchoolData.Teachers.FirstOrDefault(t => t.Id == TID);
            if (Teach != null)
            {
                Console.WriteLine("Enter Your Password : ");
                string Tpass = Console.ReadLine();
                if (Teach.Password==Tpass)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Welcome : {Teach.Name} With Id : {TID} ");
                    Console.ResetColor();

                }

                else Console.WriteLine("Wrong Password ");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong ID ! Enter the Right ID AGAIN !");
                Console.ResetColor();

            }


        }
    public void SignInP(Parent parent)
        {
            Console.WriteLine("Enter Parent Email : ");
            string SignInEmail = Console.ReadLine();
            Console.WriteLine("Enter Parent ID : ");
            int PID = int.Parse(Console.ReadLine());
            var Par =SchoolData.Parents.FirstOrDefault(z =>  z.Id == PID);
            if (Par != null)
            {
                Console.WriteLine("Enter The Password ");
                string Ppass = Console.ReadLine();
                if(Par.Password==Ppass)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Login Has Been Succefully !");
                    Console.ResetColor();

                }
                else Console.WriteLine("Wrong Password !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong ID Try Again !");
                Console.ResetColor();

            }
        }
    
    
    }


}
