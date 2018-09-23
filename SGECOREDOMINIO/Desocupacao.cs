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

        public DateTime Data_Hora_Saida { get; set; }

        public int setId { get; set; }
        public Setor setor { get; set; }

        public int vagId { get; set; }
        public Vagas Vaga { get; set; }

        public int veiId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}