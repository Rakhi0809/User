using CRUD_With_Repo.Model;

namespace CRUD_With_Repo.Repository
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
