using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                var movies = new List<Movie>();

                movies.AddRange( new Movie[] {
                    new Movie { Title = "Inception", ReleaseDate = DateTime.Parse("2010-07-16"), Genre = "Sci-Fi", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "The Dark Knight", ReleaseDate = DateTime.Parse("2008-07-18"), Genre = "Action", Price = 11.99M, Rating = "PG-13" },
                    new Movie { Title = "Casablanca", ReleaseDate = DateTime.Parse("1942-11-26"), Genre = "Drama", Price = 6.99M, Rating = "PG" },
                    new Movie { Title = "Pulp Fiction", ReleaseDate = DateTime.Parse("1994-10-14"), Genre = "Crime", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "The Matrix", ReleaseDate = DateTime.Parse("1999-03-31"), Genre = "Sci-Fi", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "The Godfather", ReleaseDate = DateTime.Parse("1972-03-24"), Genre = "Crime", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "Inglourious Basterds", ReleaseDate = DateTime.Parse("2009-08-21"), Genre = "Drama", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "Fight Club", ReleaseDate = DateTime.Parse("1999-10-15"), Genre = "Drama", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "The Great Gatsby", ReleaseDate = DateTime.Parse("2013-05-10"), Genre = "Drama", Price = 11.99M, Rating = "PG-13" },
                    new Movie { Title = "Titanic", ReleaseDate = DateTime.Parse("1997-12-19"), Genre = "Romance", Price = 10.99M, Rating = "PG-13" },
                    new Movie { Title = "Braveheart", ReleaseDate = DateTime.Parse("1995-05-24"), Genre = "Biography", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "Eternal Sunshine of the Spotless Mind", ReleaseDate = DateTime.Parse("2004-03-19"), Genre = "Drama", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "The Godfather: Part II", ReleaseDate = DateTime.Parse("1974-12-20"), Genre = "Crime", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Shawshank Redemption", ReleaseDate = DateTime.Parse("1994-09-10"), Genre = "Drama", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "The Dark Knight Rises", ReleaseDate = DateTime.Parse("2012-07-20"), Genre = "Action", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "Goodfellas", ReleaseDate = DateTime.Parse("1990-09-19"), Genre = "Biography", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "The Matrix Reloaded", ReleaseDate = DateTime.Parse("2003-05-15"), Genre = "Sci-Fi", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Matrix Revolutions", ReleaseDate = DateTime.Parse("2003-11-05"), Genre = "Sci-Fi", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "Django Unchained", ReleaseDate = DateTime.Parse("2012-12-25"), Genre = "Drama", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "The Wolf of Wall Street", ReleaseDate = DateTime.Parse("2013-12-25"), Genre = "Biography", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Revenant", ReleaseDate = DateTime.Parse("2015-12-25"), Genre = "Adventure", Price = 12.99M, Rating = "R" },
                    new Movie { Title = "Interstellar", ReleaseDate = DateTime.Parse("2014-11-07"), Genre = "Sci-Fi", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "The Social Network", ReleaseDate = DateTime.Parse("2010-10-01"), Genre = "Biography", Price = 9.99M, Rating = "PG-13" },
                    new Movie { Title = "Forrest Gump", ReleaseDate = DateTime.Parse("1994-07-06"), Genre = "Drama", Price = 9.99M, Rating = "PG-13" },
                    new Movie { Title = "The Silence of the Lambs", ReleaseDate = DateTime.Parse("1991-02-14"), Genre = "Crime", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "La La Land", ReleaseDate = DateTime.Parse("2016-12-09"), Genre = "Drama", Price = 10.99M, Rating = "PG-13" },
                    new Movie { Title = "The Grand Budapest Hotel", ReleaseDate = DateTime.Parse("2014-03-28"), Genre = "Adventure", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "A Beautiful Mind", ReleaseDate = DateTime.Parse("2001-12-21"), Genre = "Biography", Price = 10.99M, Rating = "PG-13" },
                    new Movie { Title = "Gladiator", ReleaseDate = DateTime.Parse("2000-05-05"), Genre = "Action", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "Schindler's List", ReleaseDate = DateTime.Parse("1993-12-15"), Genre = "Biography", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Pianist", ReleaseDate = DateTime.Parse("2002-12-25"), Genre = "Biography", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "The Lion King", ReleaseDate = DateTime.Parse("1994-06-24"), Genre = "Animation", Price = 8.99M, Rating = "G" },
                    new Movie { Title = "The Departed", ReleaseDate = DateTime.Parse("2006-10-06"), Genre = "Crime", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "The Godfather: Part III", ReleaseDate = DateTime.Parse("1990-12-25"), Genre = "Crime", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Terminator", ReleaseDate = DateTime.Parse("1984-10-26"), Genre = "Sci-Fi", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "Jurassic Park", ReleaseDate = DateTime.Parse("1993-06-11"), Genre = "Adventure", Price = 11.99M, Rating = "PG-13" },
                    new Movie { Title = "E.T. the Extra-Terrestrial", ReleaseDate = DateTime.Parse("1982-06-11"), Genre = "Family", Price = 8.99M, Rating = "PG" },
                    new Movie { Title = "The Shining", ReleaseDate = DateTime.Parse("1980-05-23"), Genre = "Horror", Price = 9.99M, Rating = "R" },
                    new Movie { Title = "Gone with the Wind", ReleaseDate = DateTime.Parse("1939-12-15"), Genre = "Drama", Price = 9.99M, Rating = "G" },
                    new Movie { Title = "Blade Runner", ReleaseDate = DateTime.Parse("1982-06-25"), Genre = "Sci-Fi", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "Raiders of the Lost Ark", ReleaseDate = DateTime.Parse("1981-06-12"), Genre = "Action", Price = 10.99M, Rating = "PG" },
                    new Movie { Title = "Back to the Future", ReleaseDate = DateTime.Parse("1985-07-03"), Genre = "Adventure", Price = 9.99M, Rating = "PG" },
                    new Movie { Title = "The Wizard of Oz", ReleaseDate = DateTime.Parse("1939-08-25"), Genre = "Adventure", Price = 8.99M, Rating = "PG" },
                    new Movie { Title = "Avatar", ReleaseDate = DateTime.Parse("2009-12-18"), Genre = "Action", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "The Princess Bride", ReleaseDate = DateTime.Parse("1987-09-25"), Genre = "Adventure", Price = 9.99M, Rating = "PG" },
                    new Movie { Title = "The Green Mile", ReleaseDate = DateTime.Parse("1999-12-10"), Genre = "Crime", Price = 11.99M, Rating = "R" },
                    new Movie { Title = "The Breakfast Club", ReleaseDate = DateTime.Parse("1985-02-15"), Genre = "Comedy", Price = 8.99M, Rating = "R" },
                    new Movie { Title = "The Sixth Sense", ReleaseDate = DateTime.Parse("1999-08-06"), Genre = "Drama", Price = 9.99M, Rating = "PG-13" },
                    new Movie { Title = "The Exorcist", ReleaseDate = DateTime.Parse("1973-12-26"), Genre = "Horror", Price = 10.99M, Rating = "R" },
                    new Movie { Title = "Rocky", ReleaseDate = DateTime.Parse("1976-11-21"), Genre = "Drama", Price = 9.99M, Rating = "PG" },
                    new Movie { Title = "The Sound of Music", ReleaseDate = DateTime.Parse("1965-03-02"), Genre = "Drama", Price = 9.99M, Rating = "G" },
                    new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", ReleaseDate = DateTime.Parse("2001-12-19"), Genre = "Fantasy", Price = 14.99M, Rating = "PG-13" },
                    new Movie { Title = "The Lord of the Rings: The Two Towers", ReleaseDate = DateTime.Parse("2002-12-18"), Genre = "Fantasy", Price = 14.99M, Rating = "PG-13" },
                    new Movie { Title = "The Lord of the Rings: The Return of the King", ReleaseDate = DateTime.Parse("2003-12-17"), Genre = "Fantasy", Price = 14.99M, Rating = "PG-13" },
                    new Movie { Title = "The Hobbit: An Unexpected Journey", ReleaseDate = DateTime.Parse("2012-12-14"), Genre = "Fantasy", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "The Hobbit: The Desolation of Smaug", ReleaseDate = DateTime.Parse("2013-12-13"), Genre = "Fantasy", Price = 12.99M, Rating = "PG-13" },
                    new Movie { Title = "The Hobbit: The Battle of the Five Armies", ReleaseDate = DateTime.Parse("2014-12-17"), Genre = "Fantasy", Price = 12.99M, Rating = "PG-13" }
                });

                if (context.Movie.Count() != movies.Count())
                {
                    context.Movie.RemoveRange(context.Movie);
                    context.Movie.AddRange(movies);
                    context.SaveChanges();
                }
            }
        }
    }
}
