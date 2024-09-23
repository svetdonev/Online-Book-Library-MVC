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
        public async Task AddAsync(Publisher publisher)
        {
            await this.context.Publishers.AddAsync(publisher);
            await this.context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Publisher>> GetAllAsync()
        {
            var result = await this.context.Publishers.ToListAsync();

            return result;
        }

        public async Task<Publisher> GetByIdAsync(int id)
        {
            var result = await this.context.Publishers.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Publisher> UpdateAsync(int id, Publisher newPublisher)
        {
            this.context.Update(newPublisher);
            await this.context.SaveChangesAsync();
            return newPublisher;
        }
    }
}
