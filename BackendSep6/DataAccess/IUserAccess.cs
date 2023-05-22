using System.Collections.Generic;
using System.Threading.Tasks;
using BackendSep6.Model;

namespace BackendSep6.DataAccess
{

    public interface IUserDataAccess
    {
        public Task AddUserAsync(User user);
        public Task<IList<User>> GetAllUsersAsync();

        public Task<User> GetUserById(int userId);
        public Task<User> GetUserByEmailAsync(string email);
    }
}