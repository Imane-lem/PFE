using PFEDal.Modeles;
using PFEServices.Helpers;
using PFEServices.Models;
using PFEServices.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.UtilisateurS
{
    public class CUtilisateur : IUtilisateur
    {
        private readonly PfeDbContext _userContext;
        public CUtilisateur(PfeDbContext pfeDbContext)
        {
            _userContext = pfeDbContext;
        }


        public async Task<ResponseModel> login(UtilisateurDto utilisateurDto)
        {
            var user = _userContext.Utilisateurs.FirstOrDefault(x => x.Login == utilisateurDto.Login);
            var result = CheckLogin(user, utilisateurDto);
            if (result.Key)
            {
                var Session = new Session()
                {
                    SessionId = Helper.RandomString(6),
                    UserName = utilisateurDto.Login,
                    DateConxion = DateTime.Now
                };

                _userContext.Sessions.Add(Session);
                _userContext.SaveChanges();

                var Admin = (user.Service == "Administrateur") ? true : false;

                return new ResponseModel
                {
                    StatusCode = "000",
                    StatusLabel = result.Value,
                    SessionId = Session.SessionId,
                    IsAdmin = Admin

                };
            }
            else
            {
                return new ResponseModel
                {
                    StatusCode = "999",
                    StatusLabel = result.Value,
                    SessionId = null,
                    IsAdmin = false

                };
            }
        }
        private KeyValuePair<bool, string> CheckLogin(Utilisateur? utilisateur, UtilisateurDto utilisateurDto)
        {
            if (utilisateur == null)
                return new KeyValuePair<bool, string>(false, "Utilisateur introvable");
            if (!utilisateur.Login.Equals(utilisateurDto.Login))
                return new KeyValuePair<bool, string>(false, "login invalid");
            if (!utilisateur.Password.Equals(utilisateurDto.Password))
                return new KeyValuePair<bool, string>(false, "password incorect");
            
            return new KeyValuePair<bool, string>(true, "Ok");
        }
    }
}
