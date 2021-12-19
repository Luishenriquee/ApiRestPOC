using System;
using System.Threading.Tasks;
using AR.Presentetion.Domain.Models;
using AR.Presentetion.Repositories;

namespace AR.Presentetion.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> FirstOrDefaultAsync(String login, String password)
        {
            return await _userRepository.FirstOrDefaultAsync(login, password);
        }
    }

}
