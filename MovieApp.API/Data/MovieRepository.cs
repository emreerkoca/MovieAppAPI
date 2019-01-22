using MovieApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.API.Data
{
    public class MovieRepository : IMovieRepository 
    {
        private DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        void IRepository<Movie>.Add(Movie obj)
        {
            _context.Movie.Add(obj);
            _context.SaveChanges();
        }

        void IRepository<Movie>.Delete(Movie obj)
        {
            throw new NotImplementedException();
        }
    }
}
