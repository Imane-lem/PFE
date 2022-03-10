using PFEServices.Models;
using PFEServices.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.UtilisateurS
{
    public interface IUtilisateur
    {
        Task<ResponseModel> login(UtilisateurDto utilisateurDto);
    }
}
