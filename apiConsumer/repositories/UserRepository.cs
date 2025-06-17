using apiConsumer.Interfaces;

using Models;

namespace apiConsumer.repositories
{
    public class UserRepository(IApiConnector _apiConnector) : IUserRepository
    {
        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            return await _apiConnector.GetAsync<List<UserModel>>("/User/GetAllUsers");
        }
    }
}
