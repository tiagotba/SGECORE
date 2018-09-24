using SGECOREDAO.CONTEXTOS;
using SGECOREDAO.Interfaces;
using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SGECOREDAO.DAO
{
    public class ClienteDao : IClienteDao
    {
        private readonly SGECORECONTEXT _context;

        public ClienteDao(SGECORECONTEXT context)
        {
            _context = context;
        }
        public void Editar(Cliente cli)
        {
            var entity = Pesquisar(cli.Id_Cliente);
            if (entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _context.Clientes.Select(c => c);
        }

        public Cliente Pesquisar(int idCli)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id_Cliente == idCli);
        }

        public int Salvar(Cliente cli)
        {
            _context.Clientes.Add(cli);
            return _context.SaveChanges();
        }
    }
}
