using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Models
{
    public class ClientDto
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAdress { get; set; }
        public int ClientTel { get; set; }
        public string ClientEmail { get; set; }
        public int ClientFax { get; set; }
    }
}
