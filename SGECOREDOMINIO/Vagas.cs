using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGECOREDOMINIO
{
    [Table("VAG_VAGA")]
    public class Vagas
    {
        public Vagas()
        {
          
        }
        [Key]
        public int Id_Vaga { get; set; }

        [Column(TypeName ="nvarchar(3)")]
        public string Numero_Vaga { get; set; }

        [Column("ID_SETOR")]
        public int setId { get; set; }
        public  Setor Setor { get; set; }

        public ICollection<Ocupacao> Ocupacoes { get; set; }

        public ICollection<Desocupacao> Desocupacoes { get; set; }
    }
}
