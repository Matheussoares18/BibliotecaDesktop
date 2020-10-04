using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
    class ContatosCliente : BaseModel
    {
        public int telefone { get; set; }

        public int clienteId { get; set; }
        public Cliente cliente { get; set; }
      
    }
}
