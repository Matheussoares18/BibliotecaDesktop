using Biblioteca.DAL;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.DAO
{
    class FuncionarioDAO
    {
        private static Context _context = SingletonContext.GetInstance();
        public static Funcionario BuscarPorcpf(string cpf) =>
           _context.Funcionarios.FirstOrDefault(x => x.cpf == cpf);
        public static List<Funcionario> Listar() =>
            _context.Funcionarios.ToList();


        public static bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorcpf(funcionario.cpf) == null)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
