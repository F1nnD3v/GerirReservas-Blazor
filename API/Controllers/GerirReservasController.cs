using GerirInfosLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    public class GerirReservasController : ControllerBase
    {
        private readonly ILogger<GerirReservasController> _reservaService;

        public GerirReservasController(ILogger<GerirReservasController> reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet]
        [Route("getReservas")]
        public List<Reserva> GetReservas()
        {
            List<Reserva> reserva = new List<Reserva>();
            reserva = GerirReservas.ListarReservas("");
            return reserva;
        }

        [HttpGet]
        [Route("getReserva/{id}")]
        public Reserva getReserva(int id)
        {
            Reserva reserva;
            reserva = GerirReservas.ListarReservas(id.ToString()).FirstOrDefault();
            return reserva;
        }

        [HttpPost]
        [Route("inserirReserva")]
        public bool InserirReserva([FromBody] Reserva reserva)
        {
            var resultado = GerirReservas.InserirReserva(reserva);
            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        [HttpPut]
        [Route("editarReserva")]
        public bool EditarReserva([FromBody] Reserva reserva)
        {
            var resultado = GerirReservas.EditarReserva(reserva);
            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        [HttpDelete]
        [Route("eliminarReserva")]
        public bool EliminarReserva([FromBody] Reserva reserva)
        {
            var resultado = GerirReservas.EliminarReserva(reserva);
            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [HttpGet]
        [Route("getStatus")]
        public List<Status> GetStatus()
        {
            List<Status> status = new List<Status>();
            status = GerirReservas.ListarStatus();
            return status;
        }

        [HttpGet]
        [Route("getReservaBy/{param}")]
        public List<Reserva> GetReservaBy(string param)
        {
            var reservas = new List<Reserva>();
            reservas = GerirReservas.ListarReservas()
        }
    }
}
