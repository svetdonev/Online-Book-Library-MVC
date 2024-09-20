using Microsoft.AspNetCore.Mvc;
using Online_Book_Library_MVC.Models;
using Online_Book_Library_MVC.Services;

namespace Online_Book_Library_MVC.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorService authorService;
        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }
        public async Task<IActionResult> Index()
        {
            var allAuthors = await this.authorService.GetAllAsync();
            return View(allAuthors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, ImageUrl, Bio")]Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            await this.authorService.AddAsync(author);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await this.authorService.GetByIdAsync(id);

            if(authorDetails == null)
            {
                return View("Empty");
            }
            else
            {
                return View(authorDetails);
            }
        }
    }
}
