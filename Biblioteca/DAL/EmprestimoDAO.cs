using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.DAL
{
    class EmprestimoDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static bool Cadastrar(Emprestimo emprestimo)
        {
            try
            {
                _context.Emprestimo.Add(emprestimo);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void Alterar(Emprestimo emprestimo)
        {
            _context.Emprestimo.Update(emprestimo);
            _context.SaveChanges();
        }

        public static List<Emprestimo> Listar() =>
           _context.Emprestimo.ToList();
        public static Emprestimo BuscarPorId(int Id) =>
       _context.Emprestimo.Include(i => i.cliente).Include(i => i.funcionario).Include(i => i.Itens).FirstOrDefault(x => x.Id == Id);

        public static bool Remover(Emprestimo emprestimo)
        {
            try
            {
                _context.Emprestimo.Remove(emprestimo);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return true;
            }

        }
    }
}
