using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
    public class Command_Entree
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Bon { get; set; }
        public string Reference { get; set; }
        public string Date_Com { get; set; }
        public Nullable<int> Id_f { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
        public Nullable<int> UserId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public Nullable<int> ArticleId { get; set; }
        public virtual Article Article { get; set; }

    }
}
