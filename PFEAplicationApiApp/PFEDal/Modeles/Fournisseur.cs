using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
    
    public class Fournisseur
    {
        public Fournisseur()
        {
            this.Command_Entrees = new HashSet<Command_Entree>();


        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_f { get; set; }
        public string Name_f { get; set; }
        public string Adress_f { get; set; }
        public int Tel_f { get; set; }
        public int Fax_f { get; set; }
        public string Email_f { get; set; }

        public virtual ICollection<Command_Entree> Command_Entrees { get; set;}

    }
}
