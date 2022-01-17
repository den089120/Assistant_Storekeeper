using Assistant_Storekeeper.Models;
using Assistant_Storekeeper.Models.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assistant_Storekeeper
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();

                config.CreateMap<MoveProductDto, MoveProduct>();
                config.CreateMap<MoveProduct, MoveProductDto>();
            });

            return mappingConfig;
        }
    }
}
