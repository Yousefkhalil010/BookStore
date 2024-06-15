using System.ComponentModel.DataAnnotations;
namespace WebProject.Models
{
    public class GenreModel
    {
        [Key]
        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}
