using System.Collections.Generic;

namespace SGECOREDOMINIO
{
    public class Veiculo
    {
        public Veiculo()
        {
            Ocupacoes = new List<Ocupacao>();
            Desocupacoes = new List<Desocupacao>();
        }
        public int Id_Veiculo { get; set; }

        public string Placa_Veic { get; set; }

        public virtual IList<Ocupacao> Ocupacoes { get; set; }

        public virtual IList<Desocupacao> Desocupacoes { get; set; }
    }
}