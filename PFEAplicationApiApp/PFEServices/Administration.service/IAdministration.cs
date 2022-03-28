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
        Task<UserDto> UpdateUser(int id, UserDto UserDto);
        List<UserDto> DeleteUser(int id);
        Task<UserDto> GetUserById(int id);
        Task<List<UserDto>> Search(string name);

    }
}
