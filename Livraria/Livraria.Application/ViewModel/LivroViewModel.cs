using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.ViewModel
{
    public class LivroViewModel
    {
        public LivroViewModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public GeneroViewModel Genero { get; set; }
    }
}
