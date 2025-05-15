using AutoMapper;
using ProductManager.Core.Application.Dto.Product;
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
    public class ProductService: IProductService
    {
        public readonly IProductRepository _productRepository;
        public IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
       

        public async Task Add(ProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);
        }

        public async Task Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public Task Update(ProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            return _productRepository.UpdateAsync(product);
        }
    }
   
}
