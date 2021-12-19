using System.Collections.Generic;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();

    }
}
