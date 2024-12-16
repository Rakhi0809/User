using CRUD_With_Repo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_With_Repo.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUser userRepository;

        public UserController(IUser userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersList()
        {
            var users = await userRepository.GetUsersAsync();
            return View(users);
        }
    }
}
