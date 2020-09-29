using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.DAO
{
    class ClienteDal
    {
        private static Context _context = new Context();
        public static void userRegister (Cliente cliente)
        {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
             
            
         
        }

    }
}
