using Microsoft.AspNetCore.Mvc;
using practicaParcial2.Interfaces;

namespace practicaParcial2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService _userService) : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            if (users == null || !users.Any())
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }
      
    }
}
