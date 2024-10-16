﻿using Online_Book_Library_MVC.Base;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public interface IBookService : IEntityBaseRepository<Book>
    {
        Task<Book> GetByIdAsync(int id);
        Task AddBookAsync(BookCreateViewModel book);
    }
}
