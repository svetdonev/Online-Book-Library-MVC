﻿using Online_Book_Library_MVC.Base;
using System.ComponentModel.DataAnnotations;

namespace Online_Book_Library_MVC.Models
{
    public class Author : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Author Name")]
        public string Name { get; set; }
        [Display(Name = "Author Picture")]
        public string ImageUrl { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
