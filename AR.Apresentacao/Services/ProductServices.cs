using System.Collections.Generic;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;
using AR.Presentetion.Repositories;

namespace AR.Presentetion.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }

}
