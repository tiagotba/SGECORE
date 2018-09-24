using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.Interfaces
{
  public  interface ISetorDao
    {
        int Salvar(Setor set);
        IEnumerable<Setor> ListarTodos();
        void Editar(Setor set);
        bool Excluir(int idSet);
        Setor Pesquisar(int idSet);
    }
}
