using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GerirInfosLibrary
{
    [Table("Casa")]
    public class Casa
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("id")]
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
