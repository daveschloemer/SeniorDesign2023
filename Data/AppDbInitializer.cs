using FreshBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshBooks.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookDbContext>();
                context.Database.EnsureDeleted();

                //Books
                if(!context.Book.Any())
                {
                    context.Book.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Edition = "",
                            Title = "",
                            ISBN = "",
                            Price = "",
                            imagesURL =""
                        },
                        new Book()
                        {
                            Edition = "",
                            Title = "",
                            ISBN = "",
                            Price = "",
                            imagesURL =""
                        },
                        new Book()
                        {
                            Edition = "",
                            Title = "",
                            ISBN = "",
                            Price = "",
                            imagesURL =""
                        },
                        new Book()
                        {
                            Edition = "",
                            Title = "",
                            ISBN = "",
                            Price = "",
                            imagesURL =""
                        },
                        new Book()
                        {
                            Edition = "",
                            Title = "",
                            ISBN = "",
                            Price = "",
                            imagesURL =""
                        }

                    });
                    context.SaveChanges();
                }
                //Authors
                if(!context.Author.Any())
                {
                    context.Author.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name ="",
                            Bio = ""
                        },
                        new Author()
                        {
                            Name ="",
                            Bio = ""
                        },
                        new Author()
                        {
                            Name ="",
                            Bio = ""
                        },
                        new Author()
                        {
                            Name ="",
                            Bio = ""
                        },
                        new Author()
                        {
                            Name ="",
                            Bio = ""
                        }
                    });
                    context.SaveChanges();
                }
                //Author_Books
                if (!context.Author_Books.Any())
                {
                    context.Author_Books.AddRange(new List<Author_Books>()
                    {
                        new Author_Books()
                        {
                            BookId = 1,
                            AuthorId= 1
                        },
                        new Author_Books()
                        {
                            BookId = 2,
                            AuthorId= 2
                        },
                        new Author_Books()
                        {
                            BookId = 3,
                            AuthorId= 3
                        },
                        new Author_Books()
                        {
                            BookId = 4,
                            AuthorId= 4
                        },
                        new Author_Books()
                        {
                            BookId = 5,
                            AuthorId= 5
                        }
                    });
                    context.SaveChanges();
                }
                //Subject
                if (!context.Subject.Any())
                {
                    context.Subject.AddRange(new List<Subject>()
                    {
                        new Subject()
                        {
                            Subjects = ""
                        },
                        new Subject()
                        {
                            Subjects = ""
                        },
                        new Subject()
                        {
                            Subjects = ""
                        },
                        new Subject()
                        {
                            Subjects = ""
                        },
                        new Subject()
                        {
                            Subjects = ""
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
