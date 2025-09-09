using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Models;
using static SchoolSystem.Services.SignUpS;

namespace SchoolSystem.Services
{
    internal class SignUp
    {
       
    public void SignUpTeacher()
        {
            var signUpT = new SignUpT();
                
                signUpT.SignUp();
        }

        public void SignUpStudent()
        {
            var signUpS = new SignUpStd();
           
        signUpS.SignUp();
        }
    
        public void SignUpParent()
        {
            var signUpP = new SignUpP();
           

            signUpP.SignUp();
        }

    }
}
