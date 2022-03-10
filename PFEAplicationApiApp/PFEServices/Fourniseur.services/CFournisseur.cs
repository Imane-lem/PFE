using PFEDal.Modeles;
using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Fourniseur.services
{
    public class CFournisseur : IFournisseur
    {
        private readonly PfeDbContext _pfeContext;
        public CFournisseur (PfeDbContext pfeDbContext)
        {
            _pfeContext = pfeDbContext;
        }




        public async Task<FournisseurDto> AddFourni(FournisseurDto fournisseurDto)
        {
            var fournisseur = new Fournisseur()
            {

               Name_f=fournisseurDto.Name_f,
               Adress_f=fournisseurDto.Adress_f,
               Fax_f=fournisseurDto.Fax_f,
               Email_f=fournisseurDto.Email_f,
               Tel_f=fournisseurDto.Tel_f

            };
            await _pfeContext.fournisseurs.AddAsync(fournisseur);
            _pfeContext.SaveChanges();
            return fournisseurDto;
        }

        public Task<List<FournisseurDto>> DeleteFourni(int id)
        {
            var fournisseur=_pfeContext.fournisseurs.First(x=>x.Id_f==id);
            if (fournisseur == null)
                return null;
            _pfeContext.fournisseurs.Remove(fournisseur);
            _pfeContext.SaveChanges();
            return null;
        }

        public List<FournisseurDto> GetFourni()
        {
            var fourni = _pfeContext.fournisseurs.ToList();
            var result = fourni.Select(fourni => new FournisseurDto
            {
                Id_f = fourni.Id_f,
                Name_f = fourni.Name_f,
                Adress_f = fourni.Adress_f,
                Fax_f = fourni.Fax_f,
                Email_f = fourni.Email_f,
                Tel_f= fourni.Tel_f,
            });
            return result.ToList();

        }

        public async Task<FournisseurDto> GetFourniById(int id)
        {
            var fournisseur=_pfeContext.fournisseurs.FirstOrDefault(x=>x.Id_f == id);
            if (fournisseur == null)
                return null;
            var result = new FournisseurDto()
            {
                Id_f=id,
                Name_f=fournisseur.Name_f,
                Adress_f=fournisseur.Adress_f,
                Fax_f=fournisseur.Fax_f,
                Email_f=fournisseur.Email_f,
                Tel_f=fournisseur.Tel_f,

            };
            return result;
        }

        public async Task<FournisseurDto> UpdateFourni(int id, FournisseurDto fournisseurDto)
        {
            var fournisseur=_pfeContext.fournisseurs.FirstOrDefault(u => u.Id_f == id);
            if (fournisseur == null)
                return null;
            fournisseur.Name_f = fournisseurDto.Name_f;
            fournisseur.Adress_f = fournisseurDto.Adress_f;
            fournisseur.Fax_f = fournisseur.Fax_f;
            fournisseur.Email_f = fournisseur.Email_f;
            fournisseur.Tel_f = fournisseur.Tel_f;
             _pfeContext.fournisseurs.Update(fournisseur);
            _pfeContext.SaveChanges();
            return fournisseurDto;
            
        }
    }
}
