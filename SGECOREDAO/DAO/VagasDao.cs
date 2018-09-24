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
    public class VagasDao : IVagasDao
    {
        private readonly SGECORECONTEXT _context;

        public VagasDao(SGECORECONTEXT context)
        {
            _context = context;
        }

        public void Editar(Vagas vag)
        {
            var entity = Pesquisar(vag.Id_Vaga);
            if (entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public bool Excluir(int idVag)
        {
            bool result = false;
            var entity = Pesquisar(idVag);

            if (entity != null)
            {
                _context.Vagas.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Vagas> ListarTodos()
        {
            return _context.Vagas.Select(v => v);
        }

        public Vagas Pesquisar(int idVag)
        {
            return _context.Vagas.FirstOrDefault(v => v.Id_Vaga == idVag);
        }

        public int Salvar(Vagas vag)
        {
            _context.Vagas.Add(vag);
            return _context.SaveChanges();
        }
    }
}
