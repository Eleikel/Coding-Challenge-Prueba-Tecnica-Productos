using AutoMapper;
using ProductManager.Core.Application.Dto.Base;
using ProductManager.Core.Application.Dto.Order;
using ProductManager.Core.Application.Dto.Product;
using ProductManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Dto.OrderItem
{
    public class OrderItemDto : IMapFrom<Domain.Entities.OrderItem>
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.OrderItem, OrderItemDto>();
            profile.CreateMap<OrderItemDto, Domain.Entities.OrderItem>();

        }
    }
}
