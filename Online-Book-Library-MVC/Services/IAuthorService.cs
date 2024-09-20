using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Author Update(int id, Author newAuthor);
        void Delete(int id);
    }
}
