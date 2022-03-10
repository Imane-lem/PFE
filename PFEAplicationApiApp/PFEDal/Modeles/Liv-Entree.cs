using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
   public class Liv_Entree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_BonL { get; set; }
       
        public string Ref_liv { get; set; }
        public int Solde { get; set; }
        public string Date_BonL { get; set; }

    }
}
