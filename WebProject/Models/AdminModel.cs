using System.ComponentModel.DataAnnotations;
namespace WebProject.Models
{
    public class AdminModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
