using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public enum Role {Student ,Teacher , Parent,Manager }
     
    internal abstract class User
    {
        
    public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime createAt { get; set; }
        public Role type { get; set; }
        public abstract Role role();

    }
}
