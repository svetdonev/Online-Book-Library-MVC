using System.ComponentModel.DataAnnotations;

namespace Online_Book_Library_MVC.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Author Picture")]
        public string ImageUrl { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Book> Books { get; set; }
    }
}
