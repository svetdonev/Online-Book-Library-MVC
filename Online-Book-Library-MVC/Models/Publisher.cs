using Online_Book_Library_MVC.Base;
using System.ComponentModel.DataAnnotations;

namespace Online_Book_Library_MVC.Models
{
    public class Publisher : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
