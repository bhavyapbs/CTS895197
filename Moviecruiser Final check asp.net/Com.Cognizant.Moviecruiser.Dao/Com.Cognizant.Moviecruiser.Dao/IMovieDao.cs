using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Moviecruiser.Utility;
using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IMovieDao
    {
        List<Movie> GetMovieListAdmin();
        List<Movie> GetMovieListCustomer();
        void ModifyMovie(Movie movie);
        Movie GetMovie(int movieId);
    }

}