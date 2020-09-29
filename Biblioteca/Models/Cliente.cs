using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Controls.Primitives;

namespace Biblioteca.Models
{
    [Table("Cliente")]
    class Cliente
    {
        
        [Key]
        public int id { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }

        public string fullName { get; set; }

        public DateTime dateBirth { get; set; }

    }
}
