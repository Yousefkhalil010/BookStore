using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class UserModel
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
