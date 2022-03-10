using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Models
{
   public class UserDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Date_Naiss { get; set; }
        public string Sexe { get; set; }
        public string Service { get; set; }
        public string Adress { get; set; }
        public int Tel { get; set; }
      
    }
}
