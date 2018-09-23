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

        public DateTime Data_Hora_Entrada { get; set; }

        public int setId { get; set; }
        public Setor setor { get; set; }

        public int vagId { get; set; }
        public Vagas vaga { get; set; }

        public int veiId { get; set; }
        public  Veiculo veiculo { get; set; }


     //   public virtual Estadia Estadia { get; set; }
    }
}