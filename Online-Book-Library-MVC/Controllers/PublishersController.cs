using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;
using Online_Book_Library_MVC.Services;

namespace Online_Book_Library_MVC.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublisherService publisherService;
        public PublishersController(IPublisherService publisherService)
        {
            this.publisherService = publisherService;
        }
        public async Task<IActionResult> Index()
        {
            var allPublishers = await this.publisherService.GetAll();
            return View(allPublishers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View(publisher);
            }

            await this.publisherService.Add(publisher);
            return RedirectToAction(nameof(Index));
        }
    }
}
