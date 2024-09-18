using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAll();
        Author GetById(int id);
        void AddBook(Author author);
        Author Update(int id, Author newAuthor);
        void Delete(int id);
    }
}
