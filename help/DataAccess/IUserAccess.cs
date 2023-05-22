using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{

    public interface IUserDataAccess
    {
        public Task AddUserAsync(User user);
        public Task<IList<User>> GetAllUsersAsync();

        public Task<User> GetUserById(int userId);
        public Task<User> GetUserByEmailAsync(string email);
    }
}