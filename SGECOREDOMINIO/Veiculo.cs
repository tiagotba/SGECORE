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
        [Column("PLC_VEICULO",TypeName = "nvarchar(9)")]
        public string Placa_Veic { get; set; }

        [Column("ID_VEICULO_CLI")]
        public int cliId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<Ocupacao> Ocupacoes { get; set; }

        public ICollection<Desocupacao> Desocupacoes { get; set; }
    }
}