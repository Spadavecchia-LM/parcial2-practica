using Models;
using practicaParcial2.Interfaces;

namespace practicaParcial2.Services
{
    public class UserService(IUserRepository _userRepository) : IUserService
    {
        public Task<long> CreateUserAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();

            return users.Select(u => new UserModel
            {
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                Dni = u.Dni,
            }).ToList();
        }

        public Task<UserModel?> GetUserByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetUserByLastNameAsync(string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(long userId, UserModel userToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
