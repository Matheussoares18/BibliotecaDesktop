using Biblioteca.DAL;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.DAL
{
    class LivroDAO
    {

        private static Context _context = SingletonContext.GetInstance();
        public static Livro BuscarPorisbn(string isbn) => _context.Livro.FirstOrDefault(x => x.isbn == isbn);

        public static List<Livro> Listar() =>
        _context.Livro.ToList();

        public static Livro BuscarPorId(int Id) =>
        _context.Livro.Find(Id);

        public static void BookRegister(Livro livro)
        {
            if (BuscarPorisbn(livro.isbn) == null)
            {
                _context.Livro.Add(livro);
                _context.SaveChanges();
            }



        }

    }
}
