using System.ComponentModel.DataAnnotations;
namespace WebProject.Models
{
    public class AuthorModel
    {
        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
    }
}
