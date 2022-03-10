using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
  
        public class Utilisateur
        {
            [Key]

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
