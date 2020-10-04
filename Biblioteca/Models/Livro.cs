using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Controls.Primitives;

namespace Biblioteca.Models
{

    [Table("Livro")]
    class Livro : BaseModel
    {


        public string titulo { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string isbn { get; set; }
        public string ano { get; set; }
        public string editora { get; set; }

    }
}

