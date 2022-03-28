using PFEDal.Modeles;
using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Client.services
{
    public class CClient:IClient
    {
        private readonly PfeDbContext _pfeContext;
        public CClient(PfeDbContext pfeDbContext)
        {
            _pfeContext = pfeDbContext;
        }

        public List<ClientDto> GetClients()
        {
            var client=_pfeContext.clients.ToList();
            var result = client.Select(x => new ClientDto()
            {
                ClientId = x.ClientId,
                ClientName = x.ClientName,
                ClientAdress = x.ClientAdress,
                ClientEmail = x.ClientEmail,
                ClientFax = x.ClientFax,
                ClientTel = x.ClientTel,
            });

            return result.ToList();
        }

        public async Task<ClientDto> AddClient(ClientDto clientDto)
        {
            var client = new PFEDal.Modeles.Client()
            {
                ClientName = clientDto.ClientName,
                ClientAdress= clientDto.ClientAdress,
                ClientTel= clientDto.ClientTel,
                ClientFax= clientDto.ClientFax,
                ClientEmail= clientDto.ClientEmail,
                

            };
            await _pfeContext.clients.AddAsync(client);
            _pfeContext.SaveChanges();
            return clientDto;
         
           

           
        }

        public async Task<ClientDto> UpdateClient(int id, ClientDto clientDto)
        {
            var client=_pfeContext.clients.FirstOrDefault(x=>x.ClientId == id);
            if (client == null)
                return null;
            client.ClientId = id;
            client.ClientName = clientDto.ClientName;
            client.ClientAdress = clientDto.ClientAdress;
            client.ClientTel = clientDto.ClientTel;
            client.ClientEmail = clientDto.ClientEmail;
            client.ClientFax = clientDto.ClientFax;
            _pfeContext.clients.Update(client);
            _pfeContext.SaveChanges();
            return clientDto;
        }

        public List<ClientDto> DeleteClient(int id)
        {
            var client = _pfeContext.clients.FirstOrDefault(u => u.ClientId == id);
            if (client == null)
                return null;
             _pfeContext.clients.Remove(client);
             _pfeContext.SaveChanges();
            return GetClients();




        }

        public async Task<ClientDto> GetClientById(int id)
        {
            var client = _pfeContext.clients.FirstOrDefault(x => x.ClientId == id);
            if (client == null)
                return null;
            var result=new ClientDto()
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                ClientAdress = client.ClientAdress,
                ClientTel = client.ClientTel,
                ClientEmail = client.ClientEmail,
                ClientFax = client.ClientFax,

            };
            return result;
        }

        public async Task<List<ClientDto>> Search(string name)
        {
            IQueryable<PFEDal.Modeles.Client> query = _pfeContext.clients;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(u => u.ClientName.Contains(name) );
            }
            var result = query.Select(u => new ClientDto()
            {
                ClientName = u.ClientName,
                ClientId = u.ClientId,
                ClientAdress=u.ClientAdress,
                ClientEmail=u.ClientEmail,
                ClientTel=u.ClientTel,
                ClientFax=u.ClientFax,

            });
            return result.ToList();


        }

       
    }
}
