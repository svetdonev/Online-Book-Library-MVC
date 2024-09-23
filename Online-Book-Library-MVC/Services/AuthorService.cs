using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BookLibraryDbContext context;
        public AuthorService(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Author author)
        {
            await this.context.Authors.AddAsync(author);
            await this.context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            var result = await this.context.Authors.ToListAsync();

            return result;
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            var result = await this.context.Authors.FirstOrDefaultAsync(a => a.Id == id);
            return result;
        }

        public async Task<Author> UpdateAsync(int id, Author newAuthor)
        {
            this.context.Update(newAuthor);
            await this.context.SaveChangesAsync();
            return newAuthor;
        }
    }
}
