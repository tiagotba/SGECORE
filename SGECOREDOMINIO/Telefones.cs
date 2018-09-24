using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGECOREDOMINIO
{
    [Table("TEL_TELEFONE")]
    public  class Telefones
    {
        public Telefones()
        { }

        [Key]
        public int Id_Telefone { get; set; }

        [Column("DDD_TELEFONE",TypeName = "nvarchar(3)"), Required]
        public string Ddd_Fone { get; set; }

        [Column("NUM_TELEFONE",TypeName = "nvarchar(10)"), Required]
        public string Num_Fone { get; set; }

        [Column("ID_TELEFONE_CLI")]
        public int cliId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
