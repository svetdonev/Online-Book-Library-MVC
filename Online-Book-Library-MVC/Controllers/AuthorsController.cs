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
                return View("NotFound");
            }
            else
            {
                return View(authorDetails);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await this.authorService.GetByIdAsync(id);

            if (authorDetails == null)
            {
                return View("NotFound");
            }

            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, ImageUrl, Bio")] Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            await this.authorService.UpdateAsync(id, author);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await this.authorService.GetByIdAsync(id);

            if (authorDetails == null)
            {
                return View("NotFound");
            }

            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorDetails = this.authorService.GetByIdAsync(id);

            if(authorDetails == null)
            {
                return View("NotFound");
            }

            await this.authorService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
