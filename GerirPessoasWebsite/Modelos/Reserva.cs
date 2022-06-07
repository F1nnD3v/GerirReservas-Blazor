namespace GerirPessoasWebsite.Modelos
{
    public class Reserva
    {
        public int Id { get; set; }
        public string DataCheckIn { get; set; }
        public string DataCheckOut { get; set; }
        public string Observacoes { get; set; }
        public int Id_status { get; set; }
        public int valor { get; set; }
        public int id_cliente { get; set; }
        public int id_casa { get; set; }
    }
}
