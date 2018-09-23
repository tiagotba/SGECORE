using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGECOREDOMINIO
{
    [Table("VEIC_VEICULO")]
    public class Veiculo
    {
        public Veiculo()
        {

        }

        [Key]
        public int Id_Veiculo { get; set; }
        [Column(TypeName = "nvarchar(9)")]
        public string Placa_Veic { get; set; }

        public ICollection<Ocupacao> Ocupacoes { get; set; }

        public ICollection<Desocupacao> Desocupacoes { get; set; }
    }
}