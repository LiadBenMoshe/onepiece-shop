using AutoMapper;
using OnePiece.Services.ProductAPI.Models;
using OnePiece.Services.ProductAPI.Models.Dto;

namespace OnePiece.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
