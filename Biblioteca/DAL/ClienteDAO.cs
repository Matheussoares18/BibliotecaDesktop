using Biblioteca.DAL;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.DAO
{
    class ClienteDAO
    {

        private static Context _context = SingletonContext.GetInstance();
        public static Cliente BuscarPorcpf(string cpf) =>
           _context.Cliente.FirstOrDefault(x => x.cpf == cpf);
        public static void userRegister(Cliente cliente)
        {
            if (BuscarPorcpf(cliente.cpf) == null)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
            }

        }

    }
}
