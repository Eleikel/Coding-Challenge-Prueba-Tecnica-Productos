using Microsoft.Extensions.DependencyInjection;
using ProductManager.Core.Application.Interfaces.Services;
using ProductManager.Core.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddAplicationLayer(IServiceCollection services)
        {

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();

        }
    }
}
