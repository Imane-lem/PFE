using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Responses
{
    public class ResponseModel
    {
        public string StatusCode { get; set; }
        public string StatusLabel { get; set; }
        public string SessionId { get; set; }
        public bool IsAdmin { get; set; }
    }
}
