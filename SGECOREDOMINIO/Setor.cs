using System.Collections.Generic;

namespace SGECOREDOMINIO
{
    public class Setor
    {
        public Setor()
        {
            Vagas = new List<Vagas>();
            Ocupacoes = new List<Ocupacao>();
            Desocupacoes = new List<Desocupacao>();
        }
        public int Id_Setor { get; set; }
        public string Nome_Setor { get; set; }
        public virtual IList<Vagas> Vagas { get; set; }
        public virtual IList<Ocupacao> Ocupacoes { get; set; }
        public virtual IList<Desocupacao> Desocupacoes { get; set; }
    }
}