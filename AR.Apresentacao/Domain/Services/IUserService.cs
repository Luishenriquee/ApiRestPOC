using System;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Services
{
    public interface IUserService
    {
        Task<User> FirstOrDefaultAsync(String login, String password);

    }
}
