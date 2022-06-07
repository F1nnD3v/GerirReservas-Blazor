using GerirInfosLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    public class GerirUsersController : ControllerBase
    {
        private readonly ILogger<GerirUsersController> _userService;

        public GerirUsersController(ILogger<GerirUsersController> userService)
        {
            _userService = userService;
        }

        //vai carregar todas as pessoas
        [HttpGet]
        [Route("ListarPessoas")]
        public List<Pessoa> Get()
        {
            List<Pessoa> pessoas = GerirPessoas.ListarPessoas("") ;
            return pessoas;
        }

        //vai carregar a pessoa com o id passado
        [HttpGet]
        [Route("ListarPessoa/{id}")]
        public Pessoa Get(int id)
        {
            Pessoa pessoa = GerirPessoas.ListarPessoas(id.ToString()).FirstOrDefault();
            return pessoa;
        }        

        //Vai adicionar uma pessoa
        [HttpPost]
        [Route("AdicionarPessoa")]
        public string Post([FromBody] Pessoa pessoa)
        {
            GerirPessoas.Inserir(pessoa);
            return "Pessoa inserida com sucesso";
        }

        //vai editar a pessoa com o id passado
        [HttpPut]
        [Route("EditarPessoa")]
        public string Put([FromBody] Pessoa pessoa)
        {
            string msg;
            if (GerirPessoas.ListarPessoas("").Where(x => x.id == pessoa.id).FirstOrDefault() != null)
            {
                GerirPessoas.Editar(pessoa);
                return msg = "Pessoa editada com sucesso";
            }

            return msg = "Pessoa não encontrada";
        }

        //Elimina a pessoa com o id passado
        [HttpDelete]
        [Route("EliminarPessoa/{id}")]
        public string Delete(int id)
        {
            string msg;
            Pessoa pessoa = GerirPessoas.ListarPessoas("").Where(x => x.id == id).FirstOrDefault();
            if (pessoa != null)
            {
                msg = GerirPessoas.Eliminar(pessoa);
                if(msg == "Essa pessoa tem uma casa, não pode ser eliminada")
                {
                    return msg;
                }
                else
                {
                    Pessoa pessoaRemovida = GerirPessoas.ListarPessoas(id.ToString()).FirstOrDefault();
                    msg = $"A pessoa com o id {pessoa.id} foi removida com sucesso";
                }
            }
            else
            {   
                msg = "Pessoa não encontrada";
            }
            return msg;
        }
    }
}
