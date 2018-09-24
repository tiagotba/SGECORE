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
    public class VeiculoDao : IVeiculoDao
    {
        private readonly SGECORECONTEXT _context;

        public VeiculoDao(SGECORECONTEXT context)
        {
            _context = context;
        }

        public void Editar(Veiculo vei)
        {
            var entity = Pesquisar(vei.Id_Veiculo);
            if (entity != null)
            {
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public bool Excluir(int idVei)
        {
            bool result = false;
            var entity = Pesquisar(idVei);

            if (entity != null)
            {
                _context.Veiculos.Remove(entity);
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            return _context.Veiculos.Select(v => v);
        }

        public Veiculo Pesquisar(int idVei)
        {
            return _context.Veiculos.FirstOrDefault(v => v.Id_Veiculo == idVei);
        }

        public int Salvar(Veiculo vei)
        {
            _context.Veiculos.Add(vei);
            return _context.SaveChanges();
        }
    }
}
