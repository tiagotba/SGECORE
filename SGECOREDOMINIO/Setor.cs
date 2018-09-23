using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGECOREDOMINIO
{
    [Table("SET_SETOR")]
    public class Setor
    {
        public Setor()
        {
            //Vagas = new List<Vagas>();
            //Ocupacoes = new List<Ocupacao>();
            //Desocupacoes = new List<Desocupacao>();
        }

        [Key]
        public int Id_Setor { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Nome_Setor { get; set; }
        public ICollection<Vagas> Vagas { get; set; }
        public ICollection<Ocupacao> Ocupacoes { get; set; }
        public ICollection<Desocupacao> Desocupacoes { get; set; }
    }
}