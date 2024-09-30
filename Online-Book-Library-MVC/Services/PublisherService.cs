using Microsoft.EntityFrameworkCore;
using Online_Book_Library_MVC.Base;
using Online_Book_Library_MVC.Data;
using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Services
{
    public class PublisherService : EntityBaseRepository<Publisher>, IPublisherService
    {
        public PublisherService(BookLibraryDbContext context) : base(context)
        {
        }
    }
}
