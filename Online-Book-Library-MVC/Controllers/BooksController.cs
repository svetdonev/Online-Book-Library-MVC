using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;
using Online_Book_Library_MVC.Services;

namespace Online_Book_Library_MVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService bookService;
        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var allbooks = await this.bookService.GetAllAsync(x => x.Publisher);
            return View(allbooks);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await this.bookService.GetByIdAsync(id);
            return View(movieDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCreateViewModel book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await bookService.AddBookAsync(book);

            return RedirectToAction(nameof(Index));
        }
    }
}
