using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Cliente")]
    class Cliente : BaseModel
    {


        public string cpf { get; set; }
        public string email { get; set; }

        public string fullName { get; set; }

        public int celular { get; set; }

        public DateTime dateBirth { get; set; }

        public int telefone { get; set; }

        public Boolean multa { get; set; }

    }
}
