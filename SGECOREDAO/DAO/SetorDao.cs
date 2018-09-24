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
    public class SetorDao : ISetorDao
    {
        private readonly SGECORECONTEXT _context;

        public SetorDao(SGECORECONTEXT context)
        {
            _context = context;
        }

        public void Editar(Setor set)
        {
            var entity = Pesquisar(set.Id_Setor);
            if (entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public bool Excluir(int idSet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setor> ListarTodos()
        {
            return _context.Setores.Select(s => s);
        }

        public Setor Pesquisar(int idSet)
        {
            return _context.Setores.FirstOrDefault(s => s.Id_Setor == idSet);
        }

        public int Salvar(Setor set)
        {
            _context.Setores.Add(set);
            return _context.SaveChanges();
        }
    }
}
