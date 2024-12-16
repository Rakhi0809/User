using CRUD_With_Repo.Data;
using CRUD_With_Repo.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_With_Repo.Repository
{
    public class UserService : IUser
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

       
    }
}
