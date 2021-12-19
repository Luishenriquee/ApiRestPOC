using System;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Repositories
{
    public interface IUserRepository
    {
        Task<User> FirstOrDefaultAsync(String login, String password);

    }
}
