using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.Interfaces
{
   public interface ITelefoneDao
    {
        int Salvar(Telefones tel);
        IEnumerable<Telefones> ListarTodos();
        void Editar(Telefones tel);
        bool Excluir(int idTel);
        Telefones Pesquisar(int idTel);
    }
}
