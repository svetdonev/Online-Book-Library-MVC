using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;

namespace Online_Book_Library_MVC.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly BookLibraryDbContext context;
        public AuthorsController(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allAuthors = await context.Authors.ToListAsync();
            return View(allAuthors);
        }
    }
}
