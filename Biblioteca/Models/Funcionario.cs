using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblioteca.Models
{
    [Table("Funcionario")]
    class Funcionario
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string email { get; set; }
        
        public DateTime dataNasc { get; set; }

    }
}
