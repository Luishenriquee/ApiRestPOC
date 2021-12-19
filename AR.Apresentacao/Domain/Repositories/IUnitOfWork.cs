using System.Threading.Tasks;

namespace AR.Presentetion.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

    }
}
