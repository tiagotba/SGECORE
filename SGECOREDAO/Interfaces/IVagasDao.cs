using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.Interfaces
{
   public interface IVagasDao
    {
        int Salvar(Vagas vag);
        IEnumerable<Vagas> ListarTodos();
        void Editar(Vagas vag);
        bool Excluir(int idVag);
        Vagas Pesquisar(int idVag);
    }
}
