using PFEDal.Modeles;
using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Administration.service
{
    public class CAdministration : IAdministration
    {
        private readonly PfeDbContext _pfeContext;
        public CAdministration(PfeDbContext pfeDbContext)
        {
            _pfeContext = pfeDbContext;
        }


        public async Task<UserDto> AddUser(UserDto UserDto)
        {
            var user = new Utilisateur()
            {
                Login=UserDto.Login,
                Password = UserDto.Password,
                Service=UserDto.Service,
                Name = UserDto.Name,
                Prenom=UserDto.Prenom,
                Adress=UserDto.Adress,
                Tel=UserDto.Tel,
                Sexe=UserDto.Sexe,
                Date_Naiss=UserDto.Date_Naiss,

            };
             await _pfeContext.Utilisateurs.AddAsync(user);
            _pfeContext.SaveChanges();
            return UserDto;

            
        }

        public Task<List<UserDto>> DeleteUser(string login)
        {
            var user=_pfeContext.Utilisateurs.FirstOrDefault(u => u.Login == login);
            if (user == null)
                return null;
            _pfeContext.Utilisateurs.Remove(user);
            _pfeContext.SaveChanges();
            return null;
        }

        public async Task<UserDto> GetUserById(string login)
        {
          var user=_pfeContext.Utilisateurs.FirstOrDefault(x => x.Login == login);
            var result = new UserDto()
            {
                Login = login,
                Password=user.Password,
                Name = user.Name,
                Prenom=user.Prenom,
                Service=user.Service,
                Sexe=user.Sexe,
                Adress=user.Adress,
                Tel=user.Tel,
                Date_Naiss=user.Date_Naiss,

            };
            return result;
        }

        public List<UserDto> GetUsers()
        {
            var User = _pfeContext.Utilisateurs.ToList();
            var result = User.Select(u => new UserDto()
            {
                Login = u.Login,
                Password = u.Password,
                Name = u.Name,
                Prenom = u.Prenom,
                Date_Naiss = u.Date_Naiss,
                Sexe = u.Sexe,
                Service = u.Service,
                Adress = u.Adress,


            });
            return result.ToList();
        }

        public async Task<UserDto> UpdateUser(string login, UserDto UserDto)
        {
            var user=_pfeContext.Utilisateurs.FirstOrDefault(u => login == u.Login);
            if (user == null)
                return null;
            user.Login = login;
            user.Password = UserDto.Password;
            user.Name = UserDto.Name;
            user.Prenom= UserDto.Prenom;
            user.Adress= UserDto.Adress;
            user.Service = UserDto.Service;
            user.Tel= UserDto.Tel;
            user.Sexe= UserDto.Sexe;
            _pfeContext.Utilisateurs.Update(user);
             _pfeContext.SaveChanges();
            return UserDto;

            
        }
    }
}
