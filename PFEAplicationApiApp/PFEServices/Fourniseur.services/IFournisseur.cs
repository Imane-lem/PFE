using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Fourniseur.services
{
    public interface IFournisseur
    {
        List<FournisseurDto> GetFourni();
        Task<FournisseurDto> AddFourni(FournisseurDto fournisseurDto);
        Task<FournisseurDto> UpdateFourni(int id, FournisseurDto fournisseurDto);
        List<FournisseurDto> DeleteFourni(int id);
        Task<FournisseurDto> GetFourniById(int id);
        Task<List<FournisseurDto>> Search(string name);
    }
}
