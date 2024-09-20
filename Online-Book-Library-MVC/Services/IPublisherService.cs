using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAll();
        Publisher GetById(int id);
        Task Add(Publisher publisher);
        Publisher Update(int id, Publisher newPublisher);
        void Delete(int id);
    }
}
