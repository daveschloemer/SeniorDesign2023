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
                            Edition = "6",
                            Title = "Computer Networks: A Systems Approach",
                            ISBN = "978-0128182000",
                            Price = "$15.00",
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fcomputernetworks.jpg?alt=media&token=274bacf5-5064-4754-8d33-913845c68394"
                        },
                        new Book()         
                        {
                            Edition = "0",
                            Title = "IT Problem Management",
                            ISBN = "978-0130307705",
                            Price = "$6.50",
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FITProblemManagement.jpeg?alt=media&token=60e68456-c410-4e75-a75d-38c93503e9fa"
                        },
                        new Book()
                        {
                            Edition = "1",
                            Title = "IT Architecture For Dummies",
                            ISBN = "978-0470554234",
                            Price = "$11.47",
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fitdum.jpg?alt=media&token=99fd8c40-760d-4a78-a69d-31a4aea2c688"
                        },
                        new Book()
                        {
                            Edition = "3",
                            Title = "Game Design Workshop: A Playcentric Approach to Creating Innovative Games",
                            ISBN = "978-1-4822-1716-2",
                            Price = "$15.49",
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2Fcsharp.jpg?alt=media&token=191d5623-b438-43e1-a897-3f2e8f1bb750"
                        },
                        new Book()
                        {
                            Edition = "0",
                            Title = "Learn Microsoft PowerApps: Build customized business applications without writing any code",
                            ISBN = "978-1789805826",
                            Price = "$31.50",
                            imagesURL ="https://firebasestorage.googleapis.com/v0/b/ucfreshbooks.appspot.com/o/images%2FPA.jpg?alt=media&token=ec5f7e27-5129-4dfa-a026-544e4029b0ff"
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
                            Name ="Larry L. Peterson and Bruce S. Davie",
                            Bio = "Computer Networks: A Systems Approach"
                        },
                        new Author()
                        {
                            Name ="Gary Walker",
                            Bio = "IT Problem Management"
                        },
                        new Author()
                        {
                            Name ="Kalani Kirk Hausman and Susan Cook",
                            Bio = "IT Architecture For Dummies"
                        },
                        new Author()
                        {
                            Name ="Tracy Fullerton",
                            Bio = "Game Design Workshop: A Playcentric Approach to Creating Innovative Games"
                        },
                        new Author()
                        {
                            Name ="Matthew Weston",
                            Bio = "Learn Microsoft PowerApps: Build customized business applications without writing any code"
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
                            Subjects = "Information Technology"
                        },
                        new Subject()
                        {
                            Subjects = "Information Technology"
                        },
                        new Subject()
                        {
                            Subjects = "Information Technology"
                        },
                        new Subject()
                        {
                            Subjects = "Information Technology"
                        },
                        new Subject()
                        {
                            Subjects = "Information Technology"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
