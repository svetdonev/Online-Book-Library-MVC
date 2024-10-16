﻿using Online_Book_Library_MVC.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Book_Library_MVC.Models
{
    public class BookCreateViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Book name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Resume is required")]
        [Display(Name = "Book resume")]
        public string Resume { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Book price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Published Year is required")]
        [Display(Name = "Book published year")]
        public int PublishedYear { get; set; }

        [Required(ErrorMessage = "Pages field is required")]
        [Display(Name = "Book pages")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "Book Genre is required")]
        [Display(Name = "Select a genre:")]
        public BookGenre BookGenre { get; set; }

        [Required(ErrorMessage = "Book publisher is required")]
        [Display(Name = "Book publisher")]
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "Book author is required")]
        [Display(Name = "Book author")]
        public int AuthorId { get; set; }
    }
}
