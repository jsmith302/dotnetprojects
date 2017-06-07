using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions
                <MVCMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                foreach (var movie in context.Movie)
                {
                    context.Movie.Remove(movie);
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-01-11"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                      new Movie
                      {
                          Title = "Ghostbusters",
                          ReleaseDate = DateTime.Parse("1984-03-13"),
                          Genre = "Comedy",
                          Price = 7.99M,
                          Rating = "PG-13"
                      },
                        new Movie
                        {
                            Title = "HItch",
                            ReleaseDate = DateTime.Parse("2000-02-14"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating = "PG-13"
                        },
                          new Movie
                          {
                              Title = "Halloween",
                              ReleaseDate = DateTime.Parse("1990-10-31"),
                              Genre = "Horror",
                              Price = 7.99M,
                              Rating = "R"
                          });
                context.SaveChanges();
            }
        }
    }
}


