using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        void AddBook(Book book);
        Book Update(int id, Book newBook);
        void Delete(int id);
    }
}
