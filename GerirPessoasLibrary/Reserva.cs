using System.ComponentModel.DataAnnotations;    
using System.ComponentModel.DataAnnotations.Schema;

namespace GerirInfosLibrary
{
    [Table("Reservas")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public string DataCheckIn { get; set; }
        public string DataCheckOut { get; set; }
        public string Observacoes { get; set; }
        [ForeignKey("Id_status")]
        public int Id_status { get; set; }
        public int valor { get; set; }
        [ForeignKey("id")]
        public int id_cliente { get; set; }
        [ForeignKey("Id")]
        public int id_casa { get; set; }

    }
}
