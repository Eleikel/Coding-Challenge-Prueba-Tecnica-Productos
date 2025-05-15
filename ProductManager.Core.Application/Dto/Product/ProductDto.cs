using AutoMapper;
using ProductManager.Core.Application.Dto.Base;
using ProductManager.Core.Application.Dto.OrderItem;
using ProductManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Dto.Product
{
    public class ProductDto : IMapFrom<Domain.Entities.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        //public List<OrderItemDto>? OrderItems { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Product, ProductDto>();
            profile.CreateMap<ProductDto, Domain.Entities.Product>();
        }
    }
}
