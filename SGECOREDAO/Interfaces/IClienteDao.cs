using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.Interfaces
{
  public  interface IClienteDao
    {
        int Salvar(Cliente cli);
        IEnumerable<Cliente> ListarTodos();
        void Editar(Cliente cli);
        Cliente Pesquisar(int idCli);
    }
}
