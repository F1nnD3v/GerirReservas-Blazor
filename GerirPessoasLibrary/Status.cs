using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GerirInfosLibrary
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int Id_status { get; set; }
        public string status { get; set; }
    }
}
