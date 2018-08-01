using AutoMapper;
using Livraria.Application.ViewModel;
using Livraria.Application.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<LivroViewModel, Livro>();
            CreateMap<GeneroViewModel, Genero>();
        }
    }
}
