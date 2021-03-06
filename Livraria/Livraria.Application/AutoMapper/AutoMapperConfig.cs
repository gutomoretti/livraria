﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            }                
            );
        }
    }
}
