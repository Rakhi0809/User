using CRUD_With_Repo.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_With_Repo.Data
{
    public class ApplicationContext:DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext>options) :base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
