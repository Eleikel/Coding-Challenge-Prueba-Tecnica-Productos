using AutoMapper;
using ProductManager.Core.Application.Dto.Order;
using ProductManager.Core.Application.Dto.OrderItem;
using ProductManager.Core.Application.Interfaces.Repositories;
using ProductManager.Core.Application.Interfaces.Services;
using ProductManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        public IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(OrderDto dto)
        {
            foreach (var item in dto.OrderItems)
            {
                var product = await _productRepository.GetByIdAsync(item.ProductId);

                if (product == null)
                {
                    throw new Exception($"El Producto con Id {item.ProductId} no existe.");
                }

                if (item.Quantity > product.Stock)
                {
                    throw new Exception($"Stock insuficiente para el producto '{product.Name}'.");
                }

                product.Stock -= item.Quantity;
            }

            var order = new Order
            {
                Date = DateTime.UtcNow,
                CustomerName = dto.CustomerName,
                OrderItems = dto.OrderItems.Select(x => new OrderItem
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                }).ToList()
            };

            await _orderRepository.AddAsync(order);
        }


        public async Task<OrderDto> GetById(int id)
        {
            var order = await _orderRepository.GetByIdAsyncWithFilter(x => x.Id == id, x => x.OrderItems);
            return _mapper.Map<OrderDto>(order);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(OrderDto dto)
        {
            throw new NotImplementedException();
        }

    }

}
