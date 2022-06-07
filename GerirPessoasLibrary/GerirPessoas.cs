using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerirInfosLibrary
{
    public class GerirPessoas
    {
        //Insere a pessoa passada por parâmetro na base de dados
        public static int Inserir(Pessoa pessoa)
        {
           
            using (var db = new PessoaDbContext())
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
            }
            return pessoa.id;
            
        }

        //vai editar a pessoa passada como parametro na base de dados
        public static bool Editar(Pessoa pessoa)
        {
            try
            {
                using (var db = new PessoaDbContext())
                {
                    var user = db.Pessoas.Where(p => p.id == pessoa.id).FirstOrDefault();
                    user.nome = pessoa.nome;
                    user.email = pessoa.email;
                    user.idade = pessoa.idade;
                    user.telefone = pessoa.telefone;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
        //Vai eliminar a pessoa passada como parametro
        
        public static string Eliminar(Pessoa pessoa)
        {
            try
            {
                using (var db = new PessoaDbContext())
                {
                    var casa = db.Casas.Where(c => c.id_Dono == pessoa.id).FirstOrDefault();
                    if(casa != null)
                    {
                        return "Essa pessoa tem uma casa, não pode ser eliminada";
                    }
                    db.Entry(pessoa).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return "Pessoa eliminada com sucesso";
            }   
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //lista todas as pessoas caso o parametro passado seja "" se não lista apenas as pessoas com o id igual ao parametro
        public static List<Pessoa> ListarPessoas(string param)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (var db = new PessoaDbContext())
            {
                if (param == "")
                {
                    pessoas = db.Pessoas.ToList();
                    foreach(var pessoa in pessoas)
                    {
                        pessoa.nome = pessoa.nome.Trim();
                        pessoa.telefone = pessoa.telefone.Trim();
                    }
                }
                else
                {
                    pessoas = db.Pessoas.Where(p => p.id.ToString() == param).ToList();
                }
            }
            return pessoas;
        }
    }
}
