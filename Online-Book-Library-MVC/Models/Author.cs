using System.ComponentModel.DataAnnotations;

namespace Online_Book_Library_MVC.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Bio { get; set; }
        public List<Book> Books { get; set; }
    }
}
