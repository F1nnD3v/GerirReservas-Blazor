namespace GerirPessoasWebsite.Modelos
{
    public class Casa
    {
        public int Id { get; set; }
        public int id_Dono { get; set; }
        public string nome { get; set; }
        public string morada { get; set; }
        public int numero { get; set; }
        public string codigoPostal { get; set; }
        public string localidade { get; set; }
        public string distrito { get; set; }
        public string pais { get; set; }
        public int pessoaid { get; set; }
    }
}
