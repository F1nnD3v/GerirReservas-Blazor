using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerirInfosLibrary
{
    public class GerirReservas
    {
        //Insere uma reserva na base de dados
        public static int InserirReserva(Reserva reserva)
        {
            using(var db = new PessoaDbContext())
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
            }
            return reserva.Id;
        }

        //Edita a reserva recebida
        public static bool EditarReserva(Reserva reserva)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Reserva, Reserva>();
            });

            IMapper mapper = config.CreateMapper();

            try
            {
                using (var db = new PessoaDbContext())
                {
                    var reservabd = db.Reservas.Where(r => r.Id == reserva.Id).FirstOrDefault();
                    mapper.Map(reserva, reservabd);
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
        
        public static string EliminarReserva(Reserva reserva)
        {
            try
            {
                using (var db = new PessoaDbContext())
                {
                    var reservadb = db.Reservas.Where(r => r.Id == reserva.Id).FirstOrDefault();
                    if(reservadb == null)
                    {
                        return "Reserva não encontrada";
                    }
                    else
                    {
                        db.Entry(reserva).State = EntityState.Deleted;
                        db.SaveChanges();
                        return "Reserva eliminada com sucesso";
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //Lista todas as reservas caso o parametro passado seja "" se não lista apenas as pessoas com o id igual ao parametro
        
        public static List<Reserva> ListarReservas(string param)
        {
            using(var db = new PessoaDbContext())
            {
                if(param == "")
                {
                    return db.Reservas.ToList();
                }
                else 
                {
                    return db.Reservas.Where(r => r.Id == Convert.ToInt32(param)).ToList();
                }
            }
        }

        //Listar status
        public static List<Status> ListarStatus()
        {
            var status = new List<Status>();
            using (var db = new PessoaDbContext())
            {
                status = db.Status.ToList();
            }
            return status;
        }

        public static List<Reserva> ListarReservaBy(string filtro, string conteudo)
        {
            var reservas = new List<Reserva>();
            using (var db = new PessoaDbContext())
            {
                reservas = db.
            }
            return reservas;
        }
    }
}
