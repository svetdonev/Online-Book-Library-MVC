using Online_Book_Library_MVC.Models;

namespace Online_Book_Library_MVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookLibraryDbContext>();

                context.Database.EnsureCreated();

                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "Stephen King",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFNn6FcqJgnTCBDjX9vK_qRnle-dHO1Jp7uEEqISfNOm8bbjoW",
                            Bio = "Stephen Edwin King is an American author. Widely known for his horror novels, he has been crowned the \"King of Horror\". He has also explored other genres, among them suspense, crime, science-fiction, fantasy and mystery.",

                        },
                        new Author()
                        {
                            Name = "J. K. Rowling",
                            ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS3bDP-AbnH7l2pjO-SwJkEFQu9dxDE6V8wyJ_5x_lfkVpTMA80",
                            Bio = "Joanne Rowling CH OBE FRSL, known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume fantasy series published from 1997 to 2007.",

                        },
                        new Author()
                        {
                            Name = "Paulo Coelho",
                            ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQKOnWtqrxRinYcXQKOapXL4uAp6Ict7z3d6ZdBg2zO5JsQ2Wrg",
                            Bio = "Paulo Coelho de Souza is a Brazilian lyricist and novelist and a member of the Brazilian Academy of Letters since 2002. His 1988 novel The Alchemist was an international best-seller.",

                        },
                        new Author()
                        {
                            Name = "Michael Crichton",
                            ImageUrl = "https://images.gr-assets.com/authors/1359042651p5/5194.jpg",
                            Bio = "Michael Crichton (1942-2008) was one of the most successful novelists of his generation, admired for his meticulous scientific research and fast-paced narrative.",

                        },
                        new Author()
                        {
                            Name = "Suzanne Collins",
                            ImageUrl = "https://images.gr-assets.com/authors/1630199330p5/153394.jpg",
                            Bio = "Since 1991, Suzanne Collins has been busy writing for children’s television. She has worked on the staffs of several Nickelodeon shows, including the Emmy-nominated hit Clarissa Explains it All and The Mystery Files of Shelby Woo.",

                        },
                    });

                    context.SaveChanges();
                }

                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                    {
                        Name = "Random House",
                        Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bc/Random_House_logo.svg/220px-Random_House_logo.svg.png",
                        Description = "Random House is an imprint and publishing group of Penguin Random House. Founded in 1927 by businessmen Bennett Cerf and Donald Klopfer as an imprint of Modern Library, it quickly overtook Modern Library as the parent imprint."
                    },
                        new Publisher()
                    {
                        Name = "BCA",
                        Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f9/Book_Club_Associates_logo.jpg/220px-Book_Club_Associates_logo.jpg",
                        Description = "Book Club Associates (BCA) was a mail-order and online book selling company in the United Kingdom. It came to dominate the mail-order book-club business in the U.K. in the 1970s and 1980s through extensive advertising in Sunday newspaper colour supplements and elsewhere, and became the largest mail-order bookseller in the U.K. The firm collapsed in 2012."
                    },
                        new Publisher()
                    {
                        Name = "HarperOne",
                        Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/1/15/HarperOne_logo.png/220px-HarperOne_logo.png",
                        Description = "HarperOne is a publishing imprint of HarperCollins, specializing in books that aim to \"transform, inspire, change lives, and influence cultural discussions.\" Under the original name of Harper San Francisco."
                    },
                        new Publisher()
                    {
                        Name = "Scribner",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Scribner-building.jpg/220px-Scribner-building.jpg",
                        Description = "Charles Scribner's Sons, or simply Scribner's or Scribner, is an American publisher based in New York City, known for publishing American authors."
                    },
                        new Publisher()
                    {
                        Name = "Scholastic Corporation",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Scholastic_Headquarters_by_Matthew_Bisanz.JPG/220px-Scholastic_Headquarters_by_Matthew_Bisanz.JPG",
                        Description = "Scholastic Corporation is an American multinational publishing, education, and media company that publishes and distributes books, comics, and educational materials for schools, teachers, parents, children, and other educational institutions."
                    }
                    });

                    context.SaveChanges();

                }

                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "The Institute",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/00/The_Institute_%28King_novel%29.png/220px-The_Institute_%28King_novel%29.png",
                            Price = 19.99,
                            Resume = "The Institute is a 2019 American science fiction-horror thriller novel by Stephen King, published by Scribner. The book follows twelve-year-old genius Luke Ellis. When his parents are murdered, he is kidnapped by intruders and awakens in the Institute, a facility that houses other abducted children who have telepathy or telekinesis.",
                            BookGenre = Enums.BookGenre.Thriller,
                            Pages = 561,
                            PublishedYear = 2019,
                            PublisherId = 4,
                            AuthorId = 1,

                        },
                        new Book()
                        {
                            Name = "Harry Potter and the Half-Blood Prince\r\n",
                            ImageUrl = "https://m.media-amazon.com/images/I/61sXBXmAWML._AC_UF1000,1000_QL80_.jpg",
                            Price = 24.50,
                            Resume = "Harry Potter and the Half-Blood Prince is a fantasy novel written by the British author J. K. Rowling. It is the sixth novel in the Harry Potter series, and takes place during Harry Potter's sixth year at the wizard school Hogwarts. The novel reveals events from the early life of Lord Voldemort, and chronicles Harry's preparations for the final battle against him.",
                            BookGenre = Enums.BookGenre.Fantasy,
                            Pages = 652,
                            PublishedYear = 2005,
                            PublisherId = 5,
                            AuthorId = 2
                        },
                        new Book()
                        {
                            Name = "The Alchemist",
                            ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/ed319127309205.56363c472b271.png",
                            Price = 14.50,
                            Resume = "The Alchemist is a adventure novel by Brazilian author Paulo Coelho which was first published in 1988. Originally written in Portuguese, it became a widely translated international bestseller. The story follows the shepherd boy Santiago in his journey across North Africa to the Egyptian pyramids after he dreams of finding a treasure there.",
                            BookGenre = Enums.BookGenre.Adventure,
                            Pages = 197,
                            PublishedYear = 2006,
                            PublisherId = 3,
                            AuthorId = 3
                        },
                        new Book()
                        {
                            Name = "Jurassic Park",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/21/Jurassic_Park_%28book_cover%29.jpg/220px-Jurassic_Park_%28book_cover%29.jpg",
                            Price = 17.90,
                            Resume = "Jurassic Park is a 1990 science fiction novel written by Michael Crichton.[2] A cautionary tale about genetic engineering, it presents the collapse of a zoological park showcasing genetically recreated dinosaurs to illustrate the mathematical concept of chaos theory[3] and its real-world implications.",
                            BookGenre = Enums.BookGenre.Fantasy,
                            Pages = 401,
                            PublishedYear = 1993,
                            PublisherId = 2,
                            AuthorId = 4
                        }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
