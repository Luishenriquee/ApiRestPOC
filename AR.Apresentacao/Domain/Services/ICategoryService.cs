using System.Collections.Generic;
using System.Threading.Tasks;
using AR.Presentetion.Communication;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        Task<IEnumerable<Category>> FindByNameAsync(string name);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);



    }
}
