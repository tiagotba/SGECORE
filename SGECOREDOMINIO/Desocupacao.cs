using System;

namespace SGECOREDOMINIO
{
    public class Desocupacao
    {
        public Desocupacao()
        {
            
        }
        public int Id_Desocupacao { get; set; }

        public DateTime Data_Hora_Saida { get; set; }

        public virtual Setor setor { get; set; }

        public virtual Vagas Vaga { get; set; }

        public virtual Veiculo Veiculo { get; set; }
    }
}