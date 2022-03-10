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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAdress { get; set; }
        public int ClientTel { get; set; }
        public string ClientEmail { get; set; }
        public int ClientFax { get; set; }

    }
}
