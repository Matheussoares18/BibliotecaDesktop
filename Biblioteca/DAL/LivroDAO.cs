using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.DAL
{
    class LivroDAO
    {

        private static Context _context = SingletonContext.GetInstance();
        public static Livro BuscarPorisbn(string isbn) => _context.Livro.FirstOrDefault(x => x.isbn == isbn);

        public static List<Livro> Listar() =>
        _context.Livro.ToList();

        public static bool Alterar(Livro livro)
        {
            try
            {
                _context.Livro.Update(livro);
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }


        public static Livro BuscarPorId(int Id) =>
        _context.Livro.Find(Id);

        public static async System.Threading.Tasks.Task BookRegisterAsync(Livro livro)
        {
            try
            {
                await _context.Livro.AddAsync(livro);
                _context.SaveChanges();

            }
            catch
            {
                Console.WriteLine("n foi");
            }

        }

    }
}
