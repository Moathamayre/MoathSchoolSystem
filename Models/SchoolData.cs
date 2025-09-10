using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    internal class SchoolData
    {
       
        public static List<Student> Students  = new List<Student>();
        public static List<Teacher> Teachers  = new List<Teacher>();
        public static List<Parent> Parents = new List<Parent>();
        // i make this class to make All the Lists Shared With All Classes 
        //حتى اجعل كل البيانات الموجودة في هذي الليستات الي بتوخذ بيانات من signup 
        //تروح نفس هذي البيانات لل signin 

    }
}
