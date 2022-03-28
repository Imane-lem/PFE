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
                Name = UserDto.Name,
                Prenom =UserDto.Prenom,
                Date_Naiss = UserDto.Date_Naiss,
                Sexe = UserDto.Sexe,
                Service = UserDto.Service,
                Adress =UserDto.Adress,
                Tel=UserDto.Tel,
            };
             await _pfeContext.Utilisateurs.AddAsync(user);
            _pfeContext.SaveChanges();
            return UserDto;

            
        }

        public  List<UserDto> DeleteUser(int id)
        {
            var user=_pfeContext.Utilisateurs.FirstOrDefault(u => u.UderId == id);
            if (user == null)
                return null;
            _pfeContext.Utilisateurs.Remove(user);
            _pfeContext.SaveChanges();

            return GetUsers();
        }

        public async Task<UserDto> GetUserById(int id)
        {
          var user=_pfeContext.Utilisateurs.FirstOrDefault(x => x.UderId == id);
            var result = new UserDto()
            {
                UderId = user.UderId,
                Login = user.Login,
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
                UderId=u.UderId,
                Login = u.Login,
                Password = u.Password,
                Name = u.Name,
                Prenom = u.Prenom,
                Date_Naiss = u.Date_Naiss,
                Sexe = u.Sexe,
                Service = u.Service,
                Adress = u.Adress,
                Tel = u.Tel



            });
            return result.ToList();
        }

        public async Task<UserDto> UpdateUser(int id, UserDto UserDto)
        {
            var user=_pfeContext.Utilisateurs.FirstOrDefault(u => u.UderId==id);
            if (user == null)
                return null;

                user.Login = UserDto.Login;
                user.Password = UserDto.Password;
                user.Name = UserDto.Name;
                user.Prenom = UserDto.Prenom;
                user.Adress = UserDto.Adress;
                user.Service = UserDto.Service;
                user.Tel = UserDto.Tel;
                user.Sexe = UserDto.Sexe;
            
            _pfeContext.Utilisateurs.Update(user);
             _pfeContext.SaveChanges();
            return UserDto;

            
        }
        public async Task<List<UserDto>> Search(string name)
        {
            IQueryable<Utilisateur> query =_pfeContext.Utilisateurs;

            if (!string.IsNullOrEmpty(name))
            {
                query=query.Where(u=>u.Name.Contains(name)||u.Prenom.Contains(name));
            }

            var result = query.Select(u => new UserDto()
            {
                Prenom = u.Prenom,
                Name = u.Name,
                Date_Naiss=u.Date_Naiss,
                Sexe=u.Sexe,
                Service=u.Service,
                Tel=u.Tel,
                Adress=u.Adress
            });
            return  result.ToList();

            
        }
    }
}

