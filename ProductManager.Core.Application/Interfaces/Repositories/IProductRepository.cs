﻿using ProductManager.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository: IGenericRepository<Product>
    {
    }
}
