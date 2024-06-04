using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.Models
{
    public class SeedData
    {
        public int Id { get; set; }
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>()))
            {
                if (context.Book.Any())    // Check if database contains any books
                {
                    return;     // Database contains books already
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Ape Gama",
                        Description = "Martin's Novel",  
                        Language = "Sinhala",
                        ISBN = "9789129688313",
                        DatePublished = DateTime.Parse("1963-9-26"),
                        Price = 150,
                        Author = "Martin Wickramasinghe",
                        ImageUrl = "/images/ape-gama.jpg"
                    },
                    new Book
                    {
                        Title = "Abhirahas Dosthara",
                        Description = "Detective Novel",
                        Language = "Sinhala",
                        ISBN = "9789129688314",
                        DatePublished = DateTime.Parse("2003-9-26"),
                        Price = 200,
                        Author = "Chandana Mendis",
                        ImageUrl = "/images/abhirahas-dosthara.jpg"
                    },
                    new Book
                    {
                        Title = "Modol Doova",
                        Description = "Martin's Novel",
                        Language = "Sinhala",
                        ISBN = "9789129688315",
                        DatePublished = DateTime.Parse("1965-9-26"),
                        Price = 150,
                        Author = "Martin Wickramasinghe",
                        ImageUrl = "/images/madol-doova.jpg"
                    },
                    new Book
                    {
                        Title = "Dhammapadaya",
                        Description = "Buddhism",
                        Language = "Paali",
                        ISBN = "9789129688316",
                        DatePublished = DateTime.Parse("2003-9-26"),
                        Price = 200,
                        Author = "Buddhist and culture Department",
                        ImageUrl = "/images/dhammapadaya.jpg"
                    },
                    new Book
                    {
                    Title = "Harry Potter",
                        Description = "English Novel",
                        Language = "English",
                        ISBN = "9789129688317",
                        DatePublished = DateTime.Parse("2003-9-26"),
                        Price = 200,
                        Author = "J K Rowling",
                        ImageUrl = "/images/Harry_Potter.jpg"
                    },
                    new Book
                    {
                        Title = "Old Man and the Sea",
                        Description = "English Novel",
                        Language = "English",
                        ISBN = "9789129688317",
                        DatePublished = DateTime.Parse("2003-9-26"),
                        Price = 200,
                        Author = "Erenst Hemingway",
                        ImageUrl = "/images/old-man-and-the-sea.jpg"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
