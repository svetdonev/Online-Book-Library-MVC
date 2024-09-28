using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAllAsync();
        Task<Publisher> GetByIdAsync(int id);
        Task AddAsync(Publisher publisher);
        Task<Publisher> UpdateAsync(int id, Publisher newPublisher);
        Task DeleteAsync(int id);
    }
}
