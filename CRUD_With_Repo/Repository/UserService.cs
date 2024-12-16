using CRUD_With_Repo.Data;
using CRUD_With_Repo.Model; // Ensure this is the namespace of your User model
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

        //public async Task<IEnumerable<User>> GetUsersAsync()
        //{
        //    return await _context.Users.ToListAsync();
        //}

        Task<IEnumerable<Migrations.User>> IUser.GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
    }
