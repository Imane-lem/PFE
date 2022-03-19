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
        public Nullable<int> UserId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public Nullable<int> ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public Nullable<int> ClientId { get; set; }
        public virtual Client Client{ get; set; }

    }
}
