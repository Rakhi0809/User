using System.ComponentModel.DataAnnotations;

namespace CRUD_With_Repo.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = default!;
        public string Gender { get; set; } = default!;

        public string Email { get; set; } = default!;
        public int Pincode { get; set; } 

        public bool Isactive { get; set; }


    }
}
