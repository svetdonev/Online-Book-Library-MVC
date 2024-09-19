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
        public async Task Add(Author author)
        {
            await this.context.Authors.AddAsync(author);
            await this.context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var result = await this.context.Authors.ToListAsync();

            return result;
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Author Update(int id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
