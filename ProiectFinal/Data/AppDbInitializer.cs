using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProiectFinal.Data.Enums;
using ProiectFinal.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProiectFinal.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //PublishingHouse
                if (!context.PublishingHouses.Any())
                {
                    context.PublishingHouses.AddRange(new List<PublishingHouse>()
                    {
                        new PublishingHouse()
                        {
                            Name = "Litera",
                            Logo = "https://bucurestimall.ro/wp-content/uploads/2017/03/Logo-Litera.jpg",
                            Description = "Editura Litera este o editură din România și Republica Moldova care a fost fondată în 1989 de către Anatol Vidrascu, iar în anul 1989 extinsa ca editura Litera International la Bucuresti. În 25 de ani a editat peste 4 000 de titluri, cu un tiraj de aproape 46 de milioane de exemplare. "
                        },
                           new PublishingHouse()
                        {
                            Name = "Carturesti",
                            Logo = "https://bucurestimall.ro/wp-content/uploads/2019/12/Carturesti-LOGO_550x550px.jpg",
                            Description = "Cărturești este o companie care deține o rețea de 37 de librării.Bazele afacerii Cărturești au fost puse în 2000 de către Nicoleta Dumitru și Șerban Radu, cu o investiție inițială de 15.000 de dolari."
                        }
                    });
                    context.SaveChanges();
                }
                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Stephen King",
                            ProfilePictureURL = "https://www.biography.com/.image/t_share/MTc5OTcyMTI4OTU3ODAxNTk0/gettyimages-187751114.jpg",
                            Bio = "Stephen Edwin King este un autor american celebru prin romanele sale horror, acestea fiind ecranizate aproape în totalitate pe micul sau marele ecran. A scris câteva lucrări sub pseudonimul Richard Bachman."
                        },
                        new Author()
                        {
                            FullName = "Agatha Christie",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTU3OTYzMzY4NV5BMl5BanBnXkFtZTcwMDIxOTIyOA@@._V1_.jpg",
                            Bio = "Agatha Christie a fost o scriitoare engleză de romane, povestiri scurte și piese de teatru polițiste. A scris și romane de dragoste sub pseudonimul Mary Westmacott, dar acestea sunt mai puțin cunoscute, nebucurându-se de același succes la public."
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
                            Title = "Crima din Orient Express",
                            Description = "Crima din Orient Express este un roman polițist scris de scriitoarea britanică Agatha Christie. A fost publicat pentru prima oară în Regatul Unit de editura Collins Crime Club la 1 ianuarie 1934.",
                            Pages = 320,
                            Price = 30.5,
                            ImageURL = "https://s13emagst.akamaized.net/products/39539/39538415/images/res_2f491078c58e33ff60decb0b9f3702f4.jpg",
                            BookCategory = BookCategory.Crime,
                            PublishingHouseId = 1
                        },
                        new Book()
                        {
                            Title = "Stralucirea",
                            Description = "Strălucirea este un roman de groază din 1977 scris de autorul american Stephen King. Titlul a fost inspirat de melodia lui John Lennon Instant Karma!, care conține versul We all shine on…. Cartea a fost adaptată în 1997 într-o miniserie de televiziune cu același nume.",
                            Pages = 498,
                            Price = 64,
                            ImageURL = "https://cdn.dc5.ro/img-prod/150807-0.jpeg",
                            BookCategory = BookCategory.Horror,
                            PublishingHouseId= 2
                        }
                    });
                    context.SaveChanges();
                }
                //Authors & Books
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 3
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
