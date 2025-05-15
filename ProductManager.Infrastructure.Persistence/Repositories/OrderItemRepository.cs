using ProductManager.Core.Application.Interfaces.Repositories;
using ProductManager.Core.Domain.Entities;
using ProductManager.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Infrastructure.Persistence.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        private readonly ApplicationContext _context;
        public OrderItemRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
