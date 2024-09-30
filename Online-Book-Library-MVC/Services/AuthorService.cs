using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Base;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public class AuthorService : EntityBaseRepository<Author>, IAuthorService
    {
        public AuthorService(BookLibraryDbContext context) :base(context)
        {
        }
    }
}
