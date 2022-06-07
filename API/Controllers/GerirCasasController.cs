using GerirInfosLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    public class GerirCasasController : ControllerBase
    {
        private readonly ILogger<GerirCasasController> _casaService;

        public GerirCasasController(ILogger<GerirCasasController> casaService)
        {
            _casaService = casaService;
        }
        
        [HttpGet]
        [Route("getCasa/{id}")]
        public  Casa GetCasa(int id)
        {
            Casa casa;
            casa = GerirCasas.ListarCasas(id.ToString()).FirstOrDefault();
            return casa;
        }

        [HttpGet]
        [Route("getCasasPessoa/{idPessoa}")]
        public List<Casa> GetCasasPessoa(int idPessoa)
        {
            List<Casa> casa = new List<Casa>();
            casa = GerirCasas.ListarCasasPessoa(idPessoa);
            return casa;
        }
        
        [HttpGet]
        [Route("getCasas")]
        public List<Casa> GetCasas()
        {
            List<Casa> casa = new List<Casa>();
            casa = GerirCasas.ListarCasas("");
            return casa;
        }

        [HttpPost]
        [Route("inserirCasa")]
        public bool InserirCasa([FromBody] Casa casa)
        {
            var resultado = GerirCasas.InserirCasa(casa);
            if(resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [HttpPut]
        [Route("editarCasa")]
        public string EditarCasa([FromBody] Casa casa)
        {
            if (GerirCasas.ListarCasas("").Where(x => x.Id == casa.Id).FirstOrDefault() != null)
            {
                var resultado = GerirCasas.EditarCasa(casa);
                if (resultado == null)
                {
                    return "Erro ao editar casa";
                }
                else
                {
                    return "Casa editada com sucesso";
                }
            }
            else
            {
                return "Casa não existe";
            }
        }

        [HttpDelete]
        [Route("eliminarCasa/{id}")]
        public string EliminarCasa(int id)
        {
            Casa casa = GerirCasas.ListarCasas("").Where(x => x.Id == id).FirstOrDefault();
            if (casa != null)
            {
                var resultado = GerirCasas.Eliminar(casa);
                if (resultado == null)
                {
                    return "Erro ao eliminar casa";
                }
                else
                {
                    return "Casa eliminada com sucesso";
                }
            }
            else
            {
                return "Casa não existe";
            }
        }
    }
}
