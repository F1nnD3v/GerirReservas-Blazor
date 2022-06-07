using GerirPessoasWebsite.Modelos;
using GerirPessoasWebsite.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace GerirPessoasWebsite.Services
{
    public class UsersService : IUsersService
    {
        private readonly HttpClient httpClient;
        public UsersService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Pessoa>> GetUsers()
        {
            try
            {
                var users = await this.httpClient.GetFromJsonAsync<IEnumerable<Pessoa>>("/api/GerirUsers");
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
