using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Tataru_Robert_Rp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Asp_Tataru_Robert_Rp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Asp_Tataru_Robert_RpContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Asp_Tataru_Robert_RpContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Godfather ",
                        ReleaseDate = DateTime.Parse("1972-2-24"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Godfather 2",
                        ReleaseDate = DateTime.Parse("1974-2-23"),
                        Genre = "Crime",
                        Price = 9.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-7-25"),
                        Genre = "Action",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
