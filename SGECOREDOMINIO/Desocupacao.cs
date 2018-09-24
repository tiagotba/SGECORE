using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGECOREDOMINIO
{
    [Table("DES_DESOCUPACAO")]
    public class Desocupacao
    {
        public Desocupacao()
        {

        }
        [Key]
        public int Id_Desocupacao { get; set; }

        [Column("DATA_SAIDA")]
        public DateTime Data_Hora_Saida { get; set; }

        [Column("ID_SETOR_DESO")]
        public int setId { get; set; }
        public Setor Setor { get; set; }

        [Column("ID_VAGA_DESO")]
        public int vagId { get; set; }
        public Vagas Vaga { get; set; }

        [Column("ID_VEICULO_DESO")]
        public int veiId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}