using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Client.services
{
    public interface IClient
    {
        List<ClientDto> GetClients();
        Task<ClientDto> AddClient(ClientDto clientDto);
        Task<ClientDto> UpdateClient(int id, ClientDto clientDto);
        List<ClientDto> DeleteClient(int id);
        Task<ClientDto> GetClientById(int id);
        Task<List<ClientDto>> Search(string name);
    }
}
