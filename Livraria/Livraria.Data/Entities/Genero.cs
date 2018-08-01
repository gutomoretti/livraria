using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Livraria.Application.Entities
{
    public class Genero
    {
    
        [Key]
        public int IdGenero { get; set; }
        public string Descricao { get; set; }
    }
}
