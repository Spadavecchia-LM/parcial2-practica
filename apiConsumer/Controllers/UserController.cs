using apiConsumer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apiConsumer.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserRepository _userRepository) : ControllerBase
    {

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var results = await _userRepository.GetAllUsersAsync();
            if (results == null) { return NotFound(); }
            return Ok(results);
        }

    }
}
