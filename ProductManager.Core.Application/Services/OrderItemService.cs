using AutoMapper;
using ProductManager.Core.Application.Dto.OrderItem;
using ProductManager.Core.Application.Interfaces.Repositories;
using ProductManager.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        public IMapper _mapper;

        public OrderItemService(IOrderRepository orderRepository, IProductRepository productRepository, IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public Task Add(OrderItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderItemDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(OrderItemDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
