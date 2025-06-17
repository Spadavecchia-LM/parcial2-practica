using practicaParcial2.EF;

namespace practicaParcial2.Interfaces
{
    public interface IUserRepository
    {
        Task<long> CreateUser(User user);
        Task<List<User>> GetAllUsersAsync();
        Task<EF.User> GetUserById(long id);
        Task<List<User>> GetUserByLastName(string name);
        Task<User?> GetUserToShow(long id);

        Task<bool> DeteleUserAsync(long userId);
        Task<bool> UpdateUserAsync(long userId, User userToUpdate);
    }
}
