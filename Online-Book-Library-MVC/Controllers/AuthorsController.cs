﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Data;
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
            var allAuthors = await this.authorService.GetAll();
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

            await this.authorService.Add(author);
            return RedirectToAction(nameof(Index));
        }

    }
}
