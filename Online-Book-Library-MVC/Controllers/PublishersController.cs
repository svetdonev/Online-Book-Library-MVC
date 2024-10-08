﻿using Microsoft.AspNetCore.Mvc;
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
            var allPublishers = await this.publisherService.GetAllAsync();
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

            await this.publisherService.AddAsync(publisher);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var publisherDetails = await this.publisherService.GetByIdAsync(id);

            if(publisherDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(publisherDetails);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var publisherDetails = await this.publisherService.GetByIdAsync(id);

            if (publisherDetails == null)
            {
                return View("NotFound");
            }

            return View(publisherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View(publisher);
            }

            await this.publisherService.UpdateAsync(id, publisher);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var publisherDetails = await this.publisherService.GetByIdAsync(id);

            if (publisherDetails == null)
            {
                return View("NotFound");
            }

            return View(publisherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherDetails = this.publisherService.GetByIdAsync(id);

            if (publisherDetails == null)
            {
                return View("NotFound");
            }

            await this.publisherService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
