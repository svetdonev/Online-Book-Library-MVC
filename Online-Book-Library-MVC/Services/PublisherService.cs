using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly BookLibraryDbContext context;
        public PublisherService(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public void AddBook(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            var result = await this.context.Publishers.ToListAsync();

            return result;
        }

        public Publisher GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Publisher Update(int id, Publisher newPublisher)
        {
            throw new NotImplementedException();
        }
    }
}
