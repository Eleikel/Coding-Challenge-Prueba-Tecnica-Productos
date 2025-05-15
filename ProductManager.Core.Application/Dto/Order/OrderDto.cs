using AutoMapper;
using ProductManager.Core.Application.Dto.Base;
using ProductManager.Core.Application.Dto.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Dto.Order
{
    public class OrderDto : IMapFrom<Domain.Entities.Order>
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItemDto>? OrderItems { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Order, OrderDto>();
            profile.CreateMap<OrderDto, Domain.Entities.Order> ();

        }
    }
}
