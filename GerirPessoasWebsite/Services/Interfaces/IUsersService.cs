using GerirPessoasWebsite.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerirPessoasWebsite.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<Pessoa>> GetUsers();
    }
}
