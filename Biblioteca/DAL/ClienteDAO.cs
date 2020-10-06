using Biblioteca.DAL;
using Biblioteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.DAO
{
    class ClienteDAO
    {

        private static Context _context = SingletonContext.GetInstance();
        public static Cliente BuscarPorcpf(string cpf) =>
           _context.Cliente.FirstOrDefault(x => x.cpf == cpf);

        public static Cliente BuscarPorId(int Id) =>
          _context.Cliente.Find(Id);

        public static bool Alterar(Cliente cliente)
        {
            try
            {
                _context.Cliente.Update(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static List<Cliente> Listar() =>
          _context.Cliente.ToList();
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
