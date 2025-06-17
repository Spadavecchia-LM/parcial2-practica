using Models;

namespace apiConsumer.Interfaces
{
    public interface IUserRepository
    {
       Task<List<UserModel>> GetAllUsersAsync();
    }
}
