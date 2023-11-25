using IaOrganization.Services;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Model;

namespace IaOrganization.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
            return Ok( await _userService.GetAllUserAsync());
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User request)
        {
            return Ok(await _userService.AddNewUserAsync(request));
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetAUser(string email)
        {
            return Ok(await _userService.GetASingleUserAsync(email));
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(UpdateUser request, string email)
        {
            return Ok(await _userService.UpdateUserAsync(request, email));
        }

        [HttpDelete]
        public async Task<ActionResult<User>> DeleteAUser(string email)
        {
            return Ok(await _userService.DeleteUserAsync(email));
        }
    }
}
