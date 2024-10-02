using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Base;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public class BookService : EntityBaseRepository<Book>, IBookService
    {
        private readonly BookLibraryDbContext context;
        public BookService(BookLibraryDbContext context):base(context)
        {
        }

        /*public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            var result = await this.context.Books.Include(b => b.Publisher).ToListAsync();

            return result;
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(int id, Book newBook)
        {
            throw new NotImplementedException();
        }*/
    }
}
