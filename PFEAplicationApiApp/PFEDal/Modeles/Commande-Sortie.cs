using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
   public class Commande_Sortie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Com { get; set; }
        public string Ref_com { get; set; }
        public string Date_com { get; set; }
    }
}
