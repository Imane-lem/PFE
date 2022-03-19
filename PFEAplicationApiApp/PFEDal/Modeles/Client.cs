using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
    public class Client
    {
        public Client()
        {
            this.Commande_Sorties = new HashSet<Commande_Sortie>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAdress { get; set; }
        public int ClientTel { get; set; }
        public string ClientEmail { get; set; }
        public int ClientFax { get; set; }
        public virtual ICollection<Commande_Sortie> Commande_Sorties { get; set; }

    }
}
