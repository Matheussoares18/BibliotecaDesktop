using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
    class Emprestimo :BaseModel
    {
        public Emprestimo()
        {
            cliente = new Cliente();
            Itens = new List<LivroEmprestimo>();
            funcionario = new Funcionario();
        }
        public Cliente cliente { set; get; }
        public Funcionario funcionario { set; get; }

        public DateTime dataDevolucao { set; get; }

        public Boolean devolvido { set; get; }

        public List<LivroEmprestimo> Itens { get; set; }


    }
}
