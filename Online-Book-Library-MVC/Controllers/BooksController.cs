using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;

namespace Online_Book_Library_MVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookLibraryDbContext context;
        public BooksController(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allbooks = await context.Books.Include(b => b.Publisher).ToListAsync();
            return View(allbooks);
        }
    }
}
