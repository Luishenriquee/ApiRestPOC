using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AR.Presentetion.Repositories;
using AR.Presentetion.Persistence.Context;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }

    }

}
