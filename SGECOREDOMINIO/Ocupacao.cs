using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGECOREDOMINIO
{
    [Table("OCU_OCUPACAO")]
    public class Ocupacao
    {
        public Ocupacao()
        {
           
        }

        [Key]
        public int Id_Ocup { get; set; }

        [Column("DATA_ENTRADA")]
        public DateTime Data_Hora_Entrada { get; set; }

        [Column("ID_SETOR_OCU")]
        public int setId { get; set; }
        public Setor Setor { get; set; }

        [Column("ID_VAGA_OCU")]
        public int vagId { get; set; }
        public Vagas Vaga { get; set; }

        [Column("ID_VEICULO_OCU")]
        public int veiId { get; set; }
        public  Veiculo Veiculo { get; set; }


     //   public virtual Estadia Estadia { get; set; }
    }
}