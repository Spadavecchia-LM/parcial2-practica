using Microsoft.EntityFrameworkCore;
using practicaParcial2.EF;
using practicaParcial2.Interfaces;

namespace practicaParcial2.Repositories
{
    public class UserRepository(MiDBContext _context) : IUserRepository
    {
        public Task<long> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeteleUserAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.Where(u => !u.IsDeleted).ToListAsync();
        }

        public Task<User> GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUserByLastName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserToShow(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(long userId, User userToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
