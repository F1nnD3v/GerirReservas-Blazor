using GerirPessoasWebsite.Modelos;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GerirPessoasWebsite.Services
{
    public class CasasService : ICasasService
    {
        private readonly HttpClient httpClient;

        public CasasService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Casa>> GetCasas()
        {
            try
            {
                var casas = await this.httpClient.GetFromJsonAsync<IEnumerable<Casa>>("/api/GerirCasas");
                return casas;
            }
            catch (HttpRequestException e)
            {
                throw e;
            }


        }
    }
}
