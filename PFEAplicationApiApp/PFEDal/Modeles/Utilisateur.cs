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
        public Utilisateur()
        {
            this.Command_Entrees = new HashSet<Command_Entree>();

            this.Commande_Sorties = new HashSet<Commande_Sortie>();

        }
            [Key]
            public int UderId { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Prenom { get; set; }
            public string Date_Naiss { get; set; }
            public string Sexe { get; set; }
            public string Service { get; set; }
            public string Adress { get; set; }
            public int Tel { get; set; }
            public virtual ICollection<Command_Entree> Command_Entrees { get; set; }
            public virtual ICollection<Commande_Sortie> Commande_Sorties { get; set; }

    }
    
}
