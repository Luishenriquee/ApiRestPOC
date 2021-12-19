using System.Collections.Generic;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;


namespace AR.Presentetion.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);

        Task<IEnumerable<Category>> FindByNameAsync(string name);
        void Update(Category category);
        void Remove(Category category);


    }
}
