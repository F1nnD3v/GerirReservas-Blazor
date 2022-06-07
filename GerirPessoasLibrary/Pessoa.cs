using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerirInfosLibrary
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
