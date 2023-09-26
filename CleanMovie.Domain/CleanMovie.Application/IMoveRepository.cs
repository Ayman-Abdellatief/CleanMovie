﻿using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMoveRepository
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}
