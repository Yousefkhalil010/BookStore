using System.ComponentModel.DataAnnotations;
namespace WebProject.Models
{
    public class BookModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string Description { get; set; }
        public int GenreID { get; set; }
        public string BookPath { get; set; }
        public string ImagePath { get; set; }
        public AuthorModel Author { get; set; }
        public GenreModel Genre { get; set; }
    }
}
