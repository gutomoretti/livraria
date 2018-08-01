using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.ViewModel
{
    public class GeneroViewModel
    {
        public GeneroViewModel()
        {
            IdGenero = Guid.NewGuid();
        }

        public Guid IdGenero { get; set; }
        public string Descricao { get; set; }
    }
}
