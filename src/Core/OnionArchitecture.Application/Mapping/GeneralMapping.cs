﻿using AutoMapper;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Features.Commands.CreateProduct;
using OnionArchitecture.Application.Features.Queries.GetAllProducts;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>()
                .ReverseMap();

            CreateMap<Product, CreateProductCommand>()
                .ReverseMap();

            CreateMap<Product, GetProductByIdViewModel>()
                .ReverseMap();

        }
    }
}
