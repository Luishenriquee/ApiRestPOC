using System.Collections.Generic;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();

    }
}
