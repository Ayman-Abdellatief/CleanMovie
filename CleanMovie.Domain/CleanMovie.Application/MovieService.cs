using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMoveRepository _moveRepository;

        public MovieService(IMoveRepository moveRepository)
        {
            _moveRepository = moveRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
           _moveRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var Movies = _moveRepository.GetAllMovies();

            return Movies;
        }
    }
}
