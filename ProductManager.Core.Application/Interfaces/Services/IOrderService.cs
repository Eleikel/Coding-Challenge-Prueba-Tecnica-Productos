using ProductManager.Core.Application.Dto.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Interfaces.Services
{
    public interface IOrderService: IGenericService<OrderDto>
    {
    }
}
