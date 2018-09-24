using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.Interfaces
{
  public interface IVeiculoDao
    {
        int Salvar(Veiculo vei);
        IEnumerable<Veiculo> ListarTodos();
        void Editar(Veiculo vei);
        bool Excluir(int idVei);
        Veiculo Pesquisar(int idVei);
    }
}
