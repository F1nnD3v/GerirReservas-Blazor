using AutoMapper;
using GerirInfosLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerirInfosLibrary
{
    public class GerirCasas
    {
        //Insere a casa passada por parametro na base de dados
        public static int InserirCasa(Casa casa)
        {
            using(var db = new PessoaDbContext())
            {
                db.Casas.Add(casa);
                db.SaveChanges();
            }
            return casa.Id;
        }

        //vai editar a casa passada por parametro na base de dados
        public static bool EditarCasa(Casa casa)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Casa,Casa>();
            });

            IMapper mapper = config.CreateMapper();

            try
            {
                using (var db = new PessoaDbContext())
                {
                    var house = db.Casas.Where(c => c.Id == casa.Id).FirstOrDefault();
                    mapper.Map(casa, house);
                    db.SaveChanges();
                  }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //Vai eliminar a casa passada como parametro da base de dados
        public static bool Eliminar(Casa casa)
        {
            try
            {
                using (var db = new PessoaDbContext())
                {
                    db.Entry(casa).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //lista todas as casas caso o parametro passado seja null se não lista apenas as casas com o nome igual ao parametro
        public static List<Casa> ListarCasas(string param)
        {
            using (var db = new PessoaDbContext())
            {
                if(param == "")
                {
                    return db.Casas.ToList();
                }
                else
                {
                    return db.Casas.Where(c => c.Id == Convert.ToInt32(param)).ToList();
                }
            }
        }

        //lista todas as casas da pessoa 
        public static List<Casa> ListarCasasPessoa(int id)
        {
            using (var db = new PessoaDbContext())
            {
                return db.Casas.Where(c => c.pessoaid == id).ToList();
            }
        }
    }
}
