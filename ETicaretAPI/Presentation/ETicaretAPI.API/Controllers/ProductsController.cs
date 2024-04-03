using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;

        private readonly ICustormerWriteRepository _custormerWriteRepository;
        
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustormerWriteRepository custormerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _custormerWriteRepository = custormerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        
        [HttpGet]
        public async Task Get()
        {
            // await _productWriteRepository.AddRangeAsync(new()
            // {
            //     new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
            //     new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20 },
            //     new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 130 }
            // });
            // var count = await _productWriteRepository.SaveAsync();
            
            // Product p = await _productReadRepository.GetByIdAsync("e9333990-19a5-492a-8be4-2907e8f4ffca", false);
            // p.Name = "Mehmet";
            // await _productWriteRepository.SaveAsync();

            // await _productWriteRepository.AddAsync(new() {Name = "C Product", Price = 1.500F, Stock = 10, CreatedDate = DateTime.UtcNow});
            // await _productWriteRepository.SaveAsync();

            // var customerId = Guid.NewGuid();
            // await _custormerWriteRepository.AddAsync(new() { Id = customerId, Name = "Muhiddin"});
            //
            // await _orderWriteRepository.AddAsync(new() { Description = "description", Address = "Ankara, Çankaya", CustomerId = customerId});
            // await _orderWriteRepository.AddAsync(new() { Description = "description 2", Address = "Ankara, Pursaklar" , CustomerId = customerId});
            // await _orderWriteRepository.SaveAsync();

            Order order = await _orderReadRepository.GetByIdAsync("3e0fddda-5f55-476d-959c-56a8b1184914");
            order.Address = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> Get(string id)
        // {
        //     Product product = await _productReadRepository.GetByIdAsync(id);
        //     return Ok(product);
        // }
    }
}
