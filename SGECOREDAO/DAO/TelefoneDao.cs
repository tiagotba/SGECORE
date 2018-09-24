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
    public class TelefoneDao : ITelefoneDao
    {
        private readonly SGECORECONTEXT _context;

        public TelefoneDao(SGECORECONTEXT context)
        {
            _context = context;
        }

        public void Editar(Telefones tel)
        {
            var entity = Pesquisar(tel.Id_Telefone);
            if (entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public bool Excluir(int idTel)
        {
            bool result = false;
            var entity = Pesquisar(idTel);

            if (entity != null)
            {
                _context.Telefones.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Telefones> ListarTodos()
        {
            return _context.Telefones.Select(t => t);
        }

        public Telefones Pesquisar(int idTel)
        {
            return _context.Telefones.FirstOrDefault(t => t.Id_Telefone == idTel);
        }

        public int Salvar(Telefones tel)
        {
            _context.Telefones.Add(tel);
            return _context.SaveChanges();
        }
    }
}
