using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IFavoritesDao
    {
        void AddMovieToFavorites(int userId, int MovieId);
        void GetAllMovieFromFavorites(int userId);
        void RemoveMovieFromFavorites(int userId, int MovieId);

    }
}