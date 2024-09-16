using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;

namespace Online_Book_Library_MVC.Controllers
{
    public class PublishersController : Controller
    {
        private readonly BookLibraryDbContext context;
        public PublishersController(BookLibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPublishers = await context.Publishers.ToListAsync();
            return View(allPublishers);
        }
    }
}
