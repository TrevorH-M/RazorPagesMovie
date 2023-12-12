using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        public SelectList? Ratings { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieRating { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? MinPrice { get; set; }

        [BindProperty(SupportsGet = true)]
        public decimal? MaxPrice { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? MinReleaseDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? MaxReleaseDate { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get the list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;
            IQueryable<string> ratingQuery = from m in _context.Movie orderby m.Rating select m.Rating;

            var movies = from m in _context.Movie select m;



            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre)) 
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            if (!string.IsNullOrEmpty(MovieRating))
            {
                movies = movies.Where(x => x.Rating == MovieRating);
            }
            if (MinPrice.HasValue)
            {
                movies = movies.Where(x => x.Price >= MinPrice.Value);
            }

            if (MaxPrice.HasValue)
            {
                movies = movies.Where(x => x.Price <= MaxPrice.Value);
            }

            if (MinReleaseDate.HasValue)
            {
                movies = movies.Where(m => m.ReleaseDate >= MinReleaseDate);
            }

            if (MaxReleaseDate.HasValue)
            {
                movies = movies.Where(m => m.ReleaseDate <= MaxReleaseDate);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Ratings = new SelectList(await ratingQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
