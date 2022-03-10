using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Administration.service
{
    public interface IAdministration
    {
        List<UserDto> GetUsers();
        Task<UserDto> AddUser(UserDto UserDto);
        Task<UserDto> UpdateUser(string login, UserDto UserDto);
        Task<List<UserDto>> DeleteUser(string login);
        Task<UserDto> GetUserById(string login);
    }
}
