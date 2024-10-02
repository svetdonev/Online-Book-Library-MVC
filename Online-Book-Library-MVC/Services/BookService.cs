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
            this.context = context;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var bookDetails = this.context.Books
                .Include(a => a.Author)
                .Include(p => p.Publisher)
                .FirstOrDefaultAsync(x => x.Id == id);

            return await bookDetails;
        }
    }
}
