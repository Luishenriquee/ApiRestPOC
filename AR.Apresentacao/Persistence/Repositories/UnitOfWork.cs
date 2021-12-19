using AR.Presentetion.Persistence.Context;
using AR.Presentetion.Repositories;
using System.Threading.Tasks;

namespace AR.Presentetion.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
