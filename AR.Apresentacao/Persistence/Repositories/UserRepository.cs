using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AR.Presentetion.Repositories;
using AR.Presentetion.Persistence.Context;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
        }

    }

}
