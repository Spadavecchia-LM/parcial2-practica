

using Models;

namespace practicaParcial2.Interfaces
{
    public interface IUserService
    {
        Task<long> CreateUserAsync(UserModel user);
        Task<List<UserModel>> GetAllUsersAsync();
        Task<UserModel?> GetUserByIdAsync(long id);
        Task<List<UserModel>> GetUserByLastNameAsync(string lastName);
        Task<bool> DeleteUserAsync(long userId);
        Task<bool> UpdateUserAsync(long userId, UserModel userToUpdate);
    }
}
