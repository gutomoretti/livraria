using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Livraria.Application.Entities
{
    public class Livro
    {
      
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
